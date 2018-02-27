namespace SysPandemic
{
    partial class agrescitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agrescitas));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidpa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtiddo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtphora = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.txtpaciente = new System.Windows.Forms.TextBox();
            this.txtdoct = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtbuscardoc = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtbuscarp = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btncanc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cita";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(85, 19);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Paciente #:";
            // 
            // txtidpa
            // 
            this.txtidpa.Location = new System.Drawing.Point(74, 61);
            this.txtidpa.Name = "txtidpa";
            this.txtidpa.ReadOnly = true;
            this.txtidpa.Size = new System.Drawing.Size(38, 20);
            this.txtidpa.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Paciente:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Doctor:";
            // 
            // dtpfecha
            // 
            this.dtpfecha.CustomFormat = "dd/MM/yyyy";
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfecha.Location = new System.Drawing.Point(45, 26);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(87, 20);
            this.dtpfecha.TabIndex = 10;
            this.dtpfecha.Value = new System.DateTime(2017, 12, 7, 0, 0, 0, 0);
            this.dtpfecha.ValueChanged += new System.EventHandler(this.dtpfecha_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(426, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Doctor #:";
            // 
            // txtiddo
            // 
            this.txtiddo.Location = new System.Drawing.Point(484, 61);
            this.txtiddo.Name = "txtiddo";
            this.txtiddo.ReadOnly = true;
            this.txtiddo.Size = new System.Drawing.Size(54, 20);
            this.txtiddo.TabIndex = 12;
            this.txtiddo.TextChanged += new System.EventHandler(this.txtiddo_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Dia:";
            // 
            // dtphora
            // 
            this.dtphora.CustomFormat = "hh:mm tt";
            this.dtphora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtphora.Location = new System.Drawing.Point(212, 26);
            this.dtphora.Name = "dtphora";
            this.dtphora.ShowUpDown = true;
            this.dtphora.Size = new System.Drawing.Size(97, 20);
            this.dtphora.TabIndex = 14;
            this.dtphora.Value = new System.DateTime(2017, 12, 7, 8, 0, 0, 0);
            this.dtphora.ValueChanged += new System.EventHandler(this.dtphora_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(173, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Hora:";
            // 
            // btnguardar
            // 
            this.btnguardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnguardar.Location = new System.Drawing.Point(182, 479);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 16;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnlimpiar.Location = new System.Drawing.Point(360, 479);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 17;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // btnborrar
            // 
            this.btnborrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnborrar.Location = new System.Drawing.Point(534, 479);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 18;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // txtpaciente
            // 
            this.txtpaciente.Location = new System.Drawing.Point(176, 61);
            this.txtpaciente.Name = "txtpaciente";
            this.txtpaciente.ReadOnly = true;
            this.txtpaciente.Size = new System.Drawing.Size(221, 20);
            this.txtpaciente.TabIndex = 19;
            // 
            // txtdoct
            // 
            this.txtdoct.Location = new System.Drawing.Point(592, 61);
            this.txtdoct.Name = "txtdoct";
            this.txtdoct.ReadOnly = true;
            this.txtdoct.Size = new System.Drawing.Size(231, 20);
            this.txtdoct.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtdoct);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.txtbuscardoc);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtpaciente);
            this.groupBox1.Controls.Add(this.txtbuscarp);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtidpa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtiddo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 248);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la cita";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(751, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(451, 113);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(375, 123);
            this.dataGridView2.TabIndex = 24;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // txtbuscardoc
            // 
            this.txtbuscardoc.Location = new System.Drawing.Point(451, 88);
            this.txtbuscardoc.Name = "txtbuscardoc";
            this.txtbuscardoc.Size = new System.Drawing.Size(294, 20);
            this.txtbuscardoc.TabIndex = 27;
            this.txtbuscardoc.TextChanged += new System.EventHandler(this.txtbuscardoc_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtbuscarp
            // 
            this.txtbuscarp.AccessibleDescription = "";
            this.txtbuscarp.Location = new System.Drawing.Point(15, 87);
            this.txtbuscarp.Name = "txtbuscarp";
            this.txtbuscarp.Size = new System.Drawing.Size(294, 20);
            this.txtbuscarp.TabIndex = 26;
            this.txtbuscarp.Tag = "name";
            this.txtbuscarp.TextChanged += new System.EventHandler(this.txtbuscarp_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(375, 123);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnconfirmar.Location = new System.Drawing.Point(39, 479);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(132, 23);
            this.btnconfirmar.TabIndex = 21;
            this.btnconfirmar.Text = "Confirmar  Cita";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dtpfecha);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dtphora);
            this.groupBox2.Location = new System.Drawing.Point(12, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 179);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha de la cita";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 52);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(591, 115);
            this.dataGridView3.TabIndex = 16;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnactualizar.Location = new System.Drawing.Point(279, 479);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 23);
            this.btnactualizar.TabIndex = 25;
            this.btnactualizar.Text = "Actualisar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncanc
            // 
            this.btncanc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btncanc.Location = new System.Drawing.Point(441, 479);
            this.btncanc.Name = "btncanc";
            this.btncanc.Size = new System.Drawing.Size(75, 23);
            this.btncanc.TabIndex = 30;
            this.btncanc.Text = "Cancelar";
            this.btncanc.UseVisualStyleBackColor = true;
            this.btncanc.Click += new System.EventHandler(this.btncanc_Click);
            // 
            // agrescitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(862, 514);
            this.Controls.Add(this.btncanc);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "agrescitas";
            this.Text = "Agregar Citas";
            this.Load += new System.EventHandler(this.agrescitas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtbuscarp;
        private System.Windows.Forms.TextBox txtbuscardoc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button btnguardar;
        public System.Windows.Forms.Button btnlimpiar;
        public System.Windows.Forms.Button btnborrar;
        public System.Windows.Forms.Button btnactualizar;
        public System.Windows.Forms.Button btnconfirmar;
        public System.Windows.Forms.Button btncanc;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.TextBox txtidpa;
        public System.Windows.Forms.DateTimePicker dtpfecha;
        public System.Windows.Forms.TextBox txtiddo;
        public System.Windows.Forms.DateTimePicker dtphora;
        public System.Windows.Forms.TextBox txtpaciente;
        public System.Windows.Forms.TextBox txtdoct;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}