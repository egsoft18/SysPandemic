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
    public partial class doctors : Form
    {
        public doctors()
        {
            InitializeComponent();
        }

        private void doctors_Load(object sender, EventArgs e)
        {
            sname_rbtn.PerformClick();
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select iddoctors as ID, name as Nombre, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular from doctors", cnx);
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
            adddoctor frm = new adddoctor();
            DataGridViewRow act = dataGridView1.Rows[e.RowIndex];
            frm.iddoctor_txt.Text = act.Cells["ID"].Value.ToString();
            frm.namedoctor_txt.Text = act.Cells["Nombre"].Value.ToString();
            frm.sexdoctor_cb.Text = act.Cells["Sexo"].Value.ToString();
            frm.idperson_txt.Text = act.Cells["Cedula"].Value.ToString();
            frm.addressdoctor_txt.Text = act.Cells["Direccion"].Value.ToString();
            frm.teldoctor_txt.Text = act.Cells["Telefono"].Value.ToString();
            frm.celdoctor_txt.Text = act.Cells["Celular"].Value.ToString();
            frm.savedoctor_btn.Hide();
            frm.Show();
        }

        private void adddoctor_btn_Click(object sender, EventArgs e)
        {
            adddoctor frm = new adddoctor();
            frm.updatedoctor_btn.Hide();
            frm.delatedoctor_btn.Hide();

            frm.Show();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select iddoctors as ID, name as Nombre, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular from doctors", cnx);
                DataTable tabla = new DataTable("Pacientes");
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
                if (search_txt.Text.Length == 0)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular from doctors", cnx);
                    DataTable tabla = new DataTable("Doctores");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else if (sid_rbtn.Checked)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular from doctors where id like '%" + search_txt.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Doctores");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else if (sname_rbtn.Checked)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular  from doctors where name like '%" + search_txt.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Doctores");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else if (sidperson_rbtn.Checked)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular  from doctors where idperson like '%" + search_txt.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Doctores");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular from doctors", cnx);
                    DataTable tabla = new DataTable("Doctores");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }
    }
}
