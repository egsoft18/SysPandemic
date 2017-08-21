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
    public partial class emerpatv : Form
    {
        public emerpatv()
        {
            InitializeComponent();
            rdbid.PerformClick();
        }

        private void emerpatv_Load(object sender, EventArgs e)
        {
            rdbid.PerformClick();
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idep as ID,  name as Paciente, sex as Sexo, address as Direccion, tel as Telefono, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total,time as Fecha, statuspay as Credito from emerpat", cnx);
                DataTable tabla = new DataTable("Procedimientos");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                if (rdbfe.Checked == true)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idep as ID,  name as Paciente, sex as Sexo, address as Direccion, tel as Telefono, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total,time as Fecha, statuspay as Credito from emerpat where time like '%" + dtpfec.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Pacientes de Emergencia");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else if (txtbuscar.Text.Length < 0)
                {
                    
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idep as ID,  name as Paciente, sex as Sexo, address as Direccion, tel as Telefono, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total,time as Fecha, statuspay as Credito from emerpat", cnx);
                    DataTable tabla = new DataTable("Pacientes de Emergencia");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;

                }
                else if (rdbid.Checked == true)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idep as ID,  name as Paciente, sex as Sexo, address as Direccion, tel as Telefono, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total,time as Fecha, statuspay as Credito from emerpat where idep like '%" + txtbuscar.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Pacientes de Emergencia");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;

                }

                else if (rdbnom.Checked == true)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select idep as ID,  name as Paciente, sex as Sexo, address as Direccion, tel as Telefono, procedure as Procedimiento, realprice as Precio, iscoverage as Cobertura, pricepay as Total,time as Fecha, statuspay as Credito from emerpat where name like '%" + txtbuscar.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Pacientes de Emergencia");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }

                
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            emergencypatient frm = new emergencypatient();
            frm.btnguardar.Hide();
            DataGridViewRow act = dataGridView1.Rows[e.RowIndex];
            frm.idpaemer_txt.Text = act.Cells["ID"].Value.ToString();
            frm.txtname.Text = act.Cells["Paciente"].Value.ToString();
            frm.cmbsex.Text = act.Cells["Sexo"].Value.ToString();
            frm.txtaddres.Text = act.Cells["Direccion"].Value.ToString();
            frm.txttel.Text = act.Cells["Telefono"].Value.ToString();
            frm.txtprocedure.Text = act.Cells["Procedimiento"].Value.ToString();
            frm.txtprecio.Text = act.Cells["Precio"].Value.ToString();
            frm.txtcober.Text = act.Cells["Cobertura"].Value.ToString();
            frm.txtpreap.Text = act.Cells["Total"].Value.ToString();
            frm.dtptime.Text = act.Cells["Fecha"].Value.ToString();

            string pay = act.Cells["Credito"].Value.ToString();
            if (pay == "PAGADO")
            {
                frm.btnguardar.Hide();
                frm.updatepa_btn.Hide();
                frm.deletepa_btn.Hide();
                frm.billpa_btn.Hide();
            }
            else if (pay == "")
            {
                frm.btnguardar.Hide();
                frm.seebill_btn.Hide();
            }
            else if (pay == "NO PAGADO")
            {
                frm.seebill_btn.Hide();
            }
            frm.Show();
        }
    }
}
