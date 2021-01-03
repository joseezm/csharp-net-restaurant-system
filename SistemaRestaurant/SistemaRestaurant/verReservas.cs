using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SistemaRestaurant
{
    public partial class verReservas : MaterialSkin.Controls.MaterialForm
    {
        string aux = "";
        public verReservas()
        {
            InitializeComponent();
        }

        private void verReservas_Load(object sender, EventArgs e)
        {
            gestionarReservaDataGridView.AllowUserToAddRows = false;
            gestionarReservaDataGridView.Rows.Clear();
            BD.cnn.Open();
            SqlCommand command;
            String sql;
            SqlDataReader dataReader;
            sql = "select id,id_mesa,hora_inicio,hora_fin from reserva order by hora_inicio,hora_fin";
            command = new SqlCommand(sql, BD.cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                gestionarReservaDataGridView.Rows.Add(dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetValue(2), dataReader.GetValue(3));
            }
            dataReader.Close();
            BD.cnn.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuReserva mR = new menuReserva();
            mR.Show();
        }

        private void gestionarReservaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gestionarReservaDataGridView.Columns[e.ColumnIndex].Name == "eliminarButtons")
            {
                foreach (DataGridViewRow row in gestionarReservaDataGridView.SelectedRows)
                {
                    aux = row.Cells[0].Value.ToString();
                }
                BD.cnn.Open();
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql;
                sql = "delete reserva where id = CAST('" + aux + "' AS int)";
                command = new SqlCommand(sql, BD.cnn);
                adapter.DeleteCommand = new SqlCommand(sql, BD.cnn);
                adapter.DeleteCommand.ExecuteNonQuery();
                command.Dispose();
                BD.cnn.Close();
                MessageBox.Show("Eliminado Correctamente");


                gestionarReservaDataGridView.Rows.Clear();
                BD.cnn.Open();
                SqlCommand command2;
                String sql2;
                SqlDataReader dataReader;
                sql2 = "select id,id_mesa,hora_inicio,hora_fin from reserva order by hora_inicio,hora_fin";
                command2 = new SqlCommand(sql2, BD.cnn);
                dataReader = command2.ExecuteReader();
                while (dataReader.Read())
                {
                    gestionarReservaDataGridView.Rows.Add(dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetValue(2), dataReader.GetValue(3));
                }
                dataReader.Close();
                BD.cnn.Close();
            }
        }
    }
}
