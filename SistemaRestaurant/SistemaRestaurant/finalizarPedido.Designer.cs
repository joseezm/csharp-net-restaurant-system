namespace SistemaRestaurant
{
    partial class finalizarPedido
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
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ViewPedido = new System.Windows.Forms.DataGridView();
            this.idReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Finalizar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(907, 549);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(80, 36);
            this.materialFlatButton1.TabIndex = 3;
            this.materialFlatButton1.Text = "Regresar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textBox1.Location = new System.Drawing.Point(32, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 38);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "Pedidos";
            // 
            // ViewPedido
            // 
            this.ViewPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReserva,
            this.Detalles,
            this.Finalizar});
            this.ViewPedido.Location = new System.Drawing.Point(32, 129);
            this.ViewPedido.Name = "ViewPedido";
            this.ViewPedido.Size = new System.Drawing.Size(355, 272);
            this.ViewPedido.TabIndex = 23;
            this.ViewPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewPedido_CellContentClick);
            // 
            // idReserva
            // 
            this.idReserva.HeaderText = "Codigo de Pedido";
            this.idReserva.Name = "idReserva";
            // 
            // Detalles
            // 
            this.Detalles.HeaderText = "Detalles de Pedido";
            this.Detalles.Name = "Detalles";
            this.Detalles.Text = "Detalles";
            this.Detalles.UseColumnTextForButtonValue = true;
            // 
            // Finalizar
            // 
            this.Finalizar.HeaderText = "Finalizar";
            this.Finalizar.Name = "Finalizar";
            this.Finalizar.Text = "Finalizado";
            this.Finalizar.UseColumnTextForButtonValue = true;
            // 
            // finalizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ViewPedido);
            this.Controls.Add(this.materialFlatButton1);
            this.Name = "finalizarPedido";
            this.Text = "Finalizar Pedido";
            this.Load += new System.EventHandler(this.finalizarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView ViewPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReserva;
        private System.Windows.Forms.DataGridViewButtonColumn Detalles;
        private System.Windows.Forms.DataGridViewButtonColumn Finalizar;
    }
}