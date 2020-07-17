namespace SysPandemic
{
    partial class addsupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addsupplier));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_pv_phonecontact = new System.Windows.Forms.MaskedTextBox();
            this.txt_pv_phone = new System.Windows.Forms.MaskedTextBox();
            this.cbx_pv_status = new System.Windows.Forms.CheckBox();
            this.txt_pv_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pv_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pv_name = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label26 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_pv_email = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pv_contact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pv_contactposition = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_pv_email);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_pv_phone);
            this.groupBox1.Controls.Add(this.cbx_pv_status);
            this.groupBox1.Controls.Add(this.txt_pv_id);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_pv_address);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_pv_name);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(656, 236);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // txt_pv_phonecontact
            // 
            this.txt_pv_phonecontact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pv_phonecontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pv_phonecontact.Location = new System.Drawing.Point(75, 63);
            this.txt_pv_phonecontact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pv_phonecontact.Mask = "(999) 000-0000";
            this.txt_pv_phonecontact.Name = "txt_pv_phonecontact";
            this.txt_pv_phonecontact.Size = new System.Drawing.Size(134, 26);
            this.txt_pv_phonecontact.TabIndex = 28;
            this.txt_pv_phonecontact.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txt_pv_phonecontact.Click += new System.EventHandler(this.txt_pv_phonecontact_Click);
            // 
            // txt_pv_phone
            // 
            this.txt_pv_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pv_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pv_phone.Location = new System.Drawing.Point(91, 172);
            this.txt_pv_phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pv_phone.Mask = "(999) 000-0000";
            this.txt_pv_phone.Name = "txt_pv_phone";
            this.txt_pv_phone.Size = new System.Drawing.Size(134, 26);
            this.txt_pv_phone.TabIndex = 27;
            this.txt_pv_phone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txt_pv_phone.Click += new System.EventHandler(this.txt_pv_phone_Click);
            // 
            // cbx_pv_status
            // 
            this.cbx_pv_status.AutoSize = true;
            this.cbx_pv_status.Location = new System.Drawing.Point(536, 206);
            this.cbx_pv_status.Name = "cbx_pv_status";
            this.cbx_pv_status.Size = new System.Drawing.Size(106, 24);
            this.cbx_pv_status.TabIndex = 26;
            this.cbx_pv_status.Text = "checkBox1";
            this.cbx_pv_status.UseVisualStyleBackColor = true;
            this.cbx_pv_status.CheckedChanged += new System.EventHandler(this.cbx_pv_status_CheckedChanged);
            // 
            // txt_pv_id
            // 
            this.txt_pv_id.Enabled = false;
            this.txt_pv_id.Location = new System.Drawing.Point(46, 32);
            this.txt_pv_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pv_id.Name = "txt_pv_id";
            this.txt_pv_id.Size = new System.Drawing.Size(98, 26);
            this.txt_pv_id.TabIndex = 17;
            this.txt_pv_id.TextChanged += new System.EventHandler(this.txt_pv_id_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Teléfono:";
            // 
            // txt_pv_address
            // 
            this.txt_pv_address.Location = new System.Drawing.Point(85, 104);
            this.txt_pv_address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pv_address.Multiline = true;
            this.txt_pv_address.Name = "txt_pv_address";
            this.txt_pv_address.Size = new System.Drawing.Size(557, 58);
            this.txt_pv_address.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // txt_pv_name
            // 
            this.txt_pv_name.Location = new System.Drawing.Point(85, 68);
            this.txt_pv_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pv_name.Name = "txt_pv_name";
            this.txt_pv_name.Size = new System.Drawing.Size(557, 26);
            this.txt_pv_name.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_save.Image = global::SysPandemic.Properties.Resources._1493294___save;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(145, 385);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(103, 29);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Guardar";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancel.Image = global::SysPandemic.Properties.Resources._1493282___cancel;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(368, 385);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(103, 29);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_update.Image = global::SysPandemic.Properties.Resources._1493283___undo1;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(145, 385);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(103, 29);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Actualizar";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_clear.Image = global::SysPandemic.Properties.Resources._1493292___new;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.Location = new System.Drawing.Point(257, 385);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(103, 29);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Limpiar";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_print.Image = global::SysPandemic.Properties.Resources._1493286___print;
            this.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.Location = new System.Drawing.Point(565, 385);
            this.btn_print.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(103, 29);
            this.btn_print.TabIndex = 13;
            this.btn_print.Text = "Imprimir";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_print.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Información del Suplidor";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 21);
            this.panel1.TabIndex = 14;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(690, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 21);
            this.panel3.TabIndex = 12;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SysPandemic.Properties.Resources._3592825___avatar_general_human_office_person_smile_user;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label26.Location = new System.Drawing.Point(36, 0);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(157, 20);
            this.label26.TabIndex = 2;
            this.label26.Text = "Datos del Suplidor";
            this.label26.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(620, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(655, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.btn_print);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Location = new System.Drawing.Point(1, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 422);
            this.panel2.TabIndex = 15;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 35);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(233, 175);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Correo:";
            // 
            // txt_pv_email
            // 
            this.txt_pv_email.Location = new System.Drawing.Point(302, 172);
            this.txt_pv_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pv_email.Name = "txt_pv_email";
            this.txt_pv_email.Size = new System.Drawing.Size(340, 26);
            this.txt_pv_email.TabIndex = 31;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_pv_contactposition);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_pv_phonecontact);
            this.groupBox2.Controls.Add(this.txt_pv_contact);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 98);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contacto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nombre del Contacto:";
            // 
            // txt_pv_contact
            // 
            this.txt_pv_contact.Location = new System.Drawing.Point(179, 27);
            this.txt_pv_contact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pv_contact.Name = "txt_pv_contact";
            this.txt_pv_contact.Size = new System.Drawing.Size(463, 26);
            this.txt_pv_contact.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Posición:";
            // 
            // txt_pv_contactposition
            // 
            this.txt_pv_contactposition.Location = new System.Drawing.Point(297, 63);
            this.txt_pv_contactposition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_pv_contactposition.Name = "txt_pv_contactposition";
            this.txt_pv_contactposition.Size = new System.Drawing.Size(229, 26);
            this.txt_pv_contactposition.TabIndex = 34;
            // 
            // addsupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(682, 443);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(140)))), ((int)(((byte)(245)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "addsupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion Doctor";
            this.Load += new System.EventHandler(this.addsupplier_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txt_pv_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_pv_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_pv_name;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.Button btn_clear;
        public System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbx_pv_status;
        private System.Windows.Forms.MaskedTextBox txt_pv_phone;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.MaskedTextBox txt_pv_phonecontact;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txt_pv_email;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_pv_contactposition;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_pv_contact;
    }
}