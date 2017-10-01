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
            DBManager c = new DBManager();
            c.patient_administrator(dataGridView1);

            //SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            //try
            //{
            //    cnx.Open();
            //    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient", cnx);
            //    DataTable tabla = new DataTable("Pacientes");
            //    adac.Fill(tabla);
            //    dataGridView1.DataSource = tabla;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddPatient frm = new AddPatient();
            try
            {
                DataGridViewRow act = dataGridView1.Rows[e.RowIndex];

                DateTime date = DateTime.Parse(act.Cells["FechaNac"].Value.ToString());
                //MessageBox.Show("Hey "+date.Day+"/"+date.Month+"/"+date.Year);

                string realdate = +date.Day+"/"+date.Month+"/"+date.Year;

                frm.idpatient_txt.Text = act.Cells["ID"].Value.ToString();
                frm.namepatient_txt.Text = act.Cells["Nombre"].Value.ToString();
                frm.bdaypatient_dtp.Text = act.Cells["FechaNac"].Value.ToString();
                //frm.bdaypatient_dtp.Text = realdate;
                frm.sexpatient_cb.Text = act.Cells["Sexo"].Value.ToString();
                frm.idperson_txt.Text = act.Cells["Cedula"].Value.ToString();
                frm.addresspatient_txt.Text = act.Cells["Direccion"].Value.ToString();
                frm.telpatient_txt.Text = act.Cells["Telefono"].Value.ToString();
                frm.celpatient_txt.Text = act.Cells["Celular"].Value.ToString();
                frm.tworkpatient_txt.Text = act.Cells["TelTrabajo"].Value.ToString();
                frm.insurancepatient_txt.Text = act.Cells["Seguro"].Value.ToString();
                frm.affiliatepatient_txt.Text = act.Cells["Afiliado"].Value.ToString();

                String idpatient = act.Cells["ID"].Value.ToString();
               
                DBManager c = new DBManager();
                string query = "Select * from medicald where idpatient = '" + idpatient + "'";
                c.fill_diag(query, frm.tmed_cb, frm.tmedcom_txt, frm.mica_cb, frm.micacom_txt, frm.ps_cb, frm.diab_cb, frm.hep_cb, frm.hepcom_txt, frm.pr_cb, frm.pe_cb, frm.pecom_txt, frm.pa_cb, frm.pacom_txt, frm.hemo_cb, frm.aler_cb, frm.alercom_txt);

                frm.savepatient_txt.Hide();
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede abrir a editar. La causa: " + ex.Message, "Error");
            }
        }

        private void sid_rbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            buscar();
            
        }

        private void refreshpatient_btn_Click(object sender, EventArgs e)
        {

            sname_rbtn.PerformClick();
            DBManager c = new DBManager();
            c.patient_administrator(dataGridView1);


            //SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            //try
            //{
            //    cnx.Open();
            //    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient", cnx);
            //    DataTable tabla = new DataTable("Pacientes");
            //    adac.Fill(tabla);
            //    dataGridView1.DataSource = tabla;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}
        }

        private void addpatient_btn_Click(object sender, EventArgs e)
        {
            AddPatient frm = new AddPatient();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void printpatientlist_btn_Click(object sender, EventArgs e)
        {
            DBManager c = new DBManager();
           try
            {
                if (search_txt.Text.Length == 0)
                {
                    string query = "Select idpatient as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient";
                    string tablename = "Pacientes";
                    string xml = "listpatient.xml";
                    string report = "listpatient.rpt";
                    c.printreport(query, tablename, xml, report);
                    
                }
                else if (sid_rbtn.Checked)
                {
                    string query = "Select idpatient as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient where id like '%" + search_txt.Text + "%'";
                    string tablename = "Pacientes";
                    string xml = "listpatient.xml";
                    string report = "listpatient.rpt";
                    c.printreport(query, tablename, xml, report);

                }
                else if (sname_rbtn.Checked)
                {
                    string query = "Select idpatient as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient where name like '%" + search_txt.Text + "%'";
                    string tablename = "Pacientes";
                    string xml = "listpatient.xml";
                    string report = "listpatient.rpt";
                    c.printreport(query, tablename, xml, report);
                }
                else if (sidperson_rbtn.Checked)
                {
                    string query = "Select idpatient as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient where idperson like '%" + search_txt.Text + "%'";
                    string tablename = "Pacientes";
                    string xml = "listpatient.xml";
                    string report = "listpatient.rpt";
                    c.printreport(query, tablename, xml, report);
                }
                else
                {
                    string query = "Select idpatient as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient";
                    string tablename = "Pacientes";
                    string xml = "listpatient.xml";
                    string report = "listpatient.rpt";
                    c.printreport(query, tablename, xml, report);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }


            //SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            //try
            //{
            //    cnx.Open();
            //    if (search_txt.Text.Length == 0)
            //    {
            //        SQLiteDataAdapter ad;
            //        DataTable dt = new DataTable();
            //        SQLiteCommand cmd = cnx.CreateCommand();
            //        cmd.CommandText = "Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient";
            //        ad = new SQLiteDataAdapter(cmd);
            //        DataSet ds = new DataSet();
            //        ad.Fill(dt);
            //        ds.Tables.Add(dt);
            //        if (dt.Rows.Count <= 0)
            //        {
            //            MessageBox.Show("No hay datos que imprimir.");
            //        }
            //        else { 
            //        ds.Tables[0].TableName = "Pacientes";
            //        ds.WriteXml(@"C:\SysPandemic\xml\listpatient.xml");
            //        //MessageBox.Show("Done");
            //        reportview rv = new reportview("listpatient.rpt");
            //        rv.Show();
            //        }
            //    }
            //    else if (sid_rbtn.Checked)
            //    {
            //        SQLiteDataAdapter ad;
            //        DataTable dt = new DataTable();
            //        SQLiteCommand cmd = cnx.CreateCommand();
            //        cmd.CommandText = "Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient where id like '%" + search_txt.Text + "%'";
            //        ad = new SQLiteDataAdapter(cmd);
            //        DataSet ds = new DataSet();
            //        ad.Fill(dt);
            //        ds.Tables.Add(dt);
            //        if (dt.Rows.Count <= 0)
            //        {
            //            MessageBox.Show("No hay datos que imprimir.");
            //        }
            //        else
            //        {
            //            ds.Tables[0].TableName = "Pacientes";
            //            ds.WriteXml(@"C:\SysPandemic\xml\listpatient.xml");
            //            //MessageBox.Show("Done");
            //            reportview rv = new reportview("listpatient.rpt");
            //            rv.Show();
            //        }
            //    }
            //    else if (sname_rbtn.Checked)
            //    {
            //        SQLiteDataAdapter ad;
            //        DataTable dt = new DataTable();
            //        SQLiteCommand cmd = cnx.CreateCommand();
            //        cmd.CommandText = "Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient where name like '%" + search_txt.Text + "%'";
            //        ad = new SQLiteDataAdapter(cmd);
            //        DataSet ds = new DataSet();
            //        ad.Fill(dt);
            //        ds.Tables.Add(dt);
            //        if (dt.Rows.Count <= 0)
            //        {
            //            MessageBox.Show("No hay datos que imprimir.");
            //        }
            //        else
            //        {
            //            ds.Tables[0].TableName = "Pacientes";
            //            ds.WriteXml(@"C:\SysPandemic\xml\listpatient.xml");
            //            //MessageBox.Show("Done");
            //            reportview rv = new reportview("listpatient.rpt");
            //            rv.Show();
            //        }
            //    }
            //    else if (sidperson_rbtn.Checked)
            //    {
            //       SQLiteDataAdapter ad;
            //        DataTable dt = new DataTable();
            //        SQLiteCommand cmd = cnx.CreateCommand();
            //        cmd.CommandText = "Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient where idperson like '%" + search_txt.Text + "%'";
            //        ad = new SQLiteDataAdapter(cmd);
            //        DataSet ds = new DataSet();
            //        ad.Fill(dt);
            //        ds.Tables.Add(dt);
            //        if (dt.Rows.Count <= 0)
            //        {
            //            MessageBox.Show("No hay datos que imprimir.");
            //        }
            //        else
            //        {
            //            ds.Tables[0].TableName = "Pacientes";
            //            ds.WriteXml(@"C:\SysPandemic\xml\listpatient.xml");
            //            //MessageBox.Show("Done");
            //            reportview rv = new reportview("listpatient.rpt");
            //            rv.Show();
            //        }
            //    }
            //    else
            //    {
            //        SQLiteDataAdapter ad;
            //        DataTable dt = new DataTable();
            //        SQLiteCommand cmd = cnx.CreateCommand();
            //        cmd.CommandText = "Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient";
            //        ad = new SQLiteDataAdapter(cmd);
            //        DataSet ds = new DataSet();
            //        ad.Fill(dt);
            //        ds.Tables.Add(dt);
            //        if (dt.Rows.Count <= 0)
            //        {
            //            MessageBox.Show("No hay datos que imprimir.");
            //        }
            //        else
            //        {
            //            ds.Tables[0].TableName = "Pacientes";
            //            ds.WriteXml(@"C:\SysPandemic\xml\listpatient.xml");
            //            //MessageBox.Show("Done");
            //            reportview rv = new reportview("listpatient.rpt");
            //            rv.Show();
            //        }
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");

            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void buscar()
        {
           string txtsearch = search_txt.Text;
            if (search_txt.Text.Length == 0)
            {
                DBManager c = new DBManager();
                c.patient_administrator(dataGridView1);
            }
            else if (sid_rbtn.Checked)
            {
                string condition = "idpatient";
                DBManager c = new DBManager();
                c.search_patient(dataGridView1,condition, txtsearch);
            }
            else if (sname_rbtn.Checked)
            {
                string condition = "name";
                DBManager c = new DBManager();
                c.search_patient(dataGridView1, condition, txtsearch);
            }
            else if (sidperson_rbtn.Checked)
            {
                string condition = "idperson";
                DBManager c = new DBManager();
                c.search_patient(dataGridView1, condition, txtsearch);
            }
            else
            {
                DBManager c = new DBManager();
                c.patient_administrator(dataGridView1);
            }





            // SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            //try
            //{
            //    cnx.Open();
            //    if (search_txt.Text.Length == 0)
            //    {
            //        SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient", cnx);
            //        DataTable tabla = new DataTable("Pacientes");
            //        adac.Fill(tabla);
            //        dataGridView1.DataSource = tabla;
            //    }
            //    else if (sid_rbtn.Checked)
            //    {
            //        SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient where id like '%" + search_txt.Text + "%'", cnx);
            //        DataTable tabla = new DataTable("Pacientes");
            //        adac.Fill(tabla);
            //        dataGridView1.DataSource = tabla;
            //    }
            //    else if (sname_rbtn.Checked)
            //    {
            //        SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient where name like '%" + search_txt.Text + "%'", cnx);
            //        DataTable tabla = new DataTable("Pacientes");
            //        adac.Fill(tabla);
            //        dataGridView1.DataSource = tabla;
            //    }
            //    else if (sidperson_rbtn.Checked)
            //    {
            //        SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient where idperson like '%" + search_txt.Text + "%'", cnx);
            //        DataTable tabla = new DataTable("Pacientes");
            //        adac.Fill(tabla);
            //        dataGridView1.DataSource = tabla;
            //    }
            //    else
            //    {
            //        SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient", cnx);
            //        DataTable tabla = new DataTable("Pacientes");
            //        adac.Fill(tabla);
            //        dataGridView1.DataSource = tabla;
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");

            //}
        }

        private void search_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscar();
            }
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
