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

            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is addprocedure);
                if (frm2 != null)
                {
                    f.BringToFront();
                    MessageBox.Show("Esta ventana ya esta abierta.", "Error");
                    return;
                }
                else
                {
                    string query = "INSERT INTO [patient](idperson) VALUES('empty');";
                    DBManager c = new DBManager();
                    string query2 = "DELETE FROM [patient] WHERE name is null";
                    c.command3(query2);
                    c.command3(query);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error New Procedure");

            }
            finally
            {

            }



            try
            {

                string query = "Select idpatient from [patient] where idpatient = (select max(idpatient) from [patient])";
                string condition = "idpatient";
                DBManager c = new DBManager();
                c.last_id(f.idpatient_txt, query, condition);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error TXT");
            }
            finally
            {

            }

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
           
            
        }

        private void doctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doctors frm = new doctors();
            frm.MdiParent = this;
            frm.Show();
        }

        private void administrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void subProcedimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modulo en revision", "No disponible");
            //managesubprocedure frm = new managesubprocedure();
            //frm.MdiParent = this;
            //frm.Show();
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

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void agregarSeguroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addinsurance frm = new addinsurance();
            frm.MdiParent = this;
            frm.Show();
        }

        private void administrarSegurosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seeinsurance frm = new seeinsurance();
            frm.MdiParent = this;
            frm.Show();
        }

        private void administrarProcesosSinSeguroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seepwi frm = new seepwi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void resetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prescription frm = new prescription();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cierreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closing frm = new closing();
            frm.MdiParent = this;
            frm.Show();
        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void entradaDeFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void entradaDeFacturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            enterinvoice frm = new enterinvoice();
            frm.MdiParent = this;
            frm.Show();
        }

        private void suplidoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            suppliers frm = new suppliers();
            frm.MdiParent = this;
            frm.Show();
        }

        private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seeinvoice frm = new seeinvoice();
            frm.MdiParent = this;
            frm.Show();
        }

        private void crearCotizacionDeProcedimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addprocedure frm = new addprocedure();
            frm.MdiParent = this;
            frm.updateprocedure_btn.Hide();
            frm.delateprocedure_btn.Hide();
            frm.turnregular_btn.Hide();

            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is addprocedure);
                if (frm2 != null)
                {
                    frm.BringToFront();
                    MessageBox.Show("El formuario ya esta abierto.", "Error");
                    return;
                }
                else
                {
                    string status = "NO PAGADO";
                    string query = "INSERT INTO [procedure](statuspay, ptype) VALUES('" + status + "', 'Cotizacion');";
                    DBManager c = new DBManager();
                    string query2 = "DELETE FROM [procedure] WHERE idpatient is null";
                    c.command3(query2);
                    c.command3(query);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error New Procedure");

            }
            finally
            {

            }

            try
            {

                string query = "Select idprocedure from [procedure] where idprocedure = (select max(idprocedure) from [procedure])";
                string condition = "idprocedure";
                DBManager c = new DBManager();
                c.last_id(frm.idprocedure_txt, query, condition);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error TXT");
            }
            finally
            {

            }

            frm.Show();
        }

        private void agregarProcedimientoRegularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addprocedure frm = new addprocedure();
            frm.MdiParent = this;
            frm.updateprocedure_btn.Hide();
            frm.delateprocedure_btn.Hide();
            frm.turnregular_btn.Hide();

            try
            {
                Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is addprocedure);
                if (frm2 != null)
                {
                    frm.BringToFront();
                    MessageBox.Show("El formuario ya esta abierto.", "Error");
                    return;
                }
                else
                {
                    string status = "NO PAGADO";
                    string query = "INSERT INTO [procedure](statuspay, ptype) VALUES('" + status + "', 'Regular');";
                    DBManager c = new DBManager();
                    string query2 = "DELETE FROM [procedure] WHERE idpatient is null";
                    c.command3(query2);
                    c.command3(query);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error New Procedure");

            }
            finally
            {

            }

            try
            {

                string query = "Select idprocedure from [procedure] where idprocedure = (select max(idprocedure) from [procedure])";
                string condition = "idprocedure";
                DBManager c = new DBManager();
                c.last_id(frm.idprocedure_txt, query, condition);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error TXT");
            }
            finally
            {

            }
            frm.Show();
        }

        private void administrarProcedimientosRegularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            procedures frm = new procedures();
            frm.MdiParent = this;

            frm.spatient_rbtn.PerformClick();
            DBManager c = new DBManager();
            try
            {
                string query = "Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, [procedure] as Procedimiento, tooth as Diente, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito, dateprocedure as Fecha from [procedure] where pricepay > 0 and ptype = 'Regular'";
                c.load_dgv(frm.dataGridView1, query);
                frm.scondition_txt.Text = "Regular";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            frm.Show();
        }

        private void verCotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            procedures frm = new procedures();
            frm.MdiParent = this;

            frm.spatient_rbtn.PerformClick();
            DBManager c = new DBManager();
            try
            {
                string query = "Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, [procedure] as Procedimiento, tooth as Diente, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito, dateprocedure as Fecha from [procedure] where pricepay > 0 and ptype = 'Cotizacion'";
                c.load_dgv(frm.dataGridView1, query);
                frm.scondition_txt.Text = "Cotizacion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            frm.Show();
        }
    }
    }

