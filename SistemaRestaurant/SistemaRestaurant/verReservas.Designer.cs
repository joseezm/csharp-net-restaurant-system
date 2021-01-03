namespace SistemaRestaurant
{
    partial class verReservas
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
            this.backButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.gestionarReservaDataGridView = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminarButtons = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gestionarReservaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backButton.Depth = 0;
            this.backButton.Location = new System.Drawing.Point(906, 552);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.backButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.backButton.Name = "backButton";
            this.backButton.Primary = false;
            this.backButton.Size = new System.Drawing.Size(80, 36);
            this.backButton.TabIndex = 24;
            this.backButton.Text = "Regresar";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // gestionarReservaDataGridView
            // 
            this.gestionarReservaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gestionarReservaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column1,
            this.Column2,
            this.eliminarButtons});
            this.gestionarReservaDataGridView.Location = new System.Drawing.Point(-3, 64);
            this.gestionarReservaDataGridView.Name = "gestionarReservaDataGridView";
            this.gestionarReservaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gestionarReservaDataGridView.Size = new System.Drawing.Size(544, 542);
            this.gestionarReservaDataGridView.TabIndex = 23;
            this.gestionarReservaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gestionarReservaDataGridView_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Codigo de Reserva";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Numero de Mesa";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Hora Inicio";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hora Fin";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // eliminarButtons
            // 
            this.eliminarButtons.HeaderText = "Eliminar";
            this.eliminarButtons.Name = "eliminarButtons";
            this.eliminarButtons.Text = "Eliminar";
            // 
            // verReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.gestionarReservaDataGridView);
            this.Name = "verReservas";
            this.Text = "Ver Reservaciones";
            this.Load += new System.EventHandler(this.verReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionarReservaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton backButton;
        private System.Windows.Forms.DataGridView gestionarReservaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn eliminarButtons;
    }
}