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
    public partial class detallesPedido : MaterialSkin.Controls.MaterialForm
    {
        public string codigo;
        public detallesPedido(string id)
        {
            InitializeComponent();
            BD.cnn.Open();
            codigo = id;
        }

        private void detallesPedido_Load(object sender, EventArgs e)
        {
            ViewDetalles.AllowUserToAddRows = false;
            string plato;
            if (BD.tipo == "chef")
                plato = "comida";
            else
                plato = "bebida";

            string sql = "select c.nombre from " + plato + " as c, detalle_pedido as d where c.id=d.id_" + plato + " and d.id_pedido=" + codigo + ";";
            SqlCommand command;
            SqlDataReader dataReader;
            command = new SqlCommand(sql, BD.cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                //DataRow nuevo;
                //ViewComida.NewRow();
                ViewDetalles.Rows.Add(dataReader.GetValue(0));
            }
            dataReader.Close();
            BD.cnn.Close();
        }

        private void ViewDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
