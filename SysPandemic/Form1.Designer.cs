namespace SysPandemic
{
    partial class Homeform
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteAmbulanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteDeEmergenciaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verPacientesDeEmergenciaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.procedimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProcedimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.subProcedimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.pacienteAmbulanteToolStripMenuItem,
            this.procedimientosToolStripMenuItem,
            this.agendaToolStripMenuItem,
            this.facturacionToolStripMenuItem,
            this.doctoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.administrarToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.administrarToolStripMenuItem.Text = "Administrar";
            this.administrarToolStripMenuItem.Click += new System.EventHandler(this.administrarToolStripMenuItem_Click);
            // 
            // pacienteAmbulanteToolStripMenuItem
            // 
            this.pacienteAmbulanteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienteDeEmergenciaToolStripMenuItem1,
            this.verPacientesDeEmergenciaToolStripMenuItem1});
            this.pacienteAmbulanteToolStripMenuItem.Name = "pacienteAmbulanteToolStripMenuItem";
            this.pacienteAmbulanteToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.pacienteAmbulanteToolStripMenuItem.Text = "Paciente ambulante";
            // 
            // pacienteDeEmergenciaToolStripMenuItem1
            // 
            this.pacienteDeEmergenciaToolStripMenuItem1.Name = "pacienteDeEmergenciaToolStripMenuItem1";
            this.pacienteDeEmergenciaToolStripMenuItem1.Size = new System.Drawing.Size(243, 22);
            this.pacienteDeEmergenciaToolStripMenuItem1.Text = " Agregar paciente de ambulante";
            this.pacienteDeEmergenciaToolStripMenuItem1.Click += new System.EventHandler(this.pacienteDeEmergenciaToolStripMenuItem1_Click);
            // 
            // verPacientesDeEmergenciaToolStripMenuItem1
            // 
            this.verPacientesDeEmergenciaToolStripMenuItem1.Name = "verPacientesDeEmergenciaToolStripMenuItem1";
            this.verPacientesDeEmergenciaToolStripMenuItem1.Size = new System.Drawing.Size(243, 22);
            this.verPacientesDeEmergenciaToolStripMenuItem1.Text = "Ver pacientes ambulantes";
            this.verPacientesDeEmergenciaToolStripMenuItem1.Click += new System.EventHandler(this.verPacientesDeEmergenciaToolStripMenuItem1_Click);
            // 
            // procedimientosToolStripMenuItem
            // 
            this.procedimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProcedimientoToolStripMenuItem,
            this.administrarToolStripMenuItem1,
            this.subProcedimientosToolStripMenuItem});
            this.procedimientosToolStripMenuItem.Name = "procedimientosToolStripMenuItem";
            this.procedimientosToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.procedimientosToolStripMenuItem.Text = "Procedimientos";
            // 
            // agregarProcedimientoToolStripMenuItem
            // 
            this.agregarProcedimientoToolStripMenuItem.Name = "agregarProcedimientoToolStripMenuItem";
            this.agregarProcedimientoToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.agregarProcedimientoToolStripMenuItem.Text = "Agregar procedimiento";
            this.agregarProcedimientoToolStripMenuItem.Click += new System.EventHandler(this.agregarProcedimientoToolStripMenuItem_Click_1);
            // 
            // administrarToolStripMenuItem1
            // 
            this.administrarToolStripMenuItem1.Name = "administrarToolStripMenuItem1";
            this.administrarToolStripMenuItem1.Size = new System.Drawing.Size(246, 22);
            this.administrarToolStripMenuItem1.Text = "Administrar";
            this.administrarToolStripMenuItem1.Click += new System.EventHandler(this.administrarToolStripMenuItem1_Click);
            // 
            // subProcedimientosToolStripMenuItem
            // 
            this.subProcedimientosToolStripMenuItem.Name = "subProcedimientosToolStripMenuItem";
            this.subProcedimientosToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.subProcedimientosToolStripMenuItem.Text = "Agregar avance a procedimiento";
            this.subProcedimientosToolStripMenuItem.Click += new System.EventHandler(this.subProcedimientosToolStripMenuItem_Click);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCitaToolStripMenuItem,
            this.verCitasToolStripMenuItem});
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.agendaToolStripMenuItem.Text = "Agenda";
            // 
            // agregarCitaToolStripMenuItem
            // 
            this.agregarCitaToolStripMenuItem.Name = "agregarCitaToolStripMenuItem";
            this.agregarCitaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.agregarCitaToolStripMenuItem.Text = "Agregar Cita";
            this.agregarCitaToolStripMenuItem.Click += new System.EventHandler(this.agregarCitaToolStripMenuItem_Click);
            // 
            // verCitasToolStripMenuItem
            // 
            this.verCitasToolStripMenuItem.Name = "verCitasToolStripMenuItem";
            this.verCitasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verCitasToolStripMenuItem.Text = "Ver Citas";
            this.verCitasToolStripMenuItem.Click += new System.EventHandler(this.verCitasToolStripMenuItem_Click);
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturarToolStripMenuItem,
            this.cToolStripMenuItem});
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.facturacionToolStripMenuItem.Text = "Facturación";
            this.facturacionToolStripMenuItem.Click += new System.EventHandler(this.facturacionToolStripMenuItem_Click);
            // 
            // facturarToolStripMenuItem
            // 
            this.facturarToolStripMenuItem.Name = "facturarToolStripMenuItem";
            this.facturarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.facturarToolStripMenuItem.Text = "Facturar";
            this.facturarToolStripMenuItem.Click += new System.EventHandler(this.facturarToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cToolStripMenuItem.Text = "CxC/CP";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // doctoresToolStripMenuItem
            // 
            this.doctoresToolStripMenuItem.Name = "doctoresToolStripMenuItem";
            this.doctoresToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.doctoresToolStripMenuItem.Text = "Doctores";
            this.doctoresToolStripMenuItem.Click += new System.EventHandler(this.doctoresToolStripMenuItem_Click);
            // 
            // Homeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Homeform";
            this.Text = "SysPandemic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Homeform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procedimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarProcedimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subProcedimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteAmbulanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteDeEmergenciaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verPacientesDeEmergenciaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facturarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
    }
}

