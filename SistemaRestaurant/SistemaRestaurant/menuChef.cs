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
    public partial class menuChef : MaterialSkin.Controls.MaterialForm
    {
        public menuChef()
        {
            InitializeComponent();
        }

        private void menuChef_Load(object sender, EventArgs e)
        {
            label1.Text = BD.nombreUser;
        }

        private void labelbienvenido_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void emitirBoleta_Click(object sender, EventArgs e)
        {
            tomarPedido tP = new tomarPedido();
            this.Hide();
            tP.Show();
        }

        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            login ll = new login();
            this.Hide();
            ll.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
