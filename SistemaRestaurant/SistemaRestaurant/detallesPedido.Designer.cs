namespace SistemaRestaurant
{
    partial class detallesPedido
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
            this.ViewDetalles = new System.Windows.Forms.DataGridView();
            this.comida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewDetalles
            // 
            this.ViewDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comida});
            this.ViewDetalles.Location = new System.Drawing.Point(65, 118);
            this.ViewDetalles.Name = "ViewDetalles";
            this.ViewDetalles.Size = new System.Drawing.Size(265, 411);
            this.ViewDetalles.TabIndex = 1;
            this.ViewDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewDetalles_CellContentClick);
            // 
            // comida
            // 
            this.comida.HeaderText = "Comida";
            this.comida.Name = "comida";
            this.comida.Width = 200;
            // 
            // detallesPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.ViewDetalles);
            this.Name = "detallesPedido";
            this.Text = "Detalles de Pedido";
            this.Load += new System.EventHandler(this.detallesPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn comida;
    }
}