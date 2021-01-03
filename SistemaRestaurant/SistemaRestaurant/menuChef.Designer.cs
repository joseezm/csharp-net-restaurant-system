namespace SistemaRestaurant
{
    partial class menuChef
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelbienvenido = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrarSesion = new System.Windows.Forms.Button();
            this.emitirBoleta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(538, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelbienvenido
            // 
            this.labelbienvenido.AutoSize = true;
            this.labelbienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F);
            this.labelbienvenido.Location = new System.Drawing.Point(406, 97);
            this.labelbienvenido.Name = "labelbienvenido";
            this.labelbienvenido.Size = new System.Drawing.Size(403, 85);
            this.labelbienvenido.TabIndex = 12;
            this.labelbienvenido.Text = "Bienvenido";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cerrarSesion);
            this.panel1.Controls.Add(this.emitirBoleta);
            this.panel1.Location = new System.Drawing.Point(2, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 540);
            this.panel1.TabIndex = 11;
            // 
            // cerrarSesion
            // 
            this.cerrarSesion.Location = new System.Drawing.Point(0, 474);
            this.cerrarSesion.Name = "cerrarSesion";
            this.cerrarSesion.Size = new System.Drawing.Size(230, 61);
            this.cerrarSesion.TabIndex = 6;
            this.cerrarSesion.Text = "Cerrar Sesión";
            this.cerrarSesion.UseVisualStyleBackColor = true;
            this.cerrarSesion.Click += new System.EventHandler(this.cerrarSesion_Click);
            // 
            // emitirBoleta
            // 
            this.emitirBoleta.Location = new System.Drawing.Point(0, 0);
            this.emitirBoleta.Name = "emitirBoleta";
            this.emitirBoleta.Size = new System.Drawing.Size(230, 61);
            this.emitirBoleta.TabIndex = 2;
            this.emitirBoleta.Text = "Tomar Pedido";
            this.emitirBoleta.UseVisualStyleBackColor = true;
            this.emitirBoleta.Click += new System.EventHandler(this.emitirBoleta_Click);
            // 
            // menuChef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelbienvenido);
            this.Controls.Add(this.panel1);
            this.Name = "menuChef";
            this.Text = "menuChef";
            this.Load += new System.EventHandler(this.menuChef_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelbienvenido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cerrarSesion;
        private System.Windows.Forms.Button emitirBoleta;
    }
}