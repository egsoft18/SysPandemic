﻿using System;
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
    public partial class topay : Form
    {
        public topay()
        {
            InitializeComponent();
        }

        private void topay_Load(object sender, EventArgs e)
        {
            loadprocedure();
        }
        private void loadprocedure()
        {
            sprocedure_rbtn.PerformClick();
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idprocedure as ID, idpatient as IdPaciente, namepatient as Paciente, iddoctor as IdDoctor, namedoctor as Doctor, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total, statuspay as Credito from procedure", cnx);
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

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            loadprocedure();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addsubprocedure frm = new addsubprocedure();
            DataGridViewRow act = dataGridView1.Rows[e.RowIndex];
            frm.idsubprocedure_txt.Text = act.Cells["ID"].Value.ToString();
            frm.spnamepatient_txt.Text = act.Cells["Paciente"].Value.ToString();
            frm.spnamedoctor_txt.Text = act.Cells["Doctor"].Value.ToString();
            frm.sprocedure_txt.Text = act.Cells["Procedimiento"].Value.ToString();
            frm.sprealpay_txt.Text = act.Cells["Precio"].Value.ToString();
            frm.spiscoverage_txt.Text = act.Cells["Cobertura"].Value.ToString();
            frm.sppricepay_txt.Text = act.Cells["Total"].Value.ToString();
            frm.status_txt.Text = act.Cells["Credito"].Value.ToString();
            frm.subprocedure_txt.Focus();
            string pay = act.Cells["Credito"].Value.ToString();
            if (pay == "NO PAGADO")
            {
                frm.printpurchase_btn.Hide();
            }
            else if (pay == "")
            {
                frm.printpurchase_btn.Hide();
            }
            else if (pay == "PAGADO")
            {
                frm.checkout_btn.Hide();
            }
            frm.addsubprodecure_btn.Hide();
            frm.Show();
        }
    }
}
