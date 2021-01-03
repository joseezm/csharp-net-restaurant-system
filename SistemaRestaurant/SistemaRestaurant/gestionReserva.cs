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

//1.6.2  --gestionReserva--  Jose C
//1.6.5  --gestionReservaBotonesFuncionalidadesDemas -- Jose C

namespace SistemaRestaurant
{
    public partial class gestionReserva : MaterialSkin.Controls.MaterialForm
    {
        string aux = "";
        string codeReserva = "";
        string horaFO = "";
        public gestionReserva()
        {
            InitializeComponent();
        }
        private void gestionReserva_Load(object sender, EventArgs e)
        {
            gestionarReservaDataGridView.AllowUserToAddRows = false;
        }

        private void QueryButton_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(hiComboBox.SelectedItem.ToString()) >= Convert.ToInt32(hfComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("Por favor, ingrese una hora válida");
            }
            else
            {
                List<int> m_mesas = new List<int>();
                gestionarReservaDataGridView.Rows.Clear();
                BD.cnn.Open();
                SqlCommand command;
                String sql;
                SqlDataReader dataReader;
                sql = "select id_mesa from reserva where hora_inicio >= CAST('" + hiComboBox.SelectedItem.ToString() + "'AS int) and hora_fin <= CAST('" + hfComboBox.SelectedItem.ToString() + "'AS int) GROUP BY id_mesa";
                command = new SqlCommand(sql, BD.cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    m_mesas.Add(Convert.ToInt32(dataReader.GetValue(0)));
                }
                dataReader.Close();
                BD.cnn.Close();

                if (m_mesas.Count == 0)
                {
                    BD.cnn.Open();
                    SqlCommand command2;
                    String sql2;
                    SqlDataReader dataReader2;
                    sql2 = "select id,sillas from mesa";
                    command2 = new SqlCommand(sql2, BD.cnn);
                    dataReader2 = command2.ExecuteReader();
                    while (dataReader2.Read())
                    {
                        gestionarReservaDataGridView.Rows.Add(dataReader2.GetValue(0), dataReader2.GetValue(1));
                    }
                    dataReader2.Close();
                    BD.cnn.Close();
                }
                else
                {
                    if (m_mesas.Count == 1)
                    {
                        BD.cnn.Open();
                        SqlCommand command4;
                        String sql4;
                        SqlDataReader dataReader4;
                        sql4 = "select id ,sillas from mesa where id <> CAST('" + m_mesas[0] + "' AS int)";
                        command4 = new SqlCommand(sql4, BD.cnn);
                        dataReader4 = command4.ExecuteReader();
                        while (dataReader4.Read())
                        {
                            gestionarReservaDataGridView.Rows.Add(dataReader4.GetValue(0), dataReader4.GetValue(1));
                        }
                        dataReader4.Close();
                        BD.cnn.Close();
                    }
                    else if (m_mesas.Count == 2)
                    {
                        BD.cnn.Open();
                        SqlCommand command4;
                        String sql4;
                        SqlDataReader dataReader4;
                        sql4 = "select id ,sillas from mesa where id <> CAST('" + m_mesas[0] + "' AS int) and id <> CAST('" + m_mesas[1] + "'AS int)";
                        command4 = new SqlCommand(sql4, BD.cnn);
                        dataReader4 = command4.ExecuteReader();
                        while (dataReader4.Read())
                        {
                            gestionarReservaDataGridView.Rows.Add(dataReader4.GetValue(0), dataReader4.GetValue(1));
                        }
                        dataReader4.Close();
                        BD.cnn.Close();
                    }
                    else if (m_mesas.Count == 3)
                    {
                        BD.cnn.Open();
                        SqlCommand command4;
                        String sql4;
                        SqlDataReader dataReader4;
                        sql4 = "select id ,sillas from mesa where id <> CAST('" + m_mesas[0] + "' AS int) and id <> CAST('" + m_mesas[1] + "'AS int) and id <> CAST('" + m_mesas[2] + "'AS int)";
                        command4 = new SqlCommand(sql4, BD.cnn);
                        dataReader4 = command4.ExecuteReader();
                        while (dataReader4.Read())
                        {
                            gestionarReservaDataGridView.Rows.Add(dataReader4.GetValue(0), dataReader4.GetValue(1));
                        }
                        dataReader4.Close();
                        BD.cnn.Close();
                    }
                    m_mesas.Clear();
                }
            }
        }

        private void gestionarReservaDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (gestionarReservaDataGridView.Columns[e.ColumnIndex].Name == "reservarButtons2")
            {
                foreach (DataGridViewRow row in gestionarReservaDataGridView.SelectedRows)
                {
                    aux = row.Cells[0].Value.ToString();
                }
                BD.cnn.Open();
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();

                String sql;
                sql = "insert into reserva values (CAST('" + aux + "' AS int), CAST('" + hiComboBox.SelectedItem.ToString() + "' AS int), CAST('" + hfComboBox.SelectedItem.ToString() + "' AS int), null)";
                command = new SqlCommand(sql, BD.cnn);
                adapter.InsertCommand = new SqlCommand(sql, BD.cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                BD.cnn.Close();

                BD.cnn.Open();
                SqlCommand command3;
                String sql3;
                SqlDataReader dataReader3;
                sql3 = "select id from reserva where id_mesa = CAST('" + aux + "'AS int)";
                command3 = new SqlCommand(sql3, BD.cnn);
                dataReader3 = command3.ExecuteReader();
                while (dataReader3.Read())
                {
                    codeReserva = dataReader3.GetValue(0).ToString();
                }
                dataReader3.Close();
                BD.cnn.Close();

                MessageBox.Show("Reservado Correctamente \n Su codigo de Reserva es: '" + codeReserva);


                List<int> m_mesas = new List<int>();
                gestionarReservaDataGridView.Rows.Clear();
                BD.cnn.Open();
                SqlCommand command2;
                String sql2;
                SqlDataReader dataReader2;
                sql2 = "select id_mesa from reserva where hora_inicio >= CAST('" + hiComboBox.SelectedItem.ToString() + "'AS int) and hora_fin <= CAST('" + hfComboBox.SelectedItem.ToString() + "'AS int) GROUP BY id_mesa";
                command2 = new SqlCommand(sql2, BD.cnn);
                dataReader2 = command2.ExecuteReader();
                while (dataReader2.Read())
                {
                    m_mesas.Add(Convert.ToInt32(dataReader2.GetValue(0)));
                }
                dataReader2.Close();
                BD.cnn.Close();

                if (m_mesas.Count == 0)
                {
                    BD.cnn.Open();
                    SqlCommand command4;
                    String sql4;
                    SqlDataReader dataReader4;
                    sql4 = "select id,sillas from mesa";
                    command4 = new SqlCommand(sql4, BD.cnn);
                    dataReader4 = command4.ExecuteReader();
                    while (dataReader4.Read())
                    {
                        gestionarReservaDataGridView.Rows.Add(dataReader4.GetValue(0), dataReader4.GetValue(1));
                    }
                    dataReader4.Close();
                    BD.cnn.Close();
                }
                else
                {
                    if (m_mesas.Count == 1)
                    {
                        BD.cnn.Open();
                        SqlCommand command4;
                        String sql4;
                        SqlDataReader dataReader4;
                        sql4 = "select id ,sillas from mesa where id <> CAST('" + m_mesas[0] + "' AS int)";
                        command4 = new SqlCommand(sql4, BD.cnn);
                        dataReader4 = command4.ExecuteReader();
                        while (dataReader4.Read())
                        {
                            gestionarReservaDataGridView.Rows.Add(dataReader4.GetValue(0), dataReader4.GetValue(1));
                        }
                        dataReader4.Close();
                        BD.cnn.Close();
                    }
                    else if (m_mesas.Count == 2)
                    {
                        BD.cnn.Open();
                        SqlCommand command4;
                        String sql4;
                        SqlDataReader dataReader4;
                        sql4 = "select id ,sillas from mesa where id <> CAST('" + m_mesas[0] + "' AS int) and id <> CAST('" + m_mesas[1] + "'AS int)";
                        command4 = new SqlCommand(sql4, BD.cnn);
                        dataReader4 = command4.ExecuteReader();
                        while (dataReader4.Read())
                        {
                            gestionarReservaDataGridView.Rows.Add(dataReader4.GetValue(0), dataReader4.GetValue(1));
                        }
                        dataReader4.Close();
                        BD.cnn.Close();
                    }
                    else if (m_mesas.Count == 3)
                    {
                        BD.cnn.Open();
                        SqlCommand command4;
                        String sql4;
                        SqlDataReader dataReader4;
                        sql4 = "select id ,sillas from mesa where id <> CAST('" + m_mesas[0] + "' AS int) and id <> CAST('" + m_mesas[1] + "'AS int) and id <> CAST('" + m_mesas[2] + "'AS int)";
                        command4 = new SqlCommand(sql4, BD.cnn);
                        dataReader4 = command4.ExecuteReader();
                        while (dataReader4.Read())
                        {
                            gestionarReservaDataGridView.Rows.Add(dataReader4.GetValue(0), dataReader4.GetValue(1));
                        }
                        dataReader4.Close();
                        BD.cnn.Close();
                    }
                    m_mesas.Clear();
                }
            }
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            menuReserva mR = new menuReserva();
            mR.Show();
        }
    }
}
