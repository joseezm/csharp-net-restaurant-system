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
    public partial class menuCaja : MaterialSkin.Controls.MaterialForm
    {
        public menuCaja()
        {
            InitializeComponent();
        }

        private void menuCaja_Load(object sender, EventArgs e)
        {
            label2.Text = BD.nombreUser;
        }

        private void emitirBoleta_Click(object sender, EventArgs e)
        {
            emitirBoleta eB = new emitirBoleta();
            this.Hide();
            eB.Show();
        }

        private void visualizarVentas_Click(object sender, EventArgs e)
        {
            this.Hide();
            cobrarBoleta cB = new cobrarBoleta();
            cB.Show();
        }

        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            login ll = new login();
            ll.Show();
        }
    }
}
