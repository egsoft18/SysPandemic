using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment.Application;
using System.Threading;
using System.Data.SqlClient;

namespace SysPandemic
{
    public partial class Homeform : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        OpenDB c = new OpenDB();
        public Homeform()
        {
            InitializeComponent();
        }


        private void agregarProcedimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatient f = new AddPatient();

            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is AddPatient);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: "+ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchpatient f = new searchpatient();
            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is searchpatient);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: " + ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agregarProcedimientoToolStripMenuItem_Click_1(object sender, EventArgs e)
        { }
        private void doctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchdoctors f = new searchdoctors();
            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is searchdoctors);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: " + ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void administrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }
        private void subProcedimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modulo en revision", "No disponible");
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void agregarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agrescitas f = new agrescitas();
            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is agrescitas);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: " + ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Appointment f = new Appointment();
            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Appointment);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: " + ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pacienteDeEmergenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void verPacientesDeEmergenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Homeform_Load(object sender, EventArgs e)
        {
            //Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = SystemColors.ControlLight;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
        }

        private void closeform_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Close();
            
        }

        private void pacienteDeEmergenciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            emergencypatient f = new emergencypatient();
            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is emergencypatient);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: " + ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verPacientesDeEmergenciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            emerpatv f = new emerpatv();
            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is emerpatv);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: " + ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            topay f = new topay();
            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is topay);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: " + ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxcp f = new cxcp();
            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is cxcp);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: " + ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void agregarSeguroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addinsurance f = new addinsurance();
            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is addinsurance);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: " + ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void administrarSegurosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchinsurances f = new searchinsurances();
            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is searchinsurances);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: " + ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void administrarProcesosSinSeguroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seepwi f = new seepwi();
            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is seepwi);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: " + ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void resetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prescription f = new prescription();
            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is prescription);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: " + ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cierreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closing f = new closing();
            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is closing);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: " + ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void entradaDeFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void entradaDeFacturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            enterinvoice f = new enterinvoice();
            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is enterinvoice);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: " + ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void suplidoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            suppliers f = new suppliers();
            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is suppliers);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: " + ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seeinvoice f = new seeinvoice();
            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is seeinvoice);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: " + ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void crearCotizacionDeProcedimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addprocedure f = new addprocedure();
            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is addprocedure);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: " + ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agregarProcedimientoRegularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addprocedure f = new addprocedure();
            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is addprocedure);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: " + ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void administrarProcedimientosRegularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            procedures f = new procedures();
            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is procedures);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: " + ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verCotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            procedures f = new procedures();
            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is procedures);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: " + ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void descuentosADoctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void externoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            descpayrolldocext f = new descpayrolldocext();
            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is descpayrolldocext);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: " + ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nominaDeDoctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            payroll f = new payroll();
            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is payroll);
                if (frm2 != null)
                {
                    frm2.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    f.MdiParent = this;
                    f.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir el ventana solicitado. Razón: " + ex.Message, "Error al abrir la ventana.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
    }

