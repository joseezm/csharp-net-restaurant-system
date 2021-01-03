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
    public partial class gestionCarta : MaterialSkin.Controls.MaterialForm
    {
        string identificador;
        bool comida;
        public gestionCarta()
        {
            InitializeComponent();
        }

        private void gestionCarta_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
            BD.cnn.Open();
            SqlCommand command;
            String sql;
            SqlDataReader dataReader;
            sql = "select id, nombre,estado from comida";
            command = new SqlCommand(sql, BD.cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {

                if (dataReader.GetValue(2).ToString() == "True")
                {
                    dataGridView1.Rows.Add(dataReader.GetValue(0).ToString(), dataReader.GetValue(1), "Activo");
                }
                else if (dataReader.GetValue(2).ToString() == "False")
                {
                    dataGridView1.Rows.Add(dataReader.GetValue(0).ToString(), dataReader.GetValue(1), "No Activo");
                }

            }
            dataReader.Close();

            sql = "select id,nombre,estado from bebida";
            command = new SqlCommand(sql, BD.cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {

                if (dataReader.GetValue(2).ToString() == "True")
                {
                    dataGridView2.Rows.Add(dataReader.GetValue(0).ToString(), dataReader.GetValue(1), "Activo");
                }
                else if (dataReader.GetValue(2).ToString() == "False")
                {
                    dataGridView2.Rows.Add(dataReader.GetValue(0).ToString(), dataReader.GetValue(1), "No Activo");
                }

            }
            dataReader.Close();

            materialRadioButton1.Hide();
            materialRadioButton2.Hide();
            materialFlatButton2.Hide();
            materialFlatButton3.Hide();
            comboBox1.Items.Add("Bebida");
            comboBox1.Items.Add("Comida");
            materialLabel4.Hide();
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Ver")
            {
                materialFlatButton2.Hide();
                string ident = "0";
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    ident = row.Cells[0].Value.ToString();
                }

                SqlCommand command;
                String sql;
                SqlDataReader dataReader;
                sql = "select nombre, descripcion,precio,estado from comida where id = '" + ident + "'";
                command = new SqlCommand(sql, BD.cnn);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                textBox1.Text = dataReader.GetValue(0).ToString();
                textBox2.Text = dataReader.GetValue(1).ToString();
                textBox3.Text = dataReader.GetValue(2).ToString();

                materialLabel4.Show();
                if (dataReader.GetValue(3).ToString() == "True")
                {
                    materialRadioButton2.Hide();
                    materialRadioButton1.Show();
                    materialRadioButton1.Checked = true;

                }
                else if (dataReader.GetValue(3).ToString() == "False")
                {
                    materialRadioButton1.Hide();
                    materialRadioButton2.Show();
                    materialRadioButton2.Checked = true;
                }
                comboBox1.SelectedItem = "Comida";
                dataReader.Close();

            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Modificar")
            {
                materialFlatButton2.Show();
                comida = true;

                string ident = "0";
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    ident = row.Cells[0].Value.ToString();
                    identificador = ident;
                }

                materialLabel4.Show();

                SqlCommand command;
                String sql;
                SqlDataReader dataReader;
                sql = "select nombre, descripcion,precio,estado from comida where id = '" + ident + "'";
                command = new SqlCommand(sql, BD.cnn);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                textBox1.Text = dataReader.GetValue(0).ToString();
                textBox2.Text = dataReader.GetValue(1).ToString();
                textBox3.Text = dataReader.GetValue(2).ToString();
                comboBox1.SelectedItem = "Comida";
                materialRadioButton1.Show();
                materialRadioButton2.Show();

                if (dataReader.GetValue(3).ToString() == "True")
                {
                    materialRadioButton1.Checked = true;
                }
                else if (dataReader.GetValue(3).ToString() == "False")
                {
                    materialRadioButton2.Checked = true;
                }
                dataReader.Close();
            }

            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                string ident = "0";
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    ident = row.Cells[0].Value.ToString();
                }

                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql = "delete from comida where id = " + ident;
                command = new SqlCommand(sql, BD.cnn);
                adapter.DeleteCommand = new SqlCommand(sql, BD.cnn);
                adapter.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("Borrado Exitosamente");
                BD.cnn.Close();
                gestionCarta gC2 = new gestionCarta();
                this.Hide();
                gC2.Show();

            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "VerB")
            {
                materialFlatButton2.Hide();
                string ident = "0";
                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    ident = row.Cells[0].Value.ToString();
                }

                materialLabel4.Show();
                SqlCommand command;
                String sql;
                SqlDataReader dataReader;
                sql = "select nombre, descripcion,precio,estado from bebida where id = '" + ident + "'";
                command = new SqlCommand(sql, BD.cnn);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                textBox1.Text = dataReader.GetValue(0).ToString();
                textBox2.Text = dataReader.GetValue(1).ToString();
                textBox3.Text = dataReader.GetValue(2).ToString();
                comboBox1.SelectedItem = "Bebida";


                if (dataReader.GetValue(3).ToString() == "True")
                {
                    materialRadioButton2.Hide();
                    materialRadioButton1.Show();
                    materialRadioButton1.Checked = true;

                }
                else if (dataReader.GetValue(3).ToString() == "False")
                {
                    materialRadioButton1.Hide();
                    materialRadioButton2.Show();
                    materialRadioButton2.Checked = true;
                }
                dataReader.Close();

            }

            /////////////////////////////////////////////////////////////////////////////

            else if (dataGridView2.Columns[e.ColumnIndex].Name == "ModificarB")

            {
                comida = false;
                materialFlatButton2.Show();

                string ident = "0";

                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    ident = row.Cells[0].Value.ToString();
                    identificador = ident;
                }

                materialLabel4.Show();

                SqlCommand command;
                String sql;
                SqlDataReader dataReader;
                sql = "select nombre, descripcion,precio,estado from bebida where id = '" + ident + "'";
                command = new SqlCommand(sql, BD.cnn);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                textBox1.Text = dataReader.GetValue(0).ToString();
                textBox2.Text = dataReader.GetValue(1).ToString();
                textBox3.Text = dataReader.GetValue(2).ToString();
                comboBox1.SelectedItem = "Bebida";


                materialRadioButton1.Show();
                materialRadioButton2.Show();
                if (dataReader.GetValue(3).ToString() == "True")
                {
                    materialRadioButton1.Checked = true;
                }
                else if (dataReader.GetValue(3).ToString() == "False")
                {
                    materialRadioButton2.Checked = true;
                }
                dataReader.Close();
            }

            else if (dataGridView2.Columns[e.ColumnIndex].Name == "EliminarB")
            {
                string ident = "0";
                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    ident = row.Cells[0].Value.ToString();
                }

                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql = "delete from bebida where id = " + ident;
                command = new SqlCommand(sql, BD.cnn);
                adapter.DeleteCommand = new SqlCommand(sql, BD.cnn);
                adapter.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("Borrado Exitosamente");
                BD.cnn.Close();
                gestionCarta gC2 = new gestionCarta();
                this.Hide();
                gC2.Show();

            }

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();

            String sql;
            if (comida)
            {
                if (materialRadioButton1.Checked == true)
                    sql = "update comida set nombre = '" + textBox1.Text + "', precio= '" + textBox3.Text + "', descripcion= '" + textBox2.Text + "', estado = 1  where id = " + identificador;
                else
                    sql = "update comida set nombre = '" + textBox1.Text + "', precio= '" + textBox3.Text + "', descripcion= '" + textBox2.Text + "', estado = 0  where id = " + identificador;
            }
            else
            {
                if (materialRadioButton1.Checked == true)
                    sql = "update bebida set nombre = '" + textBox1.Text + "', precio= '" + textBox3.Text + "', descripcion= '" + textBox2.Text + "', estado = 1  where id = " + identificador;
                else
                    sql = "update bebida set nombre = '" + textBox1.Text + "', precio= '" + textBox3.Text + "', descripcion= '" + textBox2.Text + "', estado = 0  where id = " + identificador;
            }

            command = new SqlCommand(sql, BD.cnn);
            adapter.UpdateCommand = new SqlCommand(sql, BD.cnn);
            adapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            materialRadioButton1.Hide();
            materialRadioButton2.Hide();
            materialFlatButton2.Hide();
            dataGridView1.RefreshEdit();

            MessageBox.Show("Modificado Correctamente");
            BD.cnn.Close();
            gestionCarta gC2 = new gestionCarta();
            this.Hide();
            gC2.Show();

        }

        private void materialFlatButton3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("No puede dejar ningun dato vacio");
            }
            else if (comboBox1.Text == "Comida")
            {
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql;
                sql = "insert into comida values('" + textBox1.Text + "'," + textBox3.Text + ",'" + textBox2.Text + "',1)";
                command = new SqlCommand(sql, BD.cnn);
                adapter.InsertCommand = new SqlCommand(sql, BD.cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Insertado Correctamente");
            }
            else if (comboBox1.Text == "Bebida")
            {
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql;
                sql = "insert into bebida values('" + textBox1.Text + "'," + textBox3.Text + ",'" + textBox2.Text + "',1)";
                command = new SqlCommand(sql, BD.cnn);
                adapter.InsertCommand = new SqlCommand(sql, BD.cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Insertado Correctamente");
            }

            BD.cnn.Close();
            gestionCarta gC2 = new gestionCarta();
            this.Hide();
            gC2.Show();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            materialRadioButton1.Hide();
            materialRadioButton2.Hide();
            materialLabel4.Hide();
            comboBox1.Text = "";
            materialFlatButton3.Show();
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            BD.cnn.Close();
            menuChefBartender cCB = new menuChefBartender();
            cCB.Show();
        }
    }
}
