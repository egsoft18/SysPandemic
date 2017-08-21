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
    public partial class addprocedure : Form
    {
        public addprocedure()
        {
            InitializeComponent();
            
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchpatient_btn_Click(object sender, EventArgs e)
        {
            spatient frm = new spatient();
            frm.Show();
        }

        private void addprocedure_Load(object sender, EventArgs e)
        {
            spname_rbtn.PerformClick();
            sdname_rbtn.PerformClick();
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, sex as Sexo, idperson as Cedula from patient", cnx);
                DataTable tabla = new DataTable("Pacientes");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;

                SQLiteDataAdapter adac2 = new SQLiteDataAdapter("Select iddoctors as ID, name as Nombre, sex as Sexo, idperson as Cedula from doctors", cnx);
                DataTable tabla2 = new DataTable("doctors");
                adac2.Fill(tabla2);
                dataGridView2.DataSource = tabla2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow act = dataGridView1.Rows[e.RowIndex];
            pidpatient_txt.Text = act.Cells["ID"].Value.ToString();
            pnamepatient_txt.Text = act.Cells["Nombre"].Value.ToString();
            
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow act = dataGridView2.Rows[e.RowIndex];
            piddoctor_txt.Text = act.Cells["ID"].Value.ToString();
            pnamedoctor_txt.Text = act.Cells["Nombre"].Value.ToString();
        }

        private void sp_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                if (sp_txt.Text.Length == 0)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, sex as Sexo, idperson as Cedula from patient", cnx);
                    DataTable tabla = new DataTable("Pacientes");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else if (spid_rbtn.Checked)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, sex as Sexo, idperson as Cedula from patient where id like '%" + sp_txt.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Pacientes");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else if (spname_rbtn.Checked)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, sex as Sexo, idperson as Cedula from patient where name like '%" + sp_txt.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Pacientes");
                    adac.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                else if (spidperson_rbtn.Checked)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, sex as Sexo, idperson as Cedula from patient where idperson like '%" + sp_txt.Text + "%'", cnx);
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

        private void sd_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                if (sd_txt.Text.Length == 0)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, sex as Sexo, idperson as Cedula from doctors", cnx);
                    DataTable tabla = new DataTable("Doctores");
                    adac.Fill(tabla);
                    dataGridView2.DataSource = tabla;
                }
                else if (sdid_rbtn.Checked)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select iddoctors as ID, name as Nombre, sex as Sexo, idperson as Cedula from doctors where id like '%" + sd_txt.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Doctores");
                    adac.Fill(tabla);
                    dataGridView2.DataSource = tabla;
                }
                else if (sdname_rbtn.Checked)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select iddoctors as ID, name as Nombre, sex as Sexo, idperson as Cedula from doctors where name like '%" + sd_txt.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Doctores");
                    adac.Fill(tabla);
                    dataGridView2.DataSource = tabla;
                }
                else if (sdidperson_rbtn.Checked)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select iddoctors as ID, name as Nombre, sex as Sexo, idperson as Cedula from doctors where idperson like '%" + sd_txt.Text + "%'", cnx);
                    DataTable tabla = new DataTable("Doctores");
                    adac.Fill(tabla);
                    dataGridView2.DataSource = tabla;
                }
                else
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select iddoctors as ID, name as Nombre, sex as Sexo, idperson as Cedula from doctors", cnx);
                    DataTable tabla = new DataTable("Doctores");
                    adac.Fill(tabla);
                    dataGridView2.DataSource = tabla;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        private void saveprocedure_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                string status = "NO PAGADO";
                string comando = "INSERT INTO procedure(idpatient, namepatient, iddoctor, namedoctor, procedure, realprice, iscoverage, pricepay, statuspay, dateprocedure) VALUES('" + pidpatient_txt.Text + "', '" + pnamepatient_txt.Text + "','" + piddoctor_txt.Text + "','" + pnamedoctor_txt.Text + "', '" + procedure_txt.Text + "', '" + realpay_txt.Text + "', '" + iscoverage_txt.Text + "', '" + pricepay_txt.Text + "', '" + status + "', '" + dateprocedure_dtp.Text + "' );";
                SQLiteCommand insertion = new SQLiteCommand(comando, cnx);

                if (insertion.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Se agrego correctamente");
                    pidpatient_txt.Clear();
                    pnamepatient_txt.Text = "";
                    piddoctor_txt.Clear();
                    pnamedoctor_txt.Clear();
                    procedure_txt.Clear();
                    realpay_txt.Clear();
                    pricepay_txt.Clear();
                    iscoverage_txt.Text = "";
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        private void pricepay_txt_TextChanged(object sender, EventArgs e)
        {
            
                
            
           
        }

        private void calcule_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(iscoverage_txt.Text))
                {
                    double realpay = Convert.ToDouble(realpay_txt.Text);
                    pricepay_txt.Text = Convert.ToString(realpay);
                    iscoverage_txt.Text = "0";
                }
                else
                {
                    double realpay = Convert.ToDouble(realpay_txt.Text);
                    double iscoverage = Convert.ToDouble(iscoverage_txt.Text);
                    double pricepay;
                    pricepay = realpay - iscoverage;
                    pricepay_txt.Text = Convert.ToString(pricepay);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha insertado un o varios valores invalidos: favor revise!", "Error");

            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            pidpatient_txt.Clear();
            pnamepatient_txt.Text = "";
            piddoctor_txt.Clear();
            pnamedoctor_txt.Clear();
            procedure_txt.Clear();
            realpay_txt.Clear();
            pricepay_txt.Clear();
            iscoverage_txt.Text = "";
        }

        private void updateprocedure_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                DialogResult result = MessageBox.Show("Seguro que desea Actualizar?", "Actualizar datos del Procedimiento", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string comando = "UPDATE procedure set iddoctor = '" + piddoctor_txt.Text + "', namedoctor = '" + pnamedoctor_txt.Text + "', procedure = '" + procedure_txt.Text + "', realprice = '" + realpay_txt.Text + "', iscoverage = '" + iscoverage_txt.Text + "', pricepay = '" + pricepay_txt.Text + "', dateprocedure = '" + dateprocedure_dtp.Text + "' WHERE idprocedure = '" + idprocedure_txt.Text + "'";
                    SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
                    if (insertion.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Se ha actualizado!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Algo fallo!!!");
                    }
                }
                else if (result == DialogResult.No)
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        private void delateprocedure_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar este Procedimiento?", "Eliminar procedimiento", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
                try
                {
                    cnx.Open();
                    string comando = "DELETE FROM procedure WHERE idprocedure = '" + idprocedure_txt.Text + "'";
                    SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
                    if (insertion.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Se ha eliminado!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Algo fue mal");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void sp_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
