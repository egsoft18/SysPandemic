namespace SysPandemic
{
    partial class Appointment
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdbid = new System.Windows.Forms.RadioButton();
            this.rdbpac = new System.Windows.Forms.RadioButton();
            this.rdbdoct = new System.Windows.Forms.RadioButton();
            this.rdbiddoc = new System.Windows.Forms.RadioButton();
            this.rdbidp = new System.Windows.Forms.RadioButton();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnbus = new System.Windows.Forms.Button();
            this.btnrefrescar = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.rdbfecha = new System.Windows.Forms.RadioButton();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(928, 190);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // rdbid
            // 
            this.rdbid.AutoSize = true;
            this.rdbid.Location = new System.Drawing.Point(12, 12);
            this.rdbid.Name = "rdbid";
            this.rdbid.Size = new System.Drawing.Size(36, 17);
            this.rdbid.TabIndex = 1;
            this.rdbid.TabStop = true;
            this.rdbid.Text = "ID";
            this.rdbid.UseVisualStyleBackColor = true;
            // 
            // rdbpac
            // 
            this.rdbpac.AutoSize = true;
            this.rdbpac.Location = new System.Drawing.Point(54, 12);
            this.rdbpac.Name = "rdbpac";
            this.rdbpac.Size = new System.Drawing.Size(67, 17);
            this.rdbpac.TabIndex = 2;
            this.rdbpac.TabStop = true;
            this.rdbpac.Text = "Paciente";
            this.rdbpac.UseVisualStyleBackColor = true;
            // 
            // rdbdoct
            // 
            this.rdbdoct.AutoSize = true;
            this.rdbdoct.Location = new System.Drawing.Point(214, 12);
            this.rdbdoct.Name = "rdbdoct";
            this.rdbdoct.Size = new System.Drawing.Size(57, 17);
            this.rdbdoct.TabIndex = 3;
            this.rdbdoct.TabStop = true;
            this.rdbdoct.Text = "Doctor";
            this.rdbdoct.UseVisualStyleBackColor = true;
            // 
            // rdbiddoc
            // 
            this.rdbiddoc.AutoSize = true;
            this.rdbiddoc.Location = new System.Drawing.Point(277, 12);
            this.rdbiddoc.Name = "rdbiddoc";
            this.rdbiddoc.Size = new System.Drawing.Size(71, 17);
            this.rdbiddoc.TabIndex = 4;
            this.rdbiddoc.TabStop = true;
            this.rdbiddoc.Text = "ID Doctor";
            this.rdbiddoc.UseVisualStyleBackColor = true;
            // 
            // rdbidp
            // 
            this.rdbidp.AutoSize = true;
            this.rdbidp.Location = new System.Drawing.Point(127, 12);
            this.rdbidp.Name = "rdbidp";
            this.rdbidp.Size = new System.Drawing.Size(81, 17);
            this.rdbidp.TabIndex = 5;
            this.rdbidp.TabStop = true;
            this.rdbidp.Text = "ID Paciente";
            this.rdbidp.UseVisualStyleBackColor = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbuscar.Location = new System.Drawing.Point(517, 13);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(271, 20);
            this.txtbuscar.TabIndex = 6;
            // 
            // btnbus
            // 
            this.btnbus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbus.Location = new System.Drawing.Point(794, 13);
            this.btnbus.Name = "btnbus";
            this.btnbus.Size = new System.Drawing.Size(75, 23);
            this.btnbus.TabIndex = 7;
            this.btnbus.Text = "Buscar";
            this.btnbus.UseVisualStyleBackColor = true;
            this.btnbus.Click += new System.EventHandler(this.btnbus_Click);
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrefrescar.Location = new System.Drawing.Point(875, 13);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnrefrescar.TabIndex = 8;
            this.btnrefrescar.Text = "Refrescar";
            this.btnrefrescar.UseVisualStyleBackColor = true;
            this.btnrefrescar.Click += new System.EventHandler(this.btnrefrescar_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnimprimir.Location = new System.Drawing.Point(12, 238);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(75, 23);
            this.btnimprimir.TabIndex = 9;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // rdbfecha
            // 
            this.rdbfecha.AutoSize = true;
            this.rdbfecha.Location = new System.Drawing.Point(354, 12);
            this.rdbfecha.Name = "rdbfecha";
            this.rdbfecha.Size = new System.Drawing.Size(55, 17);
            this.rdbfecha.TabIndex = 11;
            this.rdbfecha.TabStop = true;
            this.rdbfecha.Text = "Fecha";
            this.rdbfecha.UseVisualStyleBackColor = true;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(419, 13);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(92, 20);
            this.dtpfecha.TabIndex = 12;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(952, 269);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.rdbfecha);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btnrefrescar);
            this.Controls.Add(this.btnbus);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.rdbidp);
            this.Controls.Add(this.rdbiddoc);
            this.Controls.Add(this.rdbdoct);
            this.Controls.Add(this.rdbpac);
            this.Controls.Add(this.rdbid);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Appointment";
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdbid;
        private System.Windows.Forms.RadioButton rdbpac;
        private System.Windows.Forms.RadioButton rdbdoct;
        private System.Windows.Forms.RadioButton rdbiddoc;
        private System.Windows.Forms.RadioButton rdbidp;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnbus;
        private System.Windows.Forms.Button btnrefrescar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.RadioButton rdbfecha;
        private System.Windows.Forms.DateTimePicker dtpfecha;
    }
}