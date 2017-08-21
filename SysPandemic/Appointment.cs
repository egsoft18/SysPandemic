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
        public Appointment()
        {
            InitializeComponent();
        }

        private void btnbus_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                if (txtbuscar.Text.Length < 0)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem ", cnx);
                    DataTable tabla = new DataTable("Citas");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else if (rdbid.Checked == true)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem where id like '%" + txtbuscar.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Citas");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }


                else if (rdbpac.Checked == true)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem where namepa like '%" + txtbuscar.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Citas");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }


                else if (rdbidp.Checked == true)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem where idpatient like '%" + txtbuscar.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Citas");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }


                else if (rdbid.Checked == true)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem where iddoctor like '%" + txtbuscar.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Citas");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }

                else if (rdbdoct.Checked == true)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem where namedoctor like '%" + txtbuscar.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Citas");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }

                else if (rdbfecha.Checked == true)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem where date like '%" + dtpfecha.Text+ "%'", cnx);
                    DataTable tabla = new DataTable("Citas");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else if (rdbiddoc.Checked == true)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem where iddoctor like '%" + txtbuscar.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Citas");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }

            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                if (rdbfecha.Checked == true)
                {
                    
                        SQLiteDataAdapter ad;
                        DataTable dt = new DataTable();
                        SQLiteCommand cmd = cnx.CreateCommand();
                        cmd.CommandText = "Select id as ID, idpatient as IDdelPaciente, namepa as Paciente, iddoctor as IDdelDoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem  where date like '%" + dtpfecha.Text + "%'";
                        ad = new SQLiteDataAdapter(cmd);

                        DataSet ds = new DataSet();
                        ad.Fill(dt);
                        ds.Tables.Add(dt);
                        if (dt.Rows.Count <= 0)
                        {
                            MessageBox.Show("No hay datos que imprimir.");
                        }
                        else
                        { 
                        ds.Tables[0].TableName = "Citas";
                        ds.WriteXml(@"C:\SysPandemic\xml\appointv.xml");
                        reportview rv = new reportview("appointview.rpt");
                        rv.Show();
                        }
                   
                    
                }

                else if (txtbuscar.Text.Length == 0 )
                {
                    SQLiteDataAdapter ad;
                    DataTable dt = new DataTable();
                    SQLiteCommand cmd = cnx.CreateCommand();
                    cmd.CommandText = "Select id as ID, idpatient as IDdelPaciente, namepa as Paciente, iddoctor as IDdelDoctor, namedoctor as Doctor,assist as Asistencia,assist as Asistencia, date as Fecha, time as Hora from datem";
                    ad = new SQLiteDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    ad.Fill(dt);
                    ds.Tables.Add(dt);

                        if (dt.Rows.Count <= 0)
                        {
                            MessageBox.Show("No hay datos que imprimir.");
                        }
                        else
                        {
                            ds.Tables[0].TableName = "Citas";
                            ds.WriteXml(@"C:\SysPandemic\xml\appointv.xml");
                            reportview rv = new reportview("appointview.rpt");
                            rv.Show();
                        }
                }


                else if (rdbid.Checked == true)
                {
                    SQLiteDataAdapter ad;
                    DataTable dt = new DataTable();
                    SQLiteCommand cmd = cnx.CreateCommand();
                    cmd.CommandText = "Select id as ID, idpatient as IDdelPaciente, namepa as Paciente, iddoctor as IDdelDoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem  where id = '%" + txtbuscar.Text+"'";
                    ad = new SQLiteDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    ad.Fill(dt);
                    ds.Tables.Add(dt);
                    if (dt.Rows.Count <= 0)
                    {
                        MessageBox.Show("No hay datos que imprimir.");
                    }
                    else
                    {
                        ds.Tables[0].TableName = "Citas";
                        ds.WriteXml(@"C:\SysPandemic\xml\appointv.xml");
                        reportview rv = new reportview("appointview.rpt");
                        rv.Show();
                    }
                }


                else if (rdbidp.Checked == true)
                {
                    SQLiteDataAdapter ad;
                    DataTable dt = new DataTable();
                    SQLiteCommand cmd = cnx.CreateCommand();
                    cmd.CommandText = "Select id as ID, idpatient as IDdelPaciente, namepa as Paciente, iddoctor as IDdelDoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem  where idpatient like '%" + txtbuscar.Text + "%'";
                    ad = new SQLiteDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        ad.Fill(dt);
                        ds.Tables.Add(dt);
                        if (dt.Rows.Count <= 0)
                        {
                            MessageBox.Show("No hay datos que imprimir.");
                        }
                        else
                        {
                            ds.Tables[0].TableName = "Citas";
                            ds.WriteXml(@"C:\SysPandemic\xml\appointv.xml");
                            reportview rv = new reportview("appointview.rpt");
                            rv.Show();
                        }
                }
            


                else if (rdbiddoc.Checked == true)
                {
                    SQLiteDataAdapter ad;
                    DataTable dt = new DataTable();
                    SQLiteCommand cmd = cnx.CreateCommand();
                    cmd.CommandText = "Select id as ID, idpatient as IDdelPaciente, namepa as Paciente, iddoctor as IDdelDoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem  where iddoctor like '%" + txtbuscar.Text + "%'";
                    ad = new SQLiteDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        ad.Fill(dt);
                        ds.Tables.Add(dt);
                        if (dt.Rows.Count <= 0)
                        {
                            MessageBox.Show("No hay datos que imprimir.");
                        }
                        else
                        {
                            ds.Tables[0].TableName = "Citas";
                            ds.WriteXml(@"C:\SysPandemic\xml\appointv.xml");
                            reportview rv = new reportview("appointview.rpt");
                            rv.Show();
                        }
                }

                else if (rdbdoct.Checked == true)
                {
                    SQLiteDataAdapter ad;
                    DataTable dt = new DataTable();
                    SQLiteCommand cmd = cnx.CreateCommand();
                    cmd.CommandText = "Select id as ID, idpatient as IDdelPaciente, namepa as Paciente, iddoctor as IDdelDoctor, namedoctor as Doctor, assist as Asistencia, date as Fecha, time as Hora from datem  where namedoctor like '%" + txtbuscar.Text + "%'";
                    ad = new SQLiteDataAdapter(cmd);
                   
                        DataSet ds = new DataSet();
                        ad.Fill(dt);
                        ds.Tables.Add(dt);
                        if (dt.Rows.Count <= 0)
                        {
                            MessageBox.Show("No hay datos que imprimir.");
                        }
                        else
                        {
                            ds.Tables[0].TableName = "Citas";
                            ds.WriteXml(@"C:\SysPandemic\xml\appointv.xml");
                            reportview rv = new reportview("appointview.rpt");
                            rv.Show();
                        }
                }

                else if (rdbpac.Checked == true)
                {
                    SQLiteDataAdapter ad;
                    DataTable dt = new DataTable();
                    SQLiteCommand cmd = cnx.CreateCommand();
                    cmd.CommandText = "Select id as ID, idpatient as IDdelPaciente, namepa as Paciente, iddoctor as IDdelDoctor, namedoctor as Doctor, assist as Asistencia, date as Fecha, time as Hora from datem  where namepa like '%" + txtbuscar.Text + "%'";
                    ad = new SQLiteDataAdapter(cmd);
                    
                        DataSet ds = new DataSet();
                        ad.Fill(dt);
                        ds.Tables.Add(dt);
                        if (dt.Rows.Count <= 0)
                        {
                            MessageBox.Show("No hay datos que imprimir.");
                        }
                        else
                        {
                            ds.Tables[0].TableName = "Citas";
                            ds.WriteXml(@"C:\SysPandemic\xml\appointv.xml");
                            reportview rv = new reportview("appointview.rpt");
                            rv.Show();
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem ", cnx);
                DataTable tabla = new DataTable("Citas");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            rdbfecha.PerformClick();
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, idpatient as IdPaciente, namepa as Paciente, iddoctor as Iddoctor, namedoctor as Doctor,assist as Asistencia, date as Fecha, time as Hora from datem " ,cnx);
                DataTable tabla = new DataTable("Citas");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            frm.Show();
        }
    }
    }

