namespace SysPandemic
{
    partial class emerpatv
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
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.rdbid = new System.Windows.Forms.RadioButton();
            this.rdbnom = new System.Windows.Forms.RadioButton();
            this.rdbfe = new System.Windows.Forms.RadioButton();
            this.dtpfec = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 212);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(637, 5);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 1;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(280, 7);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(351, 20);
            this.txtbuscar.TabIndex = 2;
            // 
            // rdbid
            // 
            this.rdbid.AutoSize = true;
            this.rdbid.Location = new System.Drawing.Point(12, 8);
            this.rdbid.Name = "rdbid";
            this.rdbid.Size = new System.Drawing.Size(36, 17);
            this.rdbid.TabIndex = 3;
            this.rdbid.TabStop = true;
            this.rdbid.Text = "ID";
            this.rdbid.UseVisualStyleBackColor = true;
            // 
            // rdbnom
            // 
            this.rdbnom.AutoSize = true;
            this.rdbnom.Location = new System.Drawing.Point(55, 8);
            this.rdbnom.Name = "rdbnom";
            this.rdbnom.Size = new System.Drawing.Size(62, 17);
            this.rdbnom.TabIndex = 4;
            this.rdbnom.TabStop = true;
            this.rdbnom.Text = "Nombre";
            this.rdbnom.UseVisualStyleBackColor = true;
            // 
            // rdbfe
            // 
            this.rdbfe.AutoSize = true;
            this.rdbfe.Location = new System.Drawing.Point(124, 8);
            this.rdbfe.Name = "rdbfe";
            this.rdbfe.Size = new System.Drawing.Size(55, 17);
            this.rdbfe.TabIndex = 5;
            this.rdbfe.TabStop = true;
            this.rdbfe.Text = "Fecha";
            this.rdbfe.UseVisualStyleBackColor = true;
            // 
            // dtpfec
            // 
            this.dtpfec.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfec.Location = new System.Drawing.Point(185, 7);
            this.dtpfec.Name = "dtpfec";
            this.dtpfec.Size = new System.Drawing.Size(89, 20);
            this.dtpfec.TabIndex = 6;
            // 
            // emerpatv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(824, 261);
            this.Controls.Add(this.dtpfec);
            this.Controls.Add(this.rdbfe);
            this.Controls.Add(this.rdbnom);
            this.Controls.Add(this.rdbid);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "emerpatv";
            this.Text = "Ver pacientes ambulantes";
            this.Load += new System.EventHandler(this.emerpatv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.RadioButton rdbid;
        private System.Windows.Forms.RadioButton rdbnom;
        private System.Windows.Forms.RadioButton rdbfe;
        private System.Windows.Forms.DateTimePicker dtpfec;
    }
}