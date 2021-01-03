using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  //BASE DE DATOS ///

namespace SistemaRestaurant
{
    public partial class cobrarBoleta : MaterialSkin.Controls.MaterialForm
    {
        public cobrarBoleta()
        {
            InitializeComponent();
        }

        private void cobrarBoleta_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            BD.cnn.Open();
            SqlCommand command;
            String sql;
            SqlDataReader dataReader;
            sql = "select id_boleta,fecha,id_pedido,monto from boleta";
            command = new SqlCommand(sql, BD.cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                dataGridView1.Rows.Add(dataReader.GetValue(0).ToString(), dataReader.GetValue(1).ToString(), dataReader.GetValue(2).ToString(), dataReader.GetValue(3).ToString());
            }

            dataReader.Close();
            BD.cnn.Close();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuCaja mC = new menuCaja();
            mC.Show();
        }
    }
}
