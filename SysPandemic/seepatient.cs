using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SysPandemic
{
    public partial class searchpatient : Form
    {
        public searchpatient()
        {
            InitializeComponent();
            
        }

        private void seepatient_Load(object sender, EventArgs e)
        {
            sname_rbtn.PerformClick();
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient", cnx);
                DataTable tabla = new DataTable("Pacientes");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddPatient frm = new AddPatient();
            DataGridViewRow act = dataGridView1.Rows[e.RowIndex];
            frm.idpatient_txt.Text = act.Cells["ID"].Value.ToString();
            frm.namepatient_txt.Text = act.Cells["Nombre"].Value.ToString();
            frm.bdaypatient_dtp.Text = act.Cells["FechaNac"].Value.ToString();
            frm.sexpatient_cb.Text = act.Cells["Sexo"].Value.ToString();
            frm.idperson_txt.Text = act.Cells["Cedula"].Value.ToString();
            frm.addresspatient_txt.Text = act.Cells["Direccion"].Value.ToString();
            frm.telpatient_txt.Text = act.Cells["Telefono"].Value.ToString();
            frm.celpatient_txt.Text = act.Cells["Celular"].Value.ToString();
            frm.tworkpatient_txt.Text = act.Cells["TelTrabajo"].Value.ToString();
            frm.insurancepatient_txt.Text = act.Cells["Seguro"].Value.ToString();
            frm.affiliatepatient_txt.Text = act.Cells["Afiliado"].Value.ToString();

            frm.savepatient_txt.Hide();
            
            frm.Show();
        }

        private void sid_rbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                if (search_txt.Text.Length == 0)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient", cnx);
                    DataTable tabla = new DataTable("Pacientes");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else if (sid_rbtn.Checked)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient where id like '%" + search_txt.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Pacientes");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else if (sname_rbtn.Checked)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient where name like '%" + search_txt.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Pacientes");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else if (sidperson_rbtn.Checked)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient where idperson like '%" + search_txt.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Pacientes");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient", cnx);
                    DataTable tabla = new DataTable("Pacientes");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
            
        }

        private void refreshpatient_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient", cnx);
                DataTable tabla = new DataTable("Pacientes");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void addpatient_btn_Click(object sender, EventArgs e)
        {
            AddPatient frm = new AddPatient();
            frm.Show();
        }

        private void printpatientlist_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                if (search_txt.Text.Length == 0)
                {
                    SQLiteDataAdapter ad;
                    DataTable dt = new DataTable();
                    SQLiteCommand cmd = cnx.CreateCommand();
                    cmd.CommandText = "Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient";
                    ad = new SQLiteDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    ad.Fill(dt);
                    ds.Tables.Add(dt);
                    if (dt.Rows.Count <= 0)
                    {
                        MessageBox.Show("No hay datos que imprimir.");
                    }
                    else { 
                    ds.Tables[0].TableName = "Pacientes";
                    ds.WriteXml(@"C:\SysPandemic\xml\listpatient.xml");
                    //MessageBox.Show("Done");
                    reportview rv = new reportview("listpatient.rpt");
                    rv.Show();
                    }
                }
                else if (sid_rbtn.Checked)
                {
                    SQLiteDataAdapter ad;
                    DataTable dt = new DataTable();
                    SQLiteCommand cmd = cnx.CreateCommand();
                    cmd.CommandText = "Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient where id like '%" + search_txt.Text + "%'";
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
                        ds.Tables[0].TableName = "Pacientes";
                        ds.WriteXml(@"C:\SysPandemic\xml\listpatient.xml");
                        //MessageBox.Show("Done");
                        reportview rv = new reportview("listpatient.rpt");
                        rv.Show();
                    }
                }
                else if (sname_rbtn.Checked)
                {
                    SQLiteDataAdapter ad;
                    DataTable dt = new DataTable();
                    SQLiteCommand cmd = cnx.CreateCommand();
                    cmd.CommandText = "Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient where name like '%" + search_txt.Text + "%'";
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
                        ds.Tables[0].TableName = "Pacientes";
                        ds.WriteXml(@"C:\SysPandemic\xml\listpatient.xml");
                        //MessageBox.Show("Done");
                        reportview rv = new reportview("listpatient.rpt");
                        rv.Show();
                    }
                }
                else if (sidperson_rbtn.Checked)
                {
                   SQLiteDataAdapter ad;
                    DataTable dt = new DataTable();
                    SQLiteCommand cmd = cnx.CreateCommand();
                    cmd.CommandText = "Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient where idperson like '%" + search_txt.Text + "%'";
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
                        ds.Tables[0].TableName = "Pacientes";
                        ds.WriteXml(@"C:\SysPandemic\xml\listpatient.xml");
                        //MessageBox.Show("Done");
                        reportview rv = new reportview("listpatient.rpt");
                        rv.Show();
                    }
                }
                else
                {
                    SQLiteDataAdapter ad;
                    DataTable dt = new DataTable();
                    SQLiteCommand cmd = cnx.CreateCommand();
                    cmd.CommandText = "Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient";
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
                        ds.Tables[0].TableName = "Pacientes";
                        ds.WriteXml(@"C:\SysPandemic\xml\listpatient.xml");
                        //MessageBox.Show("Done");
                        reportview rv = new reportview("listpatient.rpt");
                        rv.Show();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
