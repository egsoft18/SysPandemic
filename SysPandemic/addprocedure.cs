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
            deleteclose();
        }

        private void searchpatient_btn_Click(object sender, EventArgs e)
        {
            spatient frm = new spatient();
            frm.Show();
        }

        private void addprocedure_Load(object sender, EventArgs e)
        {
            //loadsubprocedure();
            //sums();
            spname_rbtn.PerformClick();
            sdname_rbtn.PerformClick();
            SQLiteConnection cnx1 = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            cnx1.Open();
            cnx1.Close();


            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, sex as Sexo, idperson as Cedula, insurance as Seguro, affiliate as Afiliado from patient", cnx);
                DataTable tabla = new DataTable("Pacientes");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;

                SQLiteDataAdapter adac2 = new SQLiteDataAdapter("Select iddoctors as ID, name as Nombre, sex as Sexo, idperson as Cedula from doctors", cnx);
                DataTable tabla2 = new DataTable("doctors");
                adac2.Fill(tabla2);
                dataGridView2.DataSource = tabla2;

                SQLiteDataAdapter adac3 = new SQLiteDataAdapter("Select id as ID, idprocedure as IDProcedimiento, codeinsurance as Codigo, subprocedure as Procedimiento, tariff as Tarifa, coverage as Cobertura, difference as Diferencia, paystatus as Pago, insurance as Seguro from subprocedure where idprocedure = '" + idprocedure_txt.Text + "'", cnx);
                DataTable tabla3 = new DataTable("Subprocesos");
                adac3.Fill(tabla3);
                dataGridView3.DataSource = tabla3;

                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                cnx.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow act = dataGridView1.Rows[e.RowIndex];
            pidpatient_txt.Text = act.Cells["ID"].Value.ToString();
            pnamepatient_txt.Text = act.Cells["Nombre"].Value.ToString();
            insurance_txt.Text = act.Cells["Seguro"].Value.ToString();
            affiliate_txt.Text = act.Cells["Afiliado"].Value.ToString();

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow act = dataGridView2.Rows[e.RowIndex];
            piddoctor_txt.Text = act.Cells["ID"].Value.ToString();
            pnamedoctor_txt.Text = act.Cells["Nombre"].Value.ToString();
        }

        private void sp_btn_Click(object sender, EventArgs e)
        {
            searchpatient();
        }

        private void searchpatient()
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
            finally
            {
                cnx.Close();
            }
        }
        private void sd_btn_Click(object sender, EventArgs e)
        {
            searchdoctor();
        }

        private void searchdoctor()
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                if (sd_txt.Text.Length == 0)
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select iddoctors as ID, name as Nombre, sex as Sexo, idperson as Cedula from doctors", cnx);
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
            finally
            {
                cnx.Close();
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

                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
            finally
            {
                cnx.Close();
            }
        }

        private void pricepay_txt_TextChanged(object sender, EventArgs e)
        {
        }

        private void calcule_btn_Click(object sender, EventArgs e)
        {
            sums();
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
                        cnx.Close();
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
            finally
            {
                cnx.Close();
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
                        cnx.Close();
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
                finally
                {
                    cnx.Close();
                }

            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void sp_txt_TextChanged(object sender, EventArgs e)
        {
            searchpatient();
        }

        private void sd_txt_TextChanged(object sender, EventArgs e)
        {
            searchdoctor();
        }

        private void option_cb_TextChanged(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                string option = option_cb.Text;
                if (option == "Seguro")
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, code as Codigo, pinsurance as Descripcion, tariff as Tarifa, coverage as Cobertura, difference as Diferencia, insurance as Seguro from detailsinsurance where insurance = '" + insurance_txt.Text + "'", cnx);
                    DataTable tabla = new DataTable("Pacientes");
                    adac.Fill(tabla);
                    dataGridView4.DataSource = tabla;
                    cnx.Close();
                }
                else if (option == "Sin seguro")
                {
                    SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, code as Codigo, pinsurance as Descripcion, tariff as Tarifa, coverage as Cobertura, difference as Diferencia, insurance as Seguro from detailsinsurance where insurance = 'NO SEGURO'", cnx);
                    DataTable tabla = new DataTable("Pacientes");
                    adac.Fill(tabla);
                    dataGridView4.DataSource = tabla;
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                cnx.Close();
            }
        }

        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
                try
                {
                    cnx.Open();
                    DataGridViewRow act = dataGridView4.Rows[e.RowIndex];
                    string description = act.Cells["Descripcion"].Value.ToString();
                    string tariff = act.Cells["Tarifa"].Value.ToString();
                    string coverage = act.Cells["Cobertura"].Value.ToString();
                    string difference = act.Cells["Diferencia"].Value.ToString();
                    string code = act.Cells["Codigo"].Value.ToString();
                    string insurance = act.Cells["Seguro"].Value.ToString();
                    string paystatus = "No Pagado";

                    string comando = "INSERT INTO subprocedure(idprocedure, codeinsurance, subprocedure, tariff, coverage, difference, paystatus, insurance) VALUES('" + idprocedure_txt.Text + "', '" + code + "','" + description + "','" + tariff + "', '" + coverage + "', '" + difference + "', '" + paystatus + "', '" + insurance + "')";
                    SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
                    if (insertion.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Done");
                    }
                    cnx.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Insert");
                }
                finally
                {
                    cnx.Close();
                    //sums();
                    try
                    {
                        loadsubprocedure();
                    }
                    catch
                    {
                        MessageBox.Show("No mando a cargar.");
                    }
                }
        }
        public void loadsubprocedure()
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, idprocedure as IDProcedimiento, codeinsurance as Codigo, subprocedure as Procedimiento, tariff as Tarifa, coverage as Cobertura, difference as Diferencia, paystatus as Pago, insurance as Seguro from subprocedure where idprocedure = '" + idprocedure_txt.Text + "'", cnx);
                DataTable tabla = new DataTable("Subprocesos");
                adac.Fill(tabla);
                dataGridView3.DataSource = tabla;
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Load");
            }
            finally
            {
                cnx.Close();
            }
        }
        public void sums()
        {
            Decimal result = dataGridView3.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDecimal(x.Cells["Tarifa"].Value));
            realpay_txt.Text = Convert.ToString(result);

            Decimal result2 = dataGridView3.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDecimal(x.Cells["Cobertura"].Value));
            iscoverage_txt.Text = Convert.ToString(result2);

            decimal result3 = Convert.ToDecimal(realpay_txt.Text) - Convert.ToDecimal(iscoverage_txt.Text);
            pricepay_txt.Text = Convert.ToString(result3);
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                DialogResult result = MessageBox.Show("Seguro que desea Borrar?", "Borrar Sub-Procedimiento", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow act = dataGridView3.Rows[e.RowIndex];
                    string description = act.Cells["ID"].Value.ToString();
                    string comando = "DELETE FROM subprocedure WHERE id = '" + description + "'";
                    SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
                    if (insertion.ExecuteNonQuery() > 0)
                    {
                        cnx.Close();
                        loadsubprocedure();
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
            finally
            {
                cnx.Close();
            }

        }
        private void deleteclose()
        {
            //SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            //try
            //        {
            //            cnx.Open();
            //            if (idprocedure_txt.Text.Length > 0)
            //            {
            //                string comando = "DELETE FROM subprocedure WHERE idprocedure = '" + idprocedure_txt.Text + "'";
            //                SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
            //                if (insertion.ExecuteNonQuery() > 0)
            //                {
            //                    cnx.Close();

            //                    MessageBox.Show("Cerrado");
            //                }
            //            }  
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message, "Delete catch");
            //        }
            //finally
            //{
            //    cnx.Close();
            //}
            Close();
                }
        private void addprocedure_FormClosing(object sender, FormClosingEventArgs e)
        {
            deleteclose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView3_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                DialogResult result = MessageBox.Show("Seguro que desea Borrar?", "Borrar Sub-Procedimiento", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow act = dataGridView3.Rows[e.RowIndex];
                    string description = act.Cells["ID"].Value.ToString();
                    string comando = "DELETE FROM subprocedure WHERE id = '" + description + "'";
                    SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
                    if (insertion.ExecuteNonQuery() > 0)
                    {
                        cnx.Close();
                        loadsubprocedure();
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
            finally
            {
                cnx.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal price = Convert.ToDecimal(pricepay_txt.Text);
                if (descuent_txt.Text.Length == 0)
                {
                    decimal result3 = Convert.ToDecimal(realpay_txt.Text) - Convert.ToDecimal(iscoverage_txt.Text);
                    pricepay_txt.Text = Convert.ToString(result3);
                }
                else if (price > 0)
                {
                    decimal des = Convert.ToDecimal(descuent_txt.Text);
                    int result3 = dataGridView3.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToInt32(x.Cells["Diferencia"].Value));
                    decimal re = result3 - des;
                    pricepay_txt.Text = Convert.ToString(re);
                }
                else if (price < 0)
                {
                    decimal result3 = Convert.ToDecimal(realpay_txt.Text) - Convert.ToDecimal(iscoverage_txt.Text);
                    pricepay_txt.Text = Convert.ToString(result3);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error Catch");
            }
        }

        private void procedure_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void procedure_txt_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
