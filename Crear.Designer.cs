namespace Carvajal
{
    partial class Crear
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Aerolinia = new System.Windows.Forms.TextBox();
            this.Corigen = new System.Windows.Forms.TextBox();
            this.Nvuelo = new System.Windows.Forms.TextBox();
            this.Cdestino = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.Horallegada = new System.Windows.Forms.DateTimePicker();
            this.HoraSalida = new System.Windows.Forms.DateTimePicker();
            this.estado = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.41636F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.58364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tableLayoutPanel1.Controls.Add(this.Aerolinia, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Corigen, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Nvuelo, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.Cdestino, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.fecha, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Horallegada, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.HoraSalida, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.estado, 4, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.63768F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.36232F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Aerolinia
            // 
            this.Aerolinia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Aerolinia.Location = new System.Drawing.Point(138, 109);
            this.Aerolinia.Name = "Aerolinia";
            this.Aerolinia.Size = new System.Drawing.Size(116, 23);
            this.Aerolinia.TabIndex = 10;
            // 
            // Corigen
            // 
            this.Corigen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Corigen.Location = new System.Drawing.Point(138, 151);
            this.Corigen.Name = "Corigen";
            this.Corigen.Size = new System.Drawing.Size(116, 23);
            this.Corigen.TabIndex = 11;
            // 
            // Nvuelo
            // 
            this.Nvuelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nvuelo.Location = new System.Drawing.Point(615, 109);
            this.Nvuelo.Name = "Nvuelo";
            this.Nvuelo.Size = new System.Drawing.Size(140, 23);
            this.Nvuelo.TabIndex = 7;
            this.Nvuelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nvuelo_KeyPress);
            // 
            // Cdestino
            // 
            this.Cdestino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cdestino.Location = new System.Drawing.Point(615, 195);
            this.Cdestino.Name = "Cdestino";
            this.Cdestino.Size = new System.Drawing.Size(140, 23);
            this.Cdestino.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(483, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora salida";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(289, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Vuelo";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(31, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Aerolinia";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(470, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ciudad destino";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ciudad origen";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(491, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "N° Vuelo";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora llegada";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(499, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Estado";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(42, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Fecha";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(288, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 50);
            this.button1.TabIndex = 19;
            this.button1.Text = "Guardar datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fecha
            // 
            this.fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fecha.CustomFormat = "dd-MM-yyyy";
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha.Location = new System.Drawing.Point(138, 242);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(116, 23);
            this.fecha.TabIndex = 20;
            // 
            // Horallegada
            // 
            this.Horallegada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Horallegada.CustomFormat = "hh:mm:ss";
            this.Horallegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Horallegada.Location = new System.Drawing.Point(138, 195);
            this.Horallegada.Name = "Horallegada";
            this.Horallegada.Size = new System.Drawing.Size(116, 23);
            this.Horallegada.TabIndex = 21;
            // 
            // HoraSalida
            // 
            this.HoraSalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HoraSalida.CustomFormat = "hh:mm:ss";
            this.HoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HoraSalida.Location = new System.Drawing.Point(615, 151);
            this.HoraSalida.Name = "HoraSalida";
            this.HoraSalida.Size = new System.Drawing.Size(140, 23);
            this.HoraSalida.TabIndex = 22;
            // 
            // estado
            // 
            this.estado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.estado.FormattingEnabled = true;
            this.estado.Items.AddRange(new object[] {
            "Llegada",
            "Salida"});
            this.estado.Location = new System.Drawing.Point(615, 242);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(140, 23);
            this.estado.TabIndex = 24;
            // 
            // Crear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Crear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear";
            this.Load += new System.EventHandler(this.Crear_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Aerolinia;
        private System.Windows.Forms.TextBox Corigen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Nvuelo;
        private System.Windows.Forms.TextBox Cdestino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.DateTimePicker Horallegada;
        private System.Windows.Forms.DateTimePicker HoraSalida;
        private System.Windows.Forms.ComboBox estado;
    }
}