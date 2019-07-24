namespace WindowsViews.Views
{
    partial class IngresoMaquinaria
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnSalir = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtDescripcionMaquina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbTipoMaquina = new System.Windows.Forms.ComboBox();
            this.TxtDescVehiculo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnDarBaja = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnBuscarMaquina = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(188)))), ((int)(((byte)(229)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 551);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.BtnDarBaja);
            this.panel4.Controls.Add(this.BtnModificar);
            this.panel4.Controls.Add(this.BtnAgregar);
            this.panel4.Location = new System.Drawing.Point(128, 183);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(509, 64);
            this.panel4.TabIndex = 21;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(142, 19);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(103, 23);
            this.BtnModificar.TabIndex = 1;
            this.BtnModificar.Text = "Modifiar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(17, 19);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(103, 23);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(74, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(627, 237);
            this.panel3.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 227);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.AutoSize = true;
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.BtnSalir.ForeColor = System.Drawing.Color.Maroon;
            this.BtnSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSalir.Location = new System.Drawing.Point(751, 0);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(26, 25);
            this.BtnSalir.TabIndex = 19;
            this.BtnSalir.Text = "X";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.BtnBuscarMaquina);
            this.panel2.Controls.Add(this.TxtDescripcionMaquina);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.CbTipoMaquina);
            this.panel2.Controls.Add(this.TxtDescVehiculo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(128, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 100);
            this.panel2.TabIndex = 17;
            // 
            // TxtDescripcionMaquina
            // 
            this.TxtDescripcionMaquina.Location = new System.Drawing.Point(240, 39);
            this.TxtDescripcionMaquina.Multiline = true;
            this.TxtDescripcionMaquina.Name = "TxtDescripcionMaquina";
            this.TxtDescripcionMaquina.Size = new System.Drawing.Size(193, 19);
            this.TxtDescripcionMaquina.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(55, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tipo Maquinaria: ";
            // 
            // CbTipoMaquina
            // 
            this.CbTipoMaquina.FormattingEnabled = true;
            this.CbTipoMaquina.Location = new System.Drawing.Point(240, 62);
            this.CbTipoMaquina.Name = "CbTipoMaquina";
            this.CbTipoMaquina.Size = new System.Drawing.Size(193, 21);
            this.CbTipoMaquina.TabIndex = 19;
            // 
            // TxtDescVehiculo
            // 
            this.TxtDescVehiculo.Location = new System.Drawing.Point(240, 14);
            this.TxtDescVehiculo.Multiline = true;
            this.TxtDescVehiculo.Name = "TxtDescVehiculo";
            this.TxtDescVehiculo.Size = new System.Drawing.Size(193, 19);
            this.TxtDescVehiculo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(55, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Id Maquinaria: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label6.Location = new System.Drawing.Point(55, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Descripcion: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Rockwell", 17F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(213, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ingreso De Nuevas Maquinarias";
            // 
            // BtnDarBaja
            // 
            this.BtnDarBaja.Location = new System.Drawing.Point(266, 19);
            this.BtnDarBaja.Name = "BtnDarBaja";
            this.BtnDarBaja.Size = new System.Drawing.Size(102, 23);
            this.BtnDarBaja.TabIndex = 2;
            this.BtnDarBaja.Text = "Dar de baja";
            this.BtnDarBaja.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(388, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // BtnBuscarMaquina
            // 
            this.BtnBuscarMaquina.Location = new System.Drawing.Point(439, 12);
            this.BtnBuscarMaquina.Name = "BtnBuscarMaquina";
            this.BtnBuscarMaquina.Size = new System.Drawing.Size(63, 23);
            this.BtnBuscarMaquina.TabIndex = 4;
            this.BtnBuscarMaquina.Text = "Buscar";
            this.BtnBuscarMaquina.UseVisualStyleBackColor = true;
            // 
            // IngresoMaquinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(804, 575);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresoMaquinaria";
            this.Text = "IngresoMaquinaria";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CbTipoMaquina;
        private System.Windows.Forms.TextBox TxtDescVehiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label BtnSalir;
        private System.Windows.Forms.TextBox TxtDescripcionMaquina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnDarBaja;
        private System.Windows.Forms.Button BtnBuscarMaquina;
    }
}