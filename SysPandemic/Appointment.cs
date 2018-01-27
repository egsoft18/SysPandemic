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
    public partial class Appointment : Form
    {
        DBManager c = new DBManager();

        public Appointment()
        {
            InitializeComponent();
        }

        private void btnbus_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            string tablename = "Citas";
            string xml = "appointv.xml";
            string rpt = "appointview.rpt";

            try
            {
                if (txtbuscar.Text.Length < 0)
                {
                    string query = "Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem ";

                    c.printreport(query, tablename, xml, rpt);
                }
                else if (rdbid.Checked == true)
                {
                    string query = "Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem where id like '%" + txtbuscar.Text + "%'";

                    c.printreport(query, tablename, xml, rpt);
                }


                else if (rdbpac.Checked == true)
                {
                    string query = "Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem where namepa like '%" + txtbuscar.Text + "%'";

                    c.printreport(query, tablename, xml, rpt);
                }


                else if (rdbidp.Checked == true)
                {
                    string query = "Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem where idpatient like '%" + txtbuscar.Text + "%'";

                    c.printreport(query, tablename, xml, rpt);
                }


                else if (rdbid.Checked == true)
                {
                    string query = "Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem where iddoctor like '%" + txtbuscar.Text + "%'";

                    c.printreport(query, tablename, xml, rpt);
                }

                else if (rdbdoct.Checked == true)
                {
                    string query = "Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem where namedoctor like '%" + txtbuscar.Text + "%'";

                    c.printreport(query, tablename, xml, rpt);
                }

                else if (rdbfecha.Checked == true)
                {
                    string query = "Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem where date like '%" + dtpfecha.Text + "%'";

                    c.printreport(query, tablename, xml, rpt);
                }
                else if (rdbiddoc.Checked == true)
                {
                    string query = "Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem where iddoctor like '%" + txtbuscar.Text + "%'";

                    c.printreport(query, tablename, xml, rpt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            string query = "Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem ";
           
            c.load_dgv(dataGridView1, query);
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            rdbfecha.PerformClick();
            string query = "Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem ";
            
            c.load_dgv(dataGridView1, query);
                
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            agrescitas frm = new agrescitas();
            DataGridViewRow act = dataGridView1.Rows[e.RowIndex];
           
            frm.txtid.Text = act.Cells["id"].Value.ToString();
            frm.txtidpa.Text = act.Cells["Idpaciente"].Value.ToString();
            frm.txtpaciente.Text = act.Cells["Paciente"].Value.ToString();
            frm.txtiddo.Text = act.Cells["Iddoctor"].Value.ToString();
            frm.txtdoct.Text = act.Cells["Doctor"].Value.ToString();
            frm.dtpfecha.Text = act.Cells["Fecha"].Value.ToString();
            frm.dtphora.Text = act.Cells["Hora"].Value.ToString();
            frm.btnguardar.Hide();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private DateTime DateTime(string time, string p, System.Globalization.CultureInfo cultureInfo)
        {
            throw new NotImplementedException();
        }

        private DateTime DateTime(string time, string p)
        {
            throw new NotImplementedException();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }
        private void buscar()
        {
                if (txtbuscar.Text.Length < 0)
                {
                    string query = "Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem ";
                
                    c.load_dgv(dataGridView1, query);
                }
                else if (rdbid.Checked == true)
                {
                   string query = "Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem where id like '%" + txtbuscar.Text + "%'";
                     
                    c.load_dgv(dataGridView1, query);
                }


                else if (rdbpac.Checked == true)
                {
                    string query = "Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem where namepa like '%" + txtbuscar.Text + "%'";
                     
                    c.load_dgv(dataGridView1, query);
                }


                else if (rdbidp.Checked == true)
                {
                    string query = "Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem where idpatient like '%" + txtbuscar.Text + "%'";
                     
                    c.load_dgv(dataGridView1, query);
                }


                else if (rdbid.Checked == true)
                {
                    string query = "Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem where iddoctor like '%" + txtbuscar.Text + "%'";
                     
                    c.load_dgv(dataGridView1, query);
                }

                else if (rdbdoct.Checked == true)
                {
                    string query =  "Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem where namedoctor like '%" + txtbuscar.Text + "%'";
                    
                    c.load_dgv(dataGridView1, query);
                }

                else if (rdbfecha.Checked == true)
                {
                    string query = "Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem where date like '%" + dtpfecha.Text + "%'";
                     
                    c.load_dgv(dataGridView1, query);
                }
                else if (rdbiddoc.Checked == true)
                {
                    string query = "Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem where iddoctor like '%" + txtbuscar.Text + "%'";
                     
                    c.load_dgv(dataGridView1, query);
                }
        }       

        private void txtbuscar_KeyDown(object sender, KeyEventArgs e)
        {
            buscar();
        }

        private void Appointment_Activated(object sender, EventArgs e)
        {
            string query = "Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem ";

            c.load_dgv(dataGridView1, query);
        }
    }
    }

