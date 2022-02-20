namespace Carvajal
{
    partial class Bienvenido
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvueloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aerolineaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadorigenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudaddestinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaentradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vuelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carvajalDataBienvenidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carvajalDataBienvenido = new Carvajal.carvajalDataBienvenido();
            this.vuelosTableAdapter = new Carvajal.carvajalDataBienvenidoTableAdapters.vuelosTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vuelosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carvajalDataBienvenidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carvajalDataBienvenido)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.75258F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.23944F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.76057F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(117, 369);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ingresar al sistema";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Carvajal.Properties.Resources.billete_de_avion;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nvueloDataGridViewTextBoxColumn,
            this.aerolineaDataGridViewTextBoxColumn,
            this.ciudadorigenDataGridViewTextBoxColumn,
            this.horasalidaDataGridViewTextBoxColumn,
            this.ciudaddestinoDataGridViewTextBoxColumn,
            this.horaentradaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vuelosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(133, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(543, 369);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nvueloDataGridViewTextBoxColumn
            // 
            this.nvueloDataGridViewTextBoxColumn.DataPropertyName = "nvuelo";
            this.nvueloDataGridViewTextBoxColumn.HeaderText = "nvuelo";
            this.nvueloDataGridViewTextBoxColumn.Name = "nvueloDataGridViewTextBoxColumn";
            this.nvueloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aerolineaDataGridViewTextBoxColumn
            // 
            this.aerolineaDataGridViewTextBoxColumn.DataPropertyName = "aerolinea";
            this.aerolineaDataGridViewTextBoxColumn.HeaderText = "aerolinea";
            this.aerolineaDataGridViewTextBoxColumn.Name = "aerolineaDataGridViewTextBoxColumn";
            this.aerolineaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciudadorigenDataGridViewTextBoxColumn
            // 
            this.ciudadorigenDataGridViewTextBoxColumn.DataPropertyName = "ciudad_origen";
            this.ciudadorigenDataGridViewTextBoxColumn.HeaderText = "ciudad_origen";
            this.ciudadorigenDataGridViewTextBoxColumn.Name = "ciudadorigenDataGridViewTextBoxColumn";
            this.ciudadorigenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horasalidaDataGridViewTextBoxColumn
            // 
            this.horasalidaDataGridViewTextBoxColumn.DataPropertyName = "hora_salida";
            this.horasalidaDataGridViewTextBoxColumn.HeaderText = "hora_salida";
            this.horasalidaDataGridViewTextBoxColumn.Name = "horasalidaDataGridViewTextBoxColumn";
            this.horasalidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciudaddestinoDataGridViewTextBoxColumn
            // 
            this.ciudaddestinoDataGridViewTextBoxColumn.DataPropertyName = "ciudad_destino";
            this.ciudaddestinoDataGridViewTextBoxColumn.HeaderText = "ciudad_destino";
            this.ciudaddestinoDataGridViewTextBoxColumn.Name = "ciudaddestinoDataGridViewTextBoxColumn";
            this.ciudaddestinoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaentradaDataGridViewTextBoxColumn
            // 
            this.horaentradaDataGridViewTextBoxColumn.DataPropertyName = "hora_entrada";
            this.horaentradaDataGridViewTextBoxColumn.HeaderText = "hora_entrada";
            this.horaentradaDataGridViewTextBoxColumn.Name = "horaentradaDataGridViewTextBoxColumn";
            this.horaentradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vuelosBindingSource
            // 
            this.vuelosBindingSource.DataMember = "vuelos";
            this.vuelosBindingSource.DataSource = this.carvajalDataBienvenidoBindingSource;
            // 
            // carvajalDataBienvenidoBindingSource
            // 
            this.carvajalDataBienvenidoBindingSource.DataSource = this.carvajalDataBienvenido;
            this.carvajalDataBienvenidoBindingSource.Position = 0;
            // 
            // carvajalDataBienvenido
            // 
            this.carvajalDataBienvenido.DataSetName = "carvajalDataBienvenido";
            this.carvajalDataBienvenido.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vuelosTableAdapter
            // 
            this.vuelosTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Bienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bienvenido";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Bienvenido_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vuelosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carvajalDataBienvenidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carvajalDataBienvenido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource carvajalDataBienvenidoBindingSource;
        private carvajalDataBienvenido carvajalDataBienvenido;
        private System.Windows.Forms.BindingSource vuelosBindingSource;
        private carvajalDataBienvenidoTableAdapters.vuelosTableAdapter vuelosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvueloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aerolineaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadorigenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudaddestinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaentradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
    }
}
