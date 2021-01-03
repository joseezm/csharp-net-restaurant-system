using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRestaurant
{
    public partial class menuChefBartender : MaterialSkin.Controls.MaterialForm
    {
        public menuChefBartender()
        {
            InitializeComponent();
        }

        private void menuChefBartender_Load(object sender, EventArgs e)
        {
            label2.Text = BD.nombreUser;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void emitirBoleta_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionCarta gC = new gestionCarta();
            gC.Show();
        }

        private void visualizarVentas_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BD.nombreUser = "";
            this.Hide();
            login ll = new login();
            ll.Show();
            BD.cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            finalizarPedido ll = new finalizarPedido();
            ll.Show();
            BD.cnn.Close();
        }
    }
}
