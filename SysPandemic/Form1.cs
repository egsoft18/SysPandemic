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

namespace SysPandemic
{
    public partial class Homeform : Form
    {
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
            f.MdiParent = this;
            f.delatepatient_btn.Hide();
            f.updatepatient_btn.Hide();
            f.printpatient_btn.Hide();
            f.Show();
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchpatient f = new searchpatient();
            f.MdiParent = this;
            f.Show();
        }

        private void agregarProcedimientoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            addprocedure frm = new addprocedure();
            frm.MdiParent = this;
            frm.updateprocedure_btn.Hide();
            frm.delateprocedure_btn.Hide();
            frm.Show();
        }

        private void doctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doctors frm = new doctors();
            frm.MdiParent = this;
            frm.Show();
        }

        private void administrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            procedures frm = new procedures();
            frm.MdiParent = this;
            
            frm.Show();
        }

        private void subProcedimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            managesubprocedure frm = new managesubprocedure();
            frm.MdiParent = this;
            frm.Show();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void agregarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agrescitas f = new agrescitas();
            f.MdiParent = this;
            f.btnactualizar.Hide();
            f.btnborrar.Hide();
            f.btnconfirmar.Hide();
            f.Show();
        }

        private void verCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Appointment f = new Appointment();
            f.MdiParent = this;
            f.Show();
        }

        private void pacienteDeEmergenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void verPacientesDeEmergenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Homeform_Load(object sender, EventArgs e)
        {  
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
            f.MdiParent = this;
            f.updatepa_btn.Hide();
            f.seebill_btn.Hide();
            f.deletepa_btn.Hide();
            f.billpa_btn.Hide();
            f.Show();
        }

        private void verPacientesDeEmergenciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            emerpatv f = new emerpatv();
            f.MdiParent = this;
            f.Show();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            topay frm = new topay();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cxcp frm = new cxcp();
            frm.cxc_rbtn.PerformClick();
            frm.allcxc_rbtn.PerformClick();
            frm.MdiParent = this;
            frm.Show();
        }
    }
    }

