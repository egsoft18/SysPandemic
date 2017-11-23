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
            this.cierreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segurosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarSeguroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarSegurosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarProcesosSinSeguroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miselaneasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartaDeIncapacidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartaDeAltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
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
            this.doctoresToolStripMenuItem,
            this.segurosToolStripMenuItem,
            this.miselaneasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
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
            this.agregarCitaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.agregarCitaToolStripMenuItem.Text = "Agregar Cita";
            this.agregarCitaToolStripMenuItem.Click += new System.EventHandler(this.agregarCitaToolStripMenuItem_Click);
            // 
            // verCitasToolStripMenuItem
            // 
            this.verCitasToolStripMenuItem.Name = "verCitasToolStripMenuItem";
            this.verCitasToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.verCitasToolStripMenuItem.Text = "Ver Citas";
            this.verCitasToolStripMenuItem.Click += new System.EventHandler(this.verCitasToolStripMenuItem_Click);
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturarToolStripMenuItem,
            this.cToolStripMenuItem,
            this.cierreToolStripMenuItem});
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.facturacionToolStripMenuItem.Text = "Finanzas";
            this.facturacionToolStripMenuItem.Click += new System.EventHandler(this.facturacionToolStripMenuItem_Click);
            // 
            // facturarToolStripMenuItem
            // 
            this.facturarToolStripMenuItem.Name = "facturarToolStripMenuItem";
            this.facturarToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.facturarToolStripMenuItem.Text = "Facturar Procedimiento";
            this.facturarToolStripMenuItem.Click += new System.EventHandler(this.facturarToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.cToolStripMenuItem.Text = "CxC/CP";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // cierreToolStripMenuItem
            // 
            this.cierreToolStripMenuItem.Name = "cierreToolStripMenuItem";
            this.cierreToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.cierreToolStripMenuItem.Text = "Cierre";
            this.cierreToolStripMenuItem.Click += new System.EventHandler(this.cierreToolStripMenuItem_Click);
            // 
            // doctoresToolStripMenuItem
            // 
            this.doctoresToolStripMenuItem.Name = "doctoresToolStripMenuItem";
            this.doctoresToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.doctoresToolStripMenuItem.Text = "Doctores";
            this.doctoresToolStripMenuItem.Click += new System.EventHandler(this.doctoresToolStripMenuItem_Click);
            // 
            // segurosToolStripMenuItem
            // 
            this.segurosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarSeguroToolStripMenuItem,
            this.administrarSegurosToolStripMenuItem,
            this.administrarProcesosSinSeguroToolStripMenuItem});
            this.segurosToolStripMenuItem.Name = "segurosToolStripMenuItem";
            this.segurosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.segurosToolStripMenuItem.Text = "Seguros";
            // 
            // agregarSeguroToolStripMenuItem
            // 
            this.agregarSeguroToolStripMenuItem.Name = "agregarSeguroToolStripMenuItem";
            this.agregarSeguroToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.agregarSeguroToolStripMenuItem.Text = "Agregar Seguro";
            this.agregarSeguroToolStripMenuItem.Click += new System.EventHandler(this.agregarSeguroToolStripMenuItem_Click);
            // 
            // administrarSegurosToolStripMenuItem
            // 
            this.administrarSegurosToolStripMenuItem.Name = "administrarSegurosToolStripMenuItem";
            this.administrarSegurosToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.administrarSegurosToolStripMenuItem.Text = "Administrar Seguros";
            this.administrarSegurosToolStripMenuItem.Click += new System.EventHandler(this.administrarSegurosToolStripMenuItem_Click);
            // 
            // administrarProcesosSinSeguroToolStripMenuItem
            // 
            this.administrarProcesosSinSeguroToolStripMenuItem.Name = "administrarProcesosSinSeguroToolStripMenuItem";
            this.administrarProcesosSinSeguroToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.administrarProcesosSinSeguroToolStripMenuItem.Text = "Administrar procesos sin seguro";
            this.administrarProcesosSinSeguroToolStripMenuItem.Click += new System.EventHandler(this.administrarProcesosSinSeguroToolStripMenuItem_Click);
            // 
            // miselaneasToolStripMenuItem
            // 
            this.miselaneasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetaToolStripMenuItem,
            this.cartaDeIncapacidadToolStripMenuItem,
            this.cartaDeAltaToolStripMenuItem});
            this.miselaneasToolStripMenuItem.Name = "miselaneasToolStripMenuItem";
            this.miselaneasToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.miselaneasToolStripMenuItem.Text = "Impresiones";
            // 
            // resetaToolStripMenuItem
            // 
            this.resetaToolStripMenuItem.Name = "resetaToolStripMenuItem";
            this.resetaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.resetaToolStripMenuItem.Text = "Prescripción";
            this.resetaToolStripMenuItem.Click += new System.EventHandler(this.resetaToolStripMenuItem_Click);
            // 
            // cartaDeIncapacidadToolStripMenuItem
            // 
            this.cartaDeIncapacidadToolStripMenuItem.Name = "cartaDeIncapacidadToolStripMenuItem";
            this.cartaDeIncapacidadToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cartaDeIncapacidadToolStripMenuItem.Text = "Carta de Incapacidad";
            // 
            // cartaDeAltaToolStripMenuItem
            // 
            this.cartaDeAltaToolStripMenuItem.Name = "cartaDeAltaToolStripMenuItem";
            this.cartaDeAltaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cartaDeAltaToolStripMenuItem.Text = "Carta de alta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // Homeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.ToolStripMenuItem segurosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarSeguroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarSegurosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarProcesosSinSeguroToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem miselaneasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartaDeIncapacidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartaDeAltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cierreToolStripMenuItem;
    }
}

