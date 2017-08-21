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
    public partial class procedures : Form
    {
        public procedures()
        {
            InitializeComponent();
        }

        private void procedures_Load(object sender, EventArgs e)
        {
            sprocedure_rbtn.PerformClick();
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito, dateprocedure as Fecha from procedure", cnx);
                DataTable tabla = new DataTable("Procedimientos");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                if (snopay_rbtn.Checked)
                {
                    string status = "NO PAGADO";
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from procedure where statuspay = '" + status + "'", cnx);
                    DataTable tabla = new DataTable("Procedure");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else if (spay_rbtn.Checked)
                {
                    string status = "PAGADO";
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from procedure where statuspay = '" + status + "'", cnx);
                    DataTable tabla = new DataTable("Procedure");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else if (search_txt.Text.Length == 0)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from procedure", cnx);
                    DataTable tabla = new DataTable("Procedure");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else if (sid_rbtn.Checked)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from procedure where idprocedure like '%" + search_txt.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Procedure");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else if (spatient_rbtn.Checked)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from procedure where namepatient like '%" + search_txt.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Procedure");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else if (sdoctor_rbtn.Checked)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from procedure where namedoctor like '%" + search_txt.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Procedure");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else if (sprocedure_rbtn.Checked)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from procedure where procedure like '%" + search_txt.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Procedure");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addprocedure frm = new addprocedure();
            DataGridViewRow act = dataGridView1.Rows[e.RowIndex];
            frm.idprocedure_txt.Text = act.Cells["ID"].Value.ToString();
            frm.pidpatient_txt.Text = act.Cells["IdPaciente"].Value.ToString();
            frm.pnamepatient_txt.Text = act.Cells["Paciente"].Value.ToString();
            frm.piddoctor_txt.Text = act.Cells["IdDoctor"].Value.ToString();
            frm.pnamedoctor_txt.Text = act.Cells["Doctor"].Value.ToString();
            frm.procedure_txt.Text = act.Cells["Procedimiento"].Value.ToString();
            frm.realpay_txt.Text = act.Cells["Precio"].Value.ToString();
            frm.iscoverage_txt.Text = act.Cells["Cobertura"].Value.ToString();
            frm.pricepay_txt.Text = act.Cells["Total"].Value.ToString();
            frm.groupBox3.Hide();
            frm.saveprocedure_btn.Hide();
            frm.clear_btn.Hide();
           
            frm.Show();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito, dateprocedure as Fecha from procedure", cnx);
                DataTable tabla = new DataTable("Procedimientos");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void printlistprocedure_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                if (snopay_rbtn.Checked)
                {
                    string status = "NO PAGADO";
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from procedure where statuspay = '" + status + "'", cnx);
                    DataTable tabla = new DataTable("Procedure");
                    DataSet ds = new DataSet();
                    adac.Fill(tabla);
                    ds.Tables.Add(tabla);
                    if (tabla.Rows.Count <= 0)
                    {
                        MessageBox.Show("No hay datos que imprimir.");
                    }
                    else { 
                    ds.Tables[0].TableName = "Procedurelist";
                    ds.WriteXml(@"C:\SysPandemic\xml\procedurelist.xml");
                    reportview rv = new reportview("procedurelist.rpt");
                    rv.Show();
                    }
                }
                else if (spay_rbtn.Checked)
                {
                    string status = "PAGADO";
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from procedure where statuspay = '" + status + "'", cnx);
                    DataTable tabla = new DataTable("Procedure");
                    DataSet ds = new DataSet();
                    adac.Fill(tabla);
                    if (tabla.Rows.Count <= 0)
                    {
                        MessageBox.Show("No hay datos que imprimir.");
                    }
                    else
                    {
                        ds.Tables[0].TableName = "Procedurelist";
                        ds.WriteXml(@"C:\SysPandemic\xml\procedurelist.xml");
                        reportview rv = new reportview("procedurelist.rpt");
                        rv.Show();
                    }
                }
                else if (search_txt.Text.Length == 0)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from procedure", cnx);
                    DataTable tabla = new DataTable("Procedure");
                    DataSet ds = new DataSet();
                    adac.Fill(tabla);
                    ds.Tables.Add(tabla);
                    if (tabla.Rows.Count <= 0)
                    {
                        MessageBox.Show("No hay datos que imprimir.");
                    }
                    else
                    {
                        ds.Tables[0].TableName = "Procedurelist";
                        ds.WriteXml(@"C:\SysPandemic\xml\procedurelist.xml");
                        reportview rv = new reportview("procedurelist.rpt");
                        rv.Show();
                    }
                }
                else if (sid_rbtn.Checked)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from procedure where idprocedure like '%" + search_txt.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Procedure");
                    DataSet ds = new DataSet();
                    adac.Fill(tabla);
                    ds.Tables.Add(tabla);
                    if (tabla.Rows.Count <= 0)
                    {
                        MessageBox.Show("No hay datos que imprimir.");
                    }
                    else
                    {
                        ds.Tables[0].TableName = "Procedurelist";
                        ds.WriteXml(@"C:\SysPandemic\xml\procedurelist.xml");
                        reportview rv = new reportview("procedurelist.rpt");
                        rv.Show();
                    }
                }
                else if (spatient_rbtn.Checked)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from procedure where namepatient like '%" + search_txt.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Procedure");
                    DataSet ds = new DataSet();
                    adac.Fill(tabla);
                    ds.Tables.Add(tabla);
                    if (tabla.Rows.Count <= 0)
                    {
                        MessageBox.Show("No hay datos que imprimir.");
                    }
                    else
                    {
                        ds.Tables[0].TableName = "Procedurelist";
                        ds.WriteXml(@"C:\SysPandemic\xml\procedurelist.xml");
                        reportview rv = new reportview("procedurelist.rpt");
                        rv.Show();
                    }
                }
                else if (sdoctor_rbtn.Checked)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from procedure where namedoctor like '%" + search_txt.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Procedure");
                    DataSet ds = new DataSet();
                    adac.Fill(tabla);
                    ds.Tables.Add(tabla);
                    if (tabla.Rows.Count <= 0)
                    {
                        MessageBox.Show("No hay datos que imprimir.");
                    }
                    else
                    {
                        ds.Tables[0].TableName = "Procedurelist";
                        ds.WriteXml(@"C:\SysPandemic\xml\procedurelist.xml");
                        reportview rv = new reportview("procedurelist.rpt");
                        rv.Show();
                    }
                }
                else if (sprocedure_rbtn.Checked)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from procedure where procedure like '%" + search_txt.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Procedure");
                    DataSet ds = new DataSet();
                    adac.Fill(tabla);
                    ds.Tables.Add(tabla);
                    if (tabla.Rows.Count <= 0)
                    {
                        MessageBox.Show("No hay datos que imprimir.");
                    }
                    else
                    {
                        ds.Tables[0].TableName = "Procedurelist";
                        ds.WriteXml(@"C:\SysPandemic\xml\procedurelist.xml");
                        reportview rv = new reportview("procedurelist.rpt");
                        rv.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }
    }
}
