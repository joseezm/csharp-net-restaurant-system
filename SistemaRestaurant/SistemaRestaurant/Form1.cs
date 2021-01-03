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

1.0 inciial - Jose Z
1.1 prueba de base de datos - Jose Z
1.2 prueba de base de datos 2 - Jose Z
1.3 prueba de base de datos 3 - Jose Z
1.4 prueba de base de datos con datos artificiales - Jose Z
*/

namespace SistemaRestaurant
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            BD.cnn.Open();
        }


        // TEST - Jose Z
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            String sql, Output = "";
            SqlDataReader dataReader;
            sql = "select * from empleado";
            command = new SqlCommand(sql, BD.cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(1) + "\n";
            }
            MessageBox.Show(Output);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // -------------------
    }
}
