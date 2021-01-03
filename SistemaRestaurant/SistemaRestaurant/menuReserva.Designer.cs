namespace SistemaRestaurant
{
    partial class menuReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombreUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrarSesionButton = new System.Windows.Forms.Button();
            this.gestionarReservasButton = new System.Windows.Forms.Button();
            this.verReservacionesButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSize = true;
            this.nombreUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUsuario.Location = new System.Drawing.Point(506, 206);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(240, 38);
            this.nombreUsuario.TabIndex = 5;
            this.nombreUsuario.Text = "nombreUsuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 83);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bienvenido";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.verReservacionesButton);
            this.panel1.Controls.Add(this.cerrarSesionButton);
            this.panel1.Controls.Add(this.gestionarReservasButton);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 540);
            this.panel1.TabIndex = 3;
            // 
            // cerrarSesionButton
            // 
            this.cerrarSesionButton.Location = new System.Drawing.Point(0, 477);
            this.cerrarSesionButton.Name = "cerrarSesionButton";
            this.cerrarSesionButton.Size = new System.Drawing.Size(230, 61);
            this.cerrarSesionButton.TabIndex = 5;
            this.cerrarSesionButton.Text = "Cerrar sesión";
            this.cerrarSesionButton.UseVisualStyleBackColor = true;
            this.cerrarSesionButton.Click += new System.EventHandler(this.cerrarSesionButton_Click);
            // 
            // gestionarReservasButton
            // 
            this.gestionarReservasButton.Location = new System.Drawing.Point(0, 0);
            this.gestionarReservasButton.Name = "gestionarReservasButton";
            this.gestionarReservasButton.Size = new System.Drawing.Size(230, 61);
            this.gestionarReservasButton.TabIndex = 3;
            this.gestionarReservasButton.Text = "Añadir reservaciones";
            this.gestionarReservasButton.UseVisualStyleBackColor = true;
            this.gestionarReservasButton.Click += new System.EventHandler(this.gestionarReservasButton_Click);
            // 
            // verReservacionesButton
            // 
            this.verReservacionesButton.Location = new System.Drawing.Point(0, 59);
            this.verReservacionesButton.Name = "verReservacionesButton";
            this.verReservacionesButton.Size = new System.Drawing.Size(230, 67);
            this.verReservacionesButton.TabIndex = 7;
            this.verReservacionesButton.Text = "Gestionar reservaciones";
            this.verReservacionesButton.UseVisualStyleBackColor = true;
            this.verReservacionesButton.Click += new System.EventHandler(this.verReservacionesButton_Click);
            // 
            // menuReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.nombreUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "menuReserva";
            this.Text = "Menu Reserva";
            this.Load += new System.EventHandler(this.menuReserva_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cerrarSesionButton;
        private System.Windows.Forms.Button gestionarReservasButton;
        private System.Windows.Forms.Button verReservacionesButton;
    }
}