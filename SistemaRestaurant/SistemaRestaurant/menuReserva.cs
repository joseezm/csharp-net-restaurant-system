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


//1.6.3 Actualizacion funcionamiento de botones basicos, tambien correcion de cabecera de gestionReserva.cs -- Jose C

namespace SistemaRestaurant
{
    public partial class menuReserva : MaterialSkin.Controls.MaterialForm
    {
        public menuReserva()
        {
            InitializeComponent();
        }

        private void menuReserva_Load(object sender, EventArgs e)
        {
            nombreUsuario.Text = BD.nombreUser;
        }

        private void gestionarReservasButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionReserva gR = new gestionReserva();
            gR.Show();
        }

        private void cerrarSesionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.Show();
        }

        private void verReservacionesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            verReservas viewR = new verReservas();
            viewR.Show();
        }
    }
}
