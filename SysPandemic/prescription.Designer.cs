namespace SysPandemic
{
    partial class prescription
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
            this.label1 = new System.Windows.Forms.Label();
            this.patientpre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bdaypre = new System.Windows.Forms.TextBox();
            this.searchpatient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicine = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.use = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.addmedicine = new System.Windows.Forms.Button();
            this.printpre = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.today = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Prescripción";
            // 
            // patientpre
            // 
            this.patientpre.Location = new System.Drawing.Point(72, 45);
            this.patientpre.Name = "patientpre";
            this.patientpre.ReadOnly = true;
            this.patientpre.Size = new System.Drawing.Size(313, 20);
            this.patientpre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Paciente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha naciemiento:";
            // 
            // bdaypre
            // 
            this.bdaypre.Location = new System.Drawing.Point(497, 45);
            this.bdaypre.Name = "bdaypre";
            this.bdaypre.ReadOnly = true;
            this.bdaypre.Size = new System.Drawing.Size(120, 20);
            this.bdaypre.TabIndex = 4;
            // 
            // searchpatient
            // 
            this.searchpatient.Location = new System.Drawing.Point(633, 43);
            this.searchpatient.Name = "searchpatient";
            this.searchpatient.Size = new System.Drawing.Size(75, 23);
            this.searchpatient.TabIndex = 5;
            this.searchpatient.Text = "Buscar";
            this.searchpatient.UseVisualStyleBackColor = true;
            this.searchpatient.Click += new System.EventHandler(this.searchpatient_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 228);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataGridView1_CellValueNeeded);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "No.";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Medicamento";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Uso";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Período";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // medicine
            // 
            this.medicine.Location = new System.Drawing.Point(94, 83);
            this.medicine.Name = "medicine";
            this.medicine.Size = new System.Drawing.Size(523, 20);
            this.medicine.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Medicamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Uso:";
            // 
            // use
            // 
            this.use.Location = new System.Drawing.Point(49, 108);
            this.use.Name = "use";
            this.use.Size = new System.Drawing.Size(195, 20);
            this.use.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Período:";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(332, 108);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(159, 20);
            this.time.TabIndex = 11;
            // 
            // addmedicine
            // 
            this.addmedicine.Location = new System.Drawing.Point(633, 83);
            this.addmedicine.Name = "addmedicine";
            this.addmedicine.Size = new System.Drawing.Size(75, 41);
            this.addmedicine.TabIndex = 13;
            this.addmedicine.Text = "Agregar";
            this.addmedicine.UseVisualStyleBackColor = true;
            this.addmedicine.Click += new System.EventHandler(this.addmedicine_Click);
            // 
            // printpre
            // 
            this.printpre.Location = new System.Drawing.Point(281, 368);
            this.printpre.Name = "printpre";
            this.printpre.Size = new System.Drawing.Size(154, 29);
            this.printpre.TabIndex = 14;
            this.printpre.Text = "Imprimir";
            this.printpre.UseVisualStyleBackColor = true;
            this.printpre.Click += new System.EventHandler(this.printpre_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView2.Location = new System.Drawing.Point(12, 449);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(349, 75);
            this.dataGridView2.TabIndex = 15;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Patient";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "bday";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "today";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // today
            // 
            this.today.CustomFormat = "dd-MM-yyyy";
            this.today.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.today.Location = new System.Drawing.Point(367, 449);
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(95, 20);
            this.today.TabIndex = 16;
            // 
            // prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(729, 536);
            this.Controls.Add(this.today);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.printpre);
            this.Controls.Add(this.addmedicine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.use);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.medicine);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchpatient);
            this.Controls.Add(this.bdaypre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patientpre);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "prescription";
            this.Text = "Crear Prescripcion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchpatient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox medicine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox use;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Button addmedicine;
        public System.Windows.Forms.TextBox patientpre;
        public System.Windows.Forms.TextBox bdaypre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button printpre;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DateTimePicker today;
    }
}