namespace SistemaRestaurant
{
    partial class emitirBoleta
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
            this.components = new System.ComponentModel.Container();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteDataSet3 = new SistemaRestaurant.RestauranteDataSet3();
            this.restauranteDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restauranteDataSet = new SistemaRestaurant.RestauranteDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.pedidoTableAdapter = new SistemaRestaurant.RestauranteDataSet3TableAdapters.pedidoTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.total = new MaterialSkin.Controls.MaterialLabel();
            this.pedido = new MaterialSkin.Controls.MaterialLabel();
            this.fecha = new MaterialSkin.Controls.MaterialLabel();
            this.cajero = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.cobrarBoleta = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emitir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "pedido";
            this.pedidoBindingSource.DataSource = this.restauranteDataSet3;
            // 
            // restauranteDataSet3
            // 
            this.restauranteDataSet3.DataSetName = "RestauranteDataSet3";
            this.restauranteDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restauranteDataSetBindingSource
            // 
            this.restauranteDataSetBindingSource.DataSource = this.restauranteDataSet;
            this.restauranteDataSetBindingSource.Position = 0;
            // 
            // restauranteDataSet
            // 
            this.restauranteDataSet.DataSetName = "RestauranteDataSet";
            this.restauranteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-14, -15);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.total);
            this.panel1.Controls.Add(this.pedido);
            this.panel1.Controls.Add(this.fecha);
            this.panel1.Controls.Add(this.cajero);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Location = new System.Drawing.Point(396, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 505);
            this.panel1.TabIndex = 8;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Depth = 0;
            this.total.Font = new System.Drawing.Font("Roboto", 11F);
            this.total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.total.Location = new System.Drawing.Point(241, 473);
            this.total.MouseState = MaterialSkin.MouseState.HOVER;
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(52, 19);
            this.total.TabIndex = 10;
            this.total.Text = "Total :";
            // 
            // pedido
            // 
            this.pedido.AutoSize = true;
            this.pedido.Depth = 0;
            this.pedido.Font = new System.Drawing.Font("Roboto", 11F);
            this.pedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pedido.Location = new System.Drawing.Point(14, 163);
            this.pedido.MouseState = MaterialSkin.MouseState.HOVER;
            this.pedido.Name = "pedido";
            this.pedido.Size = new System.Drawing.Size(57, 19);
            this.pedido.TabIndex = 9;
            this.pedido.Text = "Fecha :";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Depth = 0;
            this.fecha.Font = new System.Drawing.Font("Roboto", 11F);
            this.fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fecha.Location = new System.Drawing.Point(142, 87);
            this.fecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(57, 19);
            this.fecha.TabIndex = 7;
            this.fecha.Text = "Fecha :";
            // 
            // cajero
            // 
            this.cajero.AutoSize = true;
            this.cajero.Depth = 0;
            this.cajero.Font = new System.Drawing.Font("Roboto", 11F);
            this.cajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cajero.Location = new System.Drawing.Point(81, 57);
            this.cajero.MouseState = MaterialSkin.MouseState.HOVER;
            this.cajero.Name = "cajero";
            this.cajero.Size = new System.Drawing.Size(61, 19);
            this.cajero.TabIndex = 6;
            this.cajero.Text = "Cajero :";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(183, 473);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(52, 19);
            this.materialLabel6.TabIndex = 5;
            this.materialLabel6.Text = "Total :";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(14, 135);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(55, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Pedido";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(18, 87);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(109, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Fecha  y Hora :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(14, 57);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(61, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Cajero :";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(131, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(115, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Boleta de Venta";
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(906, 549);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(80, 36);
            this.materialFlatButton2.TabIndex = 7;
            this.materialFlatButton2.Text = "Regresar";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // cobrarBoleta
            // 
            this.cobrarBoleta.AutoSize = true;
            this.cobrarBoleta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cobrarBoleta.Depth = 0;
            this.cobrarBoleta.Location = new System.Drawing.Point(822, 297);
            this.cobrarBoleta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cobrarBoleta.MouseState = MaterialSkin.MouseState.HOVER;
            this.cobrarBoleta.Name = "cobrarBoleta";
            this.cobrarBoleta.Primary = false;
            this.cobrarBoleta.Size = new System.Drawing.Size(120, 36);
            this.cobrarBoleta.TabIndex = 6;
            this.cobrarBoleta.Text = "Cobrar Boleta";
            this.cobrarBoleta.UseVisualStyleBackColor = true;
            this.cobrarBoleta.Click += new System.EventHandler(this.cobrarBoleta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.emitir});
            this.dataGridView1.Location = new System.Drawing.Point(0, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(258, 539);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id Boleta";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // emitir
            // 
            this.emitir.DataPropertyName = "id";
            this.emitir.HeaderText = "Emitir Boleta";
            this.emitir.Name = "emitir";
            this.emitir.ReadOnly = true;
            // 
            // emitirBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.cobrarBoleta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "emitirBoleta";
            this.Text = "Emitir Boleta";
            this.Load += new System.EventHandler(this.emitirBoleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restauranteDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource restauranteDataSetBindingSource;
        private RestauranteDataSet restauranteDataSet;
        private System.Windows.Forms.Button button1;
        private RestauranteDataSet3 restauranteDataSet3;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private RestauranteDataSet3TableAdapters.pedidoTableAdapter pedidoTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel total;
        private MaterialSkin.Controls.MaterialLabel pedido;
        private MaterialSkin.Controls.MaterialLabel fecha;
        private MaterialSkin.Controls.MaterialLabel cajero;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton cobrarBoleta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewButtonColumn emitir;
    }
}