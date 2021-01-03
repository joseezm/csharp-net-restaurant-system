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
    public partial class emitirBoleta : MaterialSkin.Controls.MaterialForm
    {
        string idPedido;
        double costototal;
        public emitirBoleta()
        {
            InitializeComponent();
        }

        private void emitirBoleta_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            BD.cnn.Open();
            SqlCommand command;
            String sql;
            SqlDataReader dataReader;
            sql = "select id from pedido where estado = '11'";
            command = new SqlCommand(sql, BD.cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                dataGridView1.Rows.Add(dataReader.GetValue(0).ToString());
            }

            fecha.Hide();
            cajero.Hide();
            pedido.Hide();
            total.Hide();
            cobrarBoleta.Hide();

            dataReader.Close();
            BD.cnn.Close();
            BD.cnn2.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "emitir")
            {

                fecha.Show();
                fecha.Text = DateTime.Now.ToString();
                cajero.Show();
                cajero.Text = BD.nombreUser;
                pedido.Show();
                total.Show();
                cobrarBoleta.Show();

                string ident = "0";
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    ident = row.Cells[0].Value.ToString();
                    idPedido = ident;
                }

                double sumaBebidas = 0;
                string detPedido = "";

                SqlCommand command;
                String sql;
                SqlDataReader dataReader;

                SqlCommand command2;
                String sql2;
                SqlDataReader dataReader2;
                BD.cnn.Open();
                BD.cnn2.Open();

                sql = "select id_bebida, count(id_bebida) from detalle_pedido where id_pedido = " + ident + " group by id_bebida ";
                command = new SqlCommand(sql, BD.cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    if (dataReader.GetValue(0).ToString() != "")
                    {
                        sql2 = "select precio,nombre from bebida where id= " + dataReader.GetValue(0).ToString();
                        command2 = new SqlCommand(sql2, BD.cnn2);
                        dataReader2 = command2.ExecuteReader();
                        dataReader2.Read();
                        sumaBebidas += Convert.ToDouble(dataReader.GetValue(1).ToString()) * Convert.ToDouble((dataReader2.GetValue(0).ToString()));
                        detPedido += dataReader.GetValue(1).ToString() + " x " + dataReader2.GetValue(1).ToString() + "       " + dataReader2.GetValue(0).ToString() + "\n";
                        dataReader2.Close();
                    }
                }
                dataReader.Close();



                sql = "select id_comida, count(id_comida) from detalle_pedido where id_pedido = " + ident + " group by id_comida ";
                command = new SqlCommand(sql, BD.cnn);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    if (dataReader.GetValue(0).ToString() != "")
                    {
                        sql2 = "select precio,nombre from comida where id= " + dataReader.GetValue(0).ToString();
                        command2 = new SqlCommand(sql2, BD.cnn2);
                        dataReader2 = command2.ExecuteReader();
                        dataReader2.Read();
                        sumaBebidas += Convert.ToDouble(dataReader.GetValue(1).ToString()) * Convert.ToDouble((dataReader2.GetValue(0).ToString()));
                        detPedido += dataReader.GetValue(1).ToString() + " x " + dataReader2.GetValue(1).ToString() + "       " + dataReader2.GetValue(0).ToString() + "\n";
                        dataReader2.Close();
                    }
                }
                dataReader.Close();


                BD.cnn.Close();
                BD.cnn2.Close();


                pedido.Text = detPedido;
                total.Text = sumaBebidas.ToString();
                costototal = sumaBebidas;

            }
        }

        private void cobrarBoleta_Click(object sender, EventArgs e)
        {
            BD.cnn.Open();
            BD.cnn2.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            String sql;
            sql = "update pedido set estado = 1 where id = " + idPedido;
            command = new SqlCommand(sql, BD.cnn);
            adapter.UpdateCommand = new SqlCommand(sql, BD.cnn);
            adapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
            MessageBox.Show("Cobro registrado correctamente");


            sql = "insert into boleta values (" + "GETDATE()" + "," + idPedido + "," + costototal.ToString() + ")";
            command = new SqlCommand(sql, BD.cnn);
            adapter.InsertCommand = new SqlCommand(sql, BD.cnn);
            adapter.InsertCommand.ExecuteNonQuery();


            BD.cnn.Close();
            BD.cnn2.Close();
            this.Hide();
            emitirBoleta eB = new emitirBoleta();
            eB.Show();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuCaja mC = new menuCaja();
            mC.Show();
        }
    }
}
