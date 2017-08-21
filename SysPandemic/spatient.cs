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
    public partial class spatient : Form
    {
        public spatient()
        {
            InitializeComponent();
        }

        private void Searchpatient_Load(object sender, EventArgs e)
        {
            sname_rbtn.PerformClick();
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, sex as Sexo, idperson as Cedula from patient", cnx);
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
            this.Hide();
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                if (search_txt.Text.Length == 0)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, sex as Sexo, idperson as Cedula from patient", cnx);
                    DataTable tabla = new DataTable("Pacientes");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else if (sid_rbtn.Checked)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, sex as Sexo, idperson as Cedula from patient where id like '%" + search_txt.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Pacientes");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else if (sname_rbtn.Checked)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, sex as Sexo, idperson as Cedula from patient where name like '%" + search_txt.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Pacientes");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else if (sidperson_rbtn.Checked)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, sex as Sexo, idperson as Cedula from patient where idperson like '%" + search_txt.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Pacientes");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, sex as Sexo, idperson as Cedula from patient", cnx);
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addprocedure frm = new addprocedure();
            DataGridViewRow act = dataGridView1.Rows[e.RowIndex];
            frm.pidpatient_txt.Text = act.Cells["ID"].Value.ToString();
            frm.pnamepatient_txt.Text = act.Cells["Nombre"].Value.ToString();
            this.Hide();
        }
    }
}

