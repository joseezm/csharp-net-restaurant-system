using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //BASE DE DATOS

namespace SistemaRestaurant
{
    public partial class finalizarPedido : MaterialSkin.Controls.MaterialForm
    {
        public finalizarPedido()
        {
            InitializeComponent();
            BD.cnn.Open();
        }

        private void finalizarPedido_Load(object sender, EventArgs e)
        {
            RefreshTable();
            ViewPedido.AllowUserToAddRows = false;
        }

        public void RefreshTable()
        {

            ViewPedido.Rows.Clear();

            string estado, parte;
            if (BD.tipo == "chef")
            {
                //lo que le falta
                estado = "comida";
                parte = "0%";
            }
            else
            {
                estado = "bebida";
                parte = "%0";
            }


            string sql = "select r.id_pedido from reserva as r, pedido as p WHERE r.id_pedido=p.id and p.estado LIKE '" + parte + "';";
            SqlCommand command;
            SqlDataReader dataReader;
            command = new SqlCommand(sql, BD.cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                ViewPedido.Rows.Add(dataReader.GetValue(0));
            }
            dataReader.Close();
        }

        
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            BD.cnn.Close();
            this.Hide();
            Form back = new menuChefBartender();
            back.ShowDialog();
            this.Close();
        }

        private void ViewPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (ViewPedido.Columns[e.ColumnIndex].Name == "Detalles")
            {
                Form detalle = new detallesPedido(ViewPedido.Rows[e.RowIndex].Cells[0].Value.ToString());
                detalle.ShowDialog();
                


            }
            if (ViewPedido.Columns[e.ColumnIndex].Name == "Finalizar")
            {
                int fila = e.RowIndex;
                string sql;

                BD.cnn.Open();

                if (BD.tipo == "chef")
                    sql = "UPDATE pedido SET estado = '1' + substring(estado, 2, len(estado)) WHERE id=" + ViewPedido.Rows[fila].Cells[0].Value.ToString() + ";";
                else
                    sql = "UPDATE pedido SET estado = substring(estado, 2, len(estado)) + '1' WHERE id=" + ViewPedido.Rows[fila].Cells[0].Value.ToString() + ";";

                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                command = new SqlCommand(sql, BD.cnn);
                adapter.UpdateCommand = new SqlCommand(sql, BD.cnn);
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();
                RefreshTable();
                BD.cnn.Close();
            }
        }

        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {
            BD.cnn.Close();
            this.Hide();
            menuChefBartender mC = new menuChefBartender();
            mC.Show();
            
        }
    }
}
