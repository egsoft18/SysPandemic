namespace SysPandemic
{
    partial class searchinsurances
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchinsurances));
            this.dgv_insurance = new System.Windows.Forms.DataGridView();
            this.i_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_contract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_pss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i_lu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_i_name = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.btn_addinsurance = new System.Windows.Forms.Button();
            this.printpatientlist_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_results = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_i_contract = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_i_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_insurance)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_insurance
            // 
            this.dgv_insurance.AllowUserToAddRows = false;
            this.dgv_insurance.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_insurance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_insurance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_insurance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_insurance.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_insurance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_insurance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_insurance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i_id,
            this.i_name,
            this.i_contract,
            this.i_pss,
            this.i_telephone,
            this.i_email,
            this.i_status,
            this.u_id,
            this.i_lu});
            this.dgv_insurance.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_insurance.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_insurance.EnableHeadersVisualStyles = false;
            this.dgv_insurance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.dgv_insurance.Location = new System.Drawing.Point(11, 108);
            this.dgv_insurance.Name = "dgv_insurance";
            this.dgv_insurance.ReadOnly = true;
            this.dgv_insurance.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_insurance.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_insurance.RowHeadersVisible = false;
            this.dgv_insurance.RowTemplate.ReadOnly = true;
            this.dgv_insurance.Size = new System.Drawing.Size(1181, 443);
            this.dgv_insurance.TabIndex = 0;
            this.dgv_insurance.DoubleClick += new System.EventHandler(this.dgv_patients_DoubleClick);
            // 
            // i_id
            // 
            this.i_id.HeaderText = "ID";
            this.i_id.Name = "i_id";
            this.i_id.ReadOnly = true;
            // 
            // i_name
            // 
            this.i_name.HeaderText = "ARS";
            this.i_name.Name = "i_name";
            this.i_name.ReadOnly = true;
            // 
            // i_contract
            // 
            this.i_contract.HeaderText = "Contrato";
            this.i_contract.Name = "i_contract";
            this.i_contract.ReadOnly = true;
            // 
            // i_pss
            // 
            this.i_pss.HeaderText = "PSS";
            this.i_pss.Name = "i_pss";
            this.i_pss.ReadOnly = true;
            // 
            // i_telephone
            // 
            this.i_telephone.HeaderText = "Teléfono";
            this.i_telephone.Name = "i_telephone";
            this.i_telephone.ReadOnly = true;
            // 
            // i_email
            // 
            this.i_email.HeaderText = "E-mail";
            this.i_email.Name = "i_email";
            this.i_email.ReadOnly = true;
            // 
            // i_status
            // 
            this.i_status.HeaderText = "Estatus";
            this.i_status.Name = "i_status";
            this.i_status.ReadOnly = true;
            // 
            // u_id
            // 
            this.u_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.u_id.HeaderText = "Modificado Por:";
            this.u_id.Name = "u_id";
            this.u_id.ReadOnly = true;
            this.u_id.Width = 141;
            // 
            // i_lu
            // 
            this.i_lu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.i_lu.HeaderText = "Fec. Modificado:";
            this.i_lu.Name = "i_lu";
            this.i_lu.ReadOnly = true;
            this.i_lu.Width = 147;
            // 
            // txt_i_name
            // 
            this.txt_i_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_i_name.Location = new System.Drawing.Point(172, 28);
            this.txt_i_name.Name = "txt_i_name";
            this.txt_i_name.Size = new System.Drawing.Size(651, 26);
            this.txt_i_name.TabIndex = 4;
            this.txt_i_name.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.search_btn.Image = global::SysPandemic.Properties.Resources._1493284___redo;
            this.search_btn.Location = new System.Drawing.Point(1045, 29);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(36, 26);
            this.search_btn.TabIndex = 5;
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // btn_addinsurance
            // 
            this.btn_addinsurance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.btn_addinsurance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addinsurance.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addinsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addinsurance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_addinsurance.Image = global::SysPandemic.Properties.Resources._3592854___add_user_business_man_employee_general_human_member_office;
            this.btn_addinsurance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addinsurance.Location = new System.Drawing.Point(1087, 29);
            this.btn_addinsurance.Name = "btn_addinsurance";
            this.btn_addinsurance.Size = new System.Drawing.Size(88, 26);
            this.btn_addinsurance.TabIndex = 6;
            this.btn_addinsurance.Text = "Agregar";
            this.btn_addinsurance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addinsurance.UseVisualStyleBackColor = false;
            this.btn_addinsurance.Click += new System.EventHandler(this.addpatient_btn_Click);
            // 
            // printpatientlist_btn
            // 
            this.printpatientlist_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.printpatientlist_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printpatientlist_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printpatientlist_btn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.printpatientlist_btn.Image = global::SysPandemic.Properties.Resources._1493286___print;
            this.printpatientlist_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printpatientlist_btn.Location = new System.Drawing.Point(1092, 557);
            this.printpatientlist_btn.Name = "printpatientlist_btn";
            this.printpatientlist_btn.Size = new System.Drawing.Size(100, 24);
            this.printpatientlist_btn.TabIndex = 8;
            this.printpatientlist_btn.Text = "Imprimir";
            this.printpatientlist_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.printpatientlist_btn.UseVisualStyleBackColor = false;
            this.printpatientlist_btn.Click += new System.EventHandler(this.printpatientlist_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Location = new System.Drawing.Point(-12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 21);
            this.panel1.TabIndex = 9;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(39, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Administrar ARS (Seguro Médico)";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SysPandemic.Properties.Resources._3592853___align_employee_general_human_human_list_list_member;
            this.pictureBox3.Location = new System.Drawing.Point(12, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1158, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1186, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Administrar ARS (Seguro Médico)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lb_results);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.dgv_insurance);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.printpatientlist_btn);
            this.panel2.Location = new System.Drawing.Point(1, 20);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8, 0, 2, 2);
            this.panel2.Size = new System.Drawing.Size(1203, 586);
            this.panel2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(241, 557);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 555);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total de Registros:";
            // 
            // lb_results
            // 
            this.lb_results.AutoSize = true;
            this.lb_results.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_results.Location = new System.Drawing.Point(146, 555);
            this.lb_results.Name = "lb_results";
            this.lb_results.Size = new System.Drawing.Size(29, 20);
            this.lb_results.TabIndex = 18;
            this.lb_results.Text = "##";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_i_contract);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_i_id);
            this.groupBox1.Controls.Add(this.txt_i_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_addinsurance);
            this.groupBox1.Controls.Add(this.search_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1181, 68);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador:";
            // 
            // txt_i_contract
            // 
            this.txt_i_contract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_i_contract.Location = new System.Drawing.Point(910, 28);
            this.txt_i_contract.Name = "txt_i_contract";
            this.txt_i_contract.Size = new System.Drawing.Size(129, 26);
            this.txt_i_contract.TabIndex = 16;
            this.txt_i_contract.TextChanged += new System.EventHandler(this.txt_i_contract_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "ARS:";
            // 
            // txt_i_id
            // 
            this.txt_i_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_i_id.Location = new System.Drawing.Point(42, 28);
            this.txt_i_id.Name = "txt_i_id";
            this.txt_i_id.Size = new System.Drawing.Size(71, 26);
            this.txt_i_id.TabIndex = 11;
            this.txt_i_id.TextChanged += new System.EventHandler(this.txt_p_id_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(829, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Contrato:";
            // 
            // searchinsurances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1205, 607);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "searchinsurances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Pacientes";
            this.Load += new System.EventHandler(this.seepatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_insurance)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_i_name;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button btn_addinsurance;
        private System.Windows.Forms.Button printpatientlist_btn;
        public System.Windows.Forms.DataGridView dgv_insurance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_i_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_results;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_contract;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_pss;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn i_lu;
        private System.Windows.Forms.TextBox txt_i_contract;
    }
}