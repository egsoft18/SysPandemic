namespace SysPandemic
{
    partial class searchappointment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchappointment));
            this.dgv_appointment = new System.Windows.Forms.DataGridView();
            this.txt_p_name = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_adddoctor = new System.Windows.Forms.Button();
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
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_dm_date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_s_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_dm_id = new System.Windows.Forms.TextBox();
            this.dm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dm_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dm_turn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dm_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dm_lu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbx_date = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appointment)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_appointment
            // 
            this.dgv_appointment.AllowUserToAddRows = false;
            this.dgv_appointment.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_appointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_appointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_appointment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_appointment.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_appointment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_appointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_appointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dm_id,
            this.dm_status,
            this.dm_turn,
            this.p_name,
            this.s_name,
            this.dm_date,
            this.u_id,
            this.dm_lu});
            this.dgv_appointment.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_appointment.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_appointment.EnableHeadersVisualStyles = false;
            this.dgv_appointment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.dgv_appointment.Location = new System.Drawing.Point(11, 108);
            this.dgv_appointment.Name = "dgv_appointment";
            this.dgv_appointment.ReadOnly = true;
            this.dgv_appointment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_appointment.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_appointment.RowHeadersVisible = false;
            this.dgv_appointment.RowTemplate.ReadOnly = true;
            this.dgv_appointment.Size = new System.Drawing.Size(1181, 443);
            this.dgv_appointment.TabIndex = 0;
            this.dgv_appointment.DoubleClick += new System.EventHandler(this.dgv_appointment_DoubleClick);
            // 
            // txt_p_name
            // 
            this.txt_p_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_p_name.Location = new System.Drawing.Point(200, 28);
            this.txt_p_name.Name = "txt_p_name";
            this.txt_p_name.Size = new System.Drawing.Size(277, 26);
            this.txt_p_name.TabIndex = 4;
            this.txt_p_name.TextChanged += new System.EventHandler(this.txt_p_name_TextChanged);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_refresh.Image = global::SysPandemic.Properties.Resources._1493284___redo;
            this.btn_refresh.Location = new System.Drawing.Point(1045, 29);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(36, 26);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // btn_adddoctor
            // 
            this.btn_adddoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.btn_adddoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_adddoctor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_adddoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adddoctor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_adddoctor.Image = global::SysPandemic.Properties.Resources._3592829___calendar_general_month_month_calendar_office_schedule_wall_calendar;
            this.btn_adddoctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_adddoctor.Location = new System.Drawing.Point(1087, 29);
            this.btn_adddoctor.Name = "btn_adddoctor";
            this.btn_adddoctor.Size = new System.Drawing.Size(88, 26);
            this.btn_adddoctor.TabIndex = 6;
            this.btn_adddoctor.Text = "Agregar";
            this.btn_adddoctor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_adddoctor.UseVisualStyleBackColor = false;
            this.btn_adddoctor.Click += new System.EventHandler(this.btn_adddoctor_Click);
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
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Administrar Visitas";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SysPandemic.Properties.Resources._3592851___calendar_general_month_month_calendar_office_schedule_wall_calendar;
            this.pictureBox3.Location = new System.Drawing.Point(12, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
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
            this.label1.Location = new System.Drawing.Point(476, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Administrar Visitas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lb_results);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.dgv_appointment);
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
            this.groupBox1.Controls.Add(this.cbx_date);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtp_dm_date);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_s_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_dm_id);
            this.groupBox1.Controls.Add(this.txt_p_name);
            this.groupBox1.Controls.Add(this.btn_adddoctor);
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1181, 68);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(831, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fecha:";
            // 
            // dtp_dm_date
            // 
            this.dtp_dm_date.CustomFormat = "dd/MM/yyyy";
            this.dtp_dm_date.Enabled = false;
            this.dtp_dm_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dm_date.Location = new System.Drawing.Point(917, 28);
            this.dtp_dm_date.Name = "dtp_dm_date";
            this.dtp_dm_date.Size = new System.Drawing.Size(122, 26);
            this.dtp_dm_date.TabIndex = 19;
            this.dtp_dm_date.ValueChanged += new System.EventHandler(this.dtp_dm_date_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(483, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Doctor:";
            // 
            // txt_s_name
            // 
            this.txt_s_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_s_name.Location = new System.Drawing.Point(550, 28);
            this.txt_s_name.Name = "txt_s_name";
            this.txt_s_name.Size = new System.Drawing.Size(275, 26);
            this.txt_s_name.TabIndex = 17;
            this.txt_s_name.TextChanged += new System.EventHandler(this.txt_s_name_TextChanged);
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
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Paciente:";
            // 
            // txt_dm_id
            // 
            this.txt_dm_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dm_id.Location = new System.Drawing.Point(42, 28);
            this.txt_dm_id.Name = "txt_dm_id";
            this.txt_dm_id.Size = new System.Drawing.Size(71, 26);
            this.txt_dm_id.TabIndex = 11;
            this.txt_dm_id.TextChanged += new System.EventHandler(this.txt_dm_id_TextChanged);
            // 
            // dm_id
            // 
            this.dm_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dm_id.HeaderText = "ID";
            this.dm_id.Name = "dm_id";
            this.dm_id.ReadOnly = true;
            this.dm_id.Width = 47;
            // 
            // dm_status
            // 
            this.dm_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dm_status.HeaderText = "Estado";
            this.dm_status.Name = "dm_status";
            this.dm_status.ReadOnly = true;
            this.dm_status.Width = 81;
            // 
            // dm_turn
            // 
            this.dm_turn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dm_turn.HeaderText = "Turno";
            this.dm_turn.Name = "dm_turn";
            this.dm_turn.ReadOnly = true;
            this.dm_turn.Width = 72;
            // 
            // p_name
            // 
            this.p_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.p_name.HeaderText = "Paciente";
            this.p_name.Name = "p_name";
            this.p_name.ReadOnly = true;
            // 
            // s_name
            // 
            this.s_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.s_name.HeaderText = "Doctor";
            this.s_name.Name = "s_name";
            this.s_name.ReadOnly = true;
            // 
            // dm_date
            // 
            this.dm_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dm_date.HeaderText = "Fecha";
            this.dm_date.Name = "dm_date";
            this.dm_date.ReadOnly = true;
            this.dm_date.Width = 75;
            // 
            // u_id
            // 
            this.u_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.u_id.HeaderText = "Modificado por";
            this.u_id.Name = "u_id";
            this.u_id.ReadOnly = true;
            this.u_id.Width = 136;
            // 
            // dm_lu
            // 
            this.dm_lu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.dm_lu.HeaderText = "Fecha Modificado";
            this.dm_lu.Name = "dm_lu";
            this.dm_lu.ReadOnly = true;
            this.dm_lu.Visible = false;
            this.dm_lu.Width = 5;
            // 
            // cbx_date
            // 
            this.cbx_date.AutoSize = true;
            this.cbx_date.Location = new System.Drawing.Point(895, 35);
            this.cbx_date.Name = "cbx_date";
            this.cbx_date.Size = new System.Drawing.Size(15, 14);
            this.cbx_date.TabIndex = 21;
            this.cbx_date.UseVisualStyleBackColor = true;
            this.cbx_date.CheckedChanged += new System.EventHandler(this.cbx_date_CheckedChanged);
            // 
            // searchappointment
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
            this.Name = "searchappointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Pacientes";
            this.Load += new System.EventHandler(this.searchappointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appointment)).EndInit();
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
        private System.Windows.Forms.TextBox txt_p_name;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_adddoctor;
        private System.Windows.Forms.Button printpatientlist_btn;
        public System.Windows.Forms.DataGridView dgv_appointment;
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
        private System.Windows.Forms.TextBox txt_dm_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_results;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_dm_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_s_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dm_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dm_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dm_turn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dm_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn u_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dm_lu;
        private System.Windows.Forms.CheckBox cbx_date;
    }
}