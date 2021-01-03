namespace SistemaRestaurant
{
    partial class gestionReserva
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
            this.QueryButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.hfComboBox = new System.Windows.Forms.ComboBox();
            this.hiComboBox = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.gestionarReservaDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservarButtons2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gestionarReservaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backButton.Depth = 0;
            this.backButton.Location = new System.Drawing.Point(907, 550);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.backButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.backButton.Name = "backButton";
            this.backButton.Primary = false;
            this.backButton.Size = new System.Drawing.Size(80, 36);
            this.backButton.TabIndex = 34;
            this.backButton.Text = "Regresar";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click_1);
            // 
            // QueryButton
            // 
            this.QueryButton.AutoSize = true;
            this.QueryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.QueryButton.Depth = 0;
            this.QueryButton.Location = new System.Drawing.Point(638, 301);
            this.QueryButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.QueryButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Primary = false;
            this.QueryButton.Size = new System.Drawing.Size(91, 36);
            this.QueryButton.TabIndex = 33;
            this.QueryButton.Text = "Consultar";
            this.QueryButton.UseVisualStyleBackColor = true;
            this.QueryButton.Click += new System.EventHandler(this.QueryButton_Click_1);
            // 
            // hfComboBox
            // 
            this.hfComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hfComboBox.FormattingEnabled = true;
            this.hfComboBox.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22"});
            this.hfComboBox.Location = new System.Drawing.Point(638, 264);
            this.hfComboBox.Name = "hfComboBox";
            this.hfComboBox.Size = new System.Drawing.Size(79, 28);
            this.hfComboBox.TabIndex = 32;
            // 
            // hiComboBox
            // 
            this.hiComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiComboBox.FormattingEnabled = true;
            this.hiComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.hiComboBox.Location = new System.Drawing.Point(638, 186);
            this.hiComboBox.Name = "hiComboBox";
            this.hiComboBox.Size = new System.Drawing.Size(79, 28);
            this.hiComboBox.TabIndex = 31;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(634, 229);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(66, 19);
            this.materialLabel4.TabIndex = 30;
            this.materialLabel4.Text = "Hora Fin";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(634, 152);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(83, 19);
            this.materialLabel1.TabIndex = 29;
            this.materialLabel1.Text = "Hora Inicio";
            // 
            // gestionarReservaDataGridView
            // 
            this.gestionarReservaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gestionarReservaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.reservarButtons2});
            this.gestionarReservaDataGridView.Location = new System.Drawing.Point(-1, 63);
            this.gestionarReservaDataGridView.Name = "gestionarReservaDataGridView";
            this.gestionarReservaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gestionarReservaDataGridView.Size = new System.Drawing.Size(343, 538);
            this.gestionarReservaDataGridView.TabIndex = 28;
            this.gestionarReservaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gestionarReservaDataGridView_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mesa";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nº sillas";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // reservarButtons2
            // 
            this.reservarButtons2.HeaderText = "Reservar";
            this.reservarButtons2.Name = "reservarButtons2";
            this.reservarButtons2.Text = "Reservar";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(723, 268);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(29, 19);
            this.materialLabel3.TabIndex = 38;
            this.materialLabel3.Text = ":00";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(723, 190);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(29, 19);
            this.materialLabel2.TabIndex = 37;
            this.materialLabel2.Text = ":00";
            // 
            // gestionReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.QueryButton);
            this.Controls.Add(this.hfComboBox);
            this.Controls.Add(this.hiComboBox);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.gestionarReservaDataGridView);
            this.Name = "gestionReserva";
            this.Text = "Gestion Reserva";
            this.Load += new System.EventHandler(this.gestionReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionarReservaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton backButton;
        private MaterialSkin.Controls.MaterialFlatButton QueryButton;
        private System.Windows.Forms.ComboBox hfComboBox;
        private System.Windows.Forms.ComboBox hiComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView gestionarReservaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn reservarButtons2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}