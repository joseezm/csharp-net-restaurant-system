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


/*
 * 1.5.1 Creacion de formulario login - Jose Z
 * 1.5.6 Diseño de ventana login y menu de Chef y Bartender - Jose Z
 */

namespace SistemaRestaurant
{
    public partial class login : MaterialSkin.Controls.MaterialForm
    {
        public login()
        {
            InitializeComponent();
        }

        private void loggin_Load(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }     

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BD.cnn.Open();
            string tipo;
            SqlCommand command;
            String sql, Output = "";
            SqlDataReader dataReader;
            sql = "select tipo,nombre from empleado where usuario = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "';";
            command = new SqlCommand(sql, BD.cnn);
            dataReader = command.ExecuteReader();
            dataReader.Read();
            try
            {
                
                tipo = dataReader.GetValue(0).ToString();
                BD.tipo = tipo;
                if (tipo == "chef" || tipo == "bartender")
                {
                    this.Hide();
                    menuChefBartender mCB = new menuChefBartender();
                    BD.nombreUser = dataReader.GetValue(1).ToString();
                    mCB.Show();

                }
                else if (tipo == "mozo")
                {
                    this.Hide();
                    menuChef mCB = new menuChef();
                    BD.nombreUser = dataReader.GetValue(1).ToString();
                    mCB.Show();
                    
                }
                else if (tipo == "maitre")
                {
                    this.Hide();
                    menuReserva mR = new menuReserva();
                    BD.nombreUser = dataReader.GetValue(1).ToString();
                    mR.Show();
                }
                else if (tipo == "cajero")
                {
                    this.Hide();
                    menuCaja mC = new menuCaja();
                    BD.nombreUser = dataReader.GetValue(1).ToString();
                    mC.Show();
                }
            }
            catch
            {
                MessageBox.Show("Usuario o Contraseña incorrectos");
            }
            dataReader.Close();
            BD.cnn.Close();
        }
    }
}
