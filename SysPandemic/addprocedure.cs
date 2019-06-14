using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        //Esta parte va debajo del public del formulario, fuera de las llavez de este.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DBManager c = new DBManager();
                string query = "DELETE FROM subprocedure WHERE idprocedure = '" + idprocedure_txt.Text + "'";
                c.command3(query);
                string query2 = "DELETE FROM [procedure] WHERE idpatient  is null";
                c.command3(query2);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar ventana. Causa " + ex.Message);
            }
            
        }

        private void searchpatient_btn_Click(object sender, EventArgs e)
        {
            spatient frm = new spatient();
            frm.Show();
        }

        private void addprocedure_Load(object sender, EventArgs e)
        {
            ptype_txt.BackColor = Color.White;
            ptype_txt.ForeColor = Color.Red;

            code_rbtn.PerformClick();
            spname_rbtn.PerformClick();
            sdname_rbtn.PerformClick();
            DBManager c = new DBManager();
            string ptype = "select ptype from [procedure] where idprocedure = '"+idprocedure_txt.Text+"'";
            c.fill_txt(ptype_txt, ptype, "ptype");
            string pacients = "Select idpatient as ID, name as Nombre, sex as Sexo, idperson as Cedula, insurance as Seguro, affiliate as Afiliado from patient where name is not null";
            c.load_dgv(dataGridView1, pacients);
            string doctors = "Select idstaff as ID, namestaff as Nombre, sexstaff as Sexo, idpersonstaff as Cedula from staff where rolestaff like 'Doctor'";
            c.load_dgv(dataGridView2, doctors);
            string sprocedure = "Select id as ID, idprocedure as IDProcedimiento, codeinsurance as Codigo, subprocedure as Procedimiento, tariff as Tarifa, coverage as Cobertura, difference as Diferencia, tooth as Diente, status as Estado, insurance as Seguro from subprocedure where idprocedure = '" + idprocedure_txt.Text + "'";
            c.load_dgv(dataGridView3, sprocedure);
            if (string.IsNullOrEmpty(pidpatient_txt.Text))
            {

            }
            else {
                string query = "select insurance from patient where idpatient = '" + pidpatient_txt.Text + "'";
                c.fill_txt(insurance_txt, query, "insurance");
                string query2 = "select affiliate from patient where idpatient = '" + pidpatient_txt.Text + "'";
                c.fill_txt(affiliate_txt, query2, "affiliate");
            }

            if (ptype_txt.Text == "Regular")
            {
                turnregular_btn.Hide();
            }
            else if (ptype_txt.Text == "Cotizacion")
            {
                
            }
            string querry8 = "select gaindoctor from [procedure] where idprocedure = '" + idprocedure_txt.Text + "'";
            string condition = "gaindoctor";
            c.fill_txt(gaindoctor_txt, querry8, condition);

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
            DBManager c = new DBManager();
           
            try
            {
                if (sp_txt.Text.Length == 0)
                {
                    string query = "Select idpatient as ID, name as Nombre, sex as Sexo, idperson as Cedula, insurance as Seguro, affiliate as Afiliado from patient";
                   c.load_dgv(dataGridView1, query);

                }
                else if (spid_rbtn.Checked)
                {
                    string query = "Select idpatient as ID, name as Nombre, sex as Sexo, idperson as Cedula, insurance as Seguro, affiliate as Afiliado from patient where idpatient like '%" + sp_txt.Text + "%'";
                    c.load_dgv(dataGridView1, query);
                }
                else if (spname_rbtn.Checked)
                {
                    string query = "Select idpatient as ID, name as Nombre, sex as Sexo, idperson as Cedula, insurance as Seguro, affiliate as Afiliado from patient where name like '%" + sp_txt.Text + "%'";
                    c.load_dgv(dataGridView1, query);
                }
                else if (spidperson_rbtn.Checked)
                {
                    string query = "Select idpatient as ID, name as Nombre, sex as Sexo, idperson as Cedula, insurance as Seguro, affiliate as Afiliado from patient where idperson like '%" + sp_txt.Text + "%'";
                    c.load_dgv(dataGridView1, query);
                }
                else
                {
                    string query = "Select idpatient as ID, name as Nombre, sex as Sexo, idperson as Cedula, insurance as Seguro, affiliate as Afiliado from patient";
                    c.load_dgv(dataGridView1, query);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
            finally
            {
               
            }
        }
        private void sd_btn_Click(object sender, EventArgs e)
        {
            searchdoctor();
        }

        private void searchdoctor()
        {
            DBManager c = new DBManager();
            try
            {
                if (sd_txt.Text.Length == 0)
                {
                    string query = "Select idstaff as ID, namestaff as Nombre, sexstaff as Sexo, idpersonstaff as Cedula from staff";
                    c.load_dgv(dataGridView2, query);
                }
                else if (sdid_rbtn.Checked)
                {
                    string query = "Select idstaff as ID, namestaff as Nombre, sexstaff as Sexo, idpersonstaff as Cedula from staff where idstaff like '%" + sd_txt.Text + "%'";
                    c.load_dgv(dataGridView2, query);
                }
                else if (sdname_rbtn.Checked)
                {
                    string query = "Select idstaff as ID, namestaff as Nombre, sexstaff as Sexo, idpersonstaff as Cedula from staff where namestaff like '%" + sd_txt.Text + "%'";
                    c.load_dgv(dataGridView2, query);
                }
                else if (sdidperson_rbtn.Checked)
                {
                    string query = "Select idstaff as ID, namestaff as Nombre, sexstaff as Sexo, idpersonstaff as Cedula from staff where idpersonstaff like '%" + sd_txt.Text + "%'";
                    c.load_dgv(dataGridView2, query);
                }
                else
                {
                    string query = "Select idstaff as ID, namestaff as Nombre, sexstaff as Sexo, idpersonstaff as Cedula from staff";
                    c.load_dgv(dataGridView2, query);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
            finally
            {
            }
        }
        private void saveprocedure_btn_Click(object sender, EventArgs e)
        {
            DBManager c = new DBManager();

            if (string.IsNullOrEmpty(gaindoctor_txt.Text) == false)
            {
                if (string.IsNullOrEmpty(pidpatient_txt.Text) == false)
                {
                    if (string.IsNullOrEmpty(piddoctor_txt.Text) == false)
                    {
                        if (string.IsNullOrEmpty(tooth_txt.Text) == false)
                        {
                            if (string.IsNullOrEmpty(procedure_txt.Text) == false)
                            {
                                if (string.IsNullOrEmpty(pricepay_txt.Text) == false)
                                {
                                    try
                                    {

                                        DialogResult result = MessageBox.Show("Seguro que desea Guardar?", "Guardar datos del Procedimiento", MessageBoxButtons.YesNo);
                                        if (result == DialogResult.Yes)
                                        {
                                            string query = "UPDATE [procedure] set idpatient = '" + pidpatient_txt.Text + "', namepatient = '" + pnamepatient_txt.Text + "', iddoctor = '" + piddoctor_txt.Text + "', namedoctor = '" + pnamedoctor_txt.Text + "', [procedure] = '" + procedure_txt.Text + "', realprice = '" + realpay_txt.Text + "', iscoverage = '" + iscoverage_txt.Text + "', pricepay = '" + pricepay_txt.Text + "', dateprocedure = '" + dateprocedure_dtp.Text + "', tooth = '" + tooth_txt.Text + "', gaindoctor = '" + gaindoctor_txt.Text + "' WHERE idprocedure = '" + idprocedure_txt.Text + "'";
                                            c.command(query);
                                            if (c.valor == "si")
                                            {
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
                                    finally
                                    {
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Al parecer no ha asignado Sub-Procesos a este procedimiento, favor revise.", "Falta informacion.");
                                }

                            }
                            else
                            {
                                MessageBox.Show("No ha escrito el titulo del procedimiento, favor revise.", "Falta informacion.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No ha asignado el diente de trabajo, favor revise.", "Falta informacion.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No ha ingresado un Doctor, favor revise.", "Falta informacion.");
                    }
                }
                else
                {
                    MessageBox.Show("No ha ingresado un Paciente, favor revise.", "Falta informacion.");
                }
            }
            else {
                MessageBox.Show("Debe de digitar la ganancia del doctor");
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
            DBManager c = new DBManager();

            if (string.IsNullOrEmpty(gaindoctor_txt.Text) == false)
            {
                if (string.IsNullOrEmpty(piddoctor_txt.Text) == false)
                {
                    if (string.IsNullOrEmpty(tooth_txt.Text) == false)
                    {
                        if (string.IsNullOrEmpty(procedure_txt.Text) == false)
                        {
                            DialogResult result = MessageBox.Show("Seguro que desea Actualizar?", "Actualizar datos del Procedimiento", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                string comando = "UPDATE [procedure] set iddoctor = '" + piddoctor_txt.Text + "', namedoctor = '" + pnamedoctor_txt.Text + "', [procedure] = '" + procedure_txt.Text + "', realprice = '" + realpay_txt.Text + "', iscoverage = '" + iscoverage_txt.Text + "', pricepay = '" + pricepay_txt.Text + "', tooth = '" + tooth_txt.Text + "' , dateprocedure = '" + dateprocedure_dtp.Text + "', gaindoctor = '" + gaindoctor_txt.Text + "' WHERE idprocedure = '" + idprocedure_txt.Text + "'";
                                c.command(comando);
                                if (c.valor == "si")
                                {
                                    Close();
                                    c.valor = "";
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
                        else
                        {
                            MessageBox.Show("No ha escrito el titulo del procedimiento, favor revise.", "Falta informacion.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No ha asignado el diente de trabajo, favor revise.", "Falta informacion.");
                    }
                }
                else
                {
                    MessageBox.Show("No ha ingresado un Doctor, favor revise.", "Falta informacion.");
                }
            }
            else
            {
                MessageBox.Show("Debe de digitar la ganancia del doctor antes de guardar", "Error");
            }
            
        }

        private void delateprocedure_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar este Procedimiento?", "Eliminar procedimiento", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DBManager c = new DBManager();
                try
                {
                    string comando = "DELETE FROM [procedure] WHERE idprocedure = '" + idprocedure_txt.Text + "'";
                    c.command(comando);
                    if (c.valor == "si")
                    {
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
                finally
                {
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
            
            try
            {
                DBManager c = new DBManager();
                string option = option_cb.Text;
                if (option == "Seguro")
                {
                    string query = "Select id as ID, code as Codigo, pinsurance as Descripcion, tariff as Tarifa, coverage as Cobertura, difference as Diferencia, insurance as Seguro from detailsinsurance where insurance = '" + insurance_txt.Text + "'";
                    c.load_dgv(dataGridView4, query);
                }
                else if (option == "Sin seguro")
                {
                    string query = "Select id as ID, code as Codigo, pinsurance as Descripcion, tariff as Tarifa, coverage as Cobertura, difference as Diferencia, insurance as Seguro from detailsinsurance where insurance = 'NO SEGURO'";
                    c.load_dgv(dataGridView4, query);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
            }
        }

        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
                {
                    DBManager c = new DBManager();
                    DataGridViewRow act = dataGridView4.Rows[e.RowIndex];
                    string description = act.Cells["Descripcion"].Value.ToString();
                    string tariff = act.Cells["Tarifa"].Value.ToString();
                    string coverage = act.Cells["Cobertura"].Value.ToString();
                    string difference = act.Cells["Diferencia"].Value.ToString();
                    string code = act.Cells["Codigo"].Value.ToString();
                    string insurance = act.Cells["Seguro"].Value.ToString();
                    string paystatus = "Sin Realizar";

                    string query = "INSERT INTO subprocedure(idprocedure, codeinsurance, subprocedure, tariff, coverage, difference, status, insurance) VALUES('" + idprocedure_txt.Text + "', '" + code + "','" + description + "','" + tariff + "', '" + coverage + "', '" + difference + "', '" + paystatus + "', '" + insurance + "')";
                    c.command3(query);
                    if (c.valor == "si")
                    {
                        //MessageBox.Show("Done");
                        c.valor = "";

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Insert");
                }
                finally
                {

                    
                    try
                    {
                        loadsubprocedure();
                        sums();
                    }
                    catch
                    {
                        MessageBox.Show("No mando a cargar.");
                    }
                }
        }
        public void loadsubprocedure()
        {
            DBManager c = new DBManager();

            try
            {
                string query = "Select id as ID, idprocedure as IDProcedimiento, codeinsurance as Codigo, subprocedure as Procedimiento, tariff as Tarifa, coverage as Cobertura, difference as Diferencia, tooth as Diente, status as Estado, insurance as Seguro from subprocedure where idprocedure = '" + idprocedure_txt.Text + "'";
                c.load_dgv(dataGridView3, query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Load");
            }
            finally
            {
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
            DBManager c = new DBManager();
            try
            {
                DialogResult result = MessageBox.Show("Seguro que desea Borrar?", "Borrar Sub-Procedimiento", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow act = dataGridView3.Rows[e.RowIndex];
                    string description = act.Cells["ID"].Value.ToString();
                    string query = "DELETE FROM subprocedure WHERE id = '" + description + "'";
                    c.command3(query);

                    string query2 = "Select id as ID, idprocedure as IDProcedimiento, codeinsurance as Codigo, subprocedure as Procedimiento, tariff as Tarifa, coverage as Cobertura, difference as Diferencia, paystatus as Pago, insurance as Seguro from subprocedure where idprocedure = '" + idprocedure_txt.Text + "'";
                    c.load_dgv(dataGridView3, query2);
                    sums();
                    
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
            }

        }
        private void deleteclose()
        {
            DBManager c = new DBManager();
            string query = "DELETE FROM subprocedure WHERE idprocedure = '" + idprocedure_txt.Text + "'";
            c.command3(query);
            string query2 = "DELETE FROM [procedure] WHERE idprocedure = '" + idprocedure_txt.Text + "'";
            c.command3(query2);

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
        //private void addprocedure_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    //DBManager c = new DBManager();
        //    //string query = "DELETE FROM subprocedure WHERE idprocedure = '" + idprocedure_txt.Text + "'";
        //    //c.command3(query);
        //    //string query2 = "DELETE FROM [procedure] WHERE idprocedure = '" + idprocedure_txt.Text + "'";
        //    //c.command3(query2);
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView3_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DBManager c = new DBManager();

            editsubprocedure frm = new editsubprocedure();

            DataGridViewRow act = dataGridView3.Rows[e.RowIndex];
            frm.ep_id_txt.Text = act.Cells["ID"].Value.ToString();
            frm.ep_idpro_txt.Text = act.Cells["IDProcedimiento"].Value.ToString();
            frm.ep_code_txt.Text = act.Cells["Codigo"].Value.ToString();
            frm.ep_pro_txt.Text = act.Cells["Procedimiento"].Value.ToString();
            frm.ep_ta_txt.Text = act.Cells["Tarifa"].Value.ToString();
            frm.ep_cov_txt.Text = act.Cells["Cobertura"].Value.ToString();


            frm.MdiParent = this.MdiParent;
            frm.Show();
            
            //try
            //{
            //    DialogResult result = MessageBox.Show("Seguro que desea Borrar?", "Borrar Sub-Procedimiento", MessageBoxButtons.YesNo);
            //    if (result == DialogResult.Yes)
            //    {
            //        DataGridViewRow act = dataGridView3.Rows[e.RowIndex];
            //        string description = act.Cells["ID"].Value.ToString();
            //        string query = "DELETE FROM subprocedure WHERE id = '" + description + "'";
            //        c.command3(query);

            //        string query2 = "Select id as ID, idprocedure as IDProcedimiento, codeinsurance as Codigo, subprocedure as Procedimiento, tariff as Tarifa, coverage as Cobertura, difference as Diferencia from subprocedure where idprocedure = '" + idprocedure_txt.Text + "'";
            //        c.load_dgv(dataGridView3, query2);
            //        sums();

            //    }
            //    else if (result == DialogResult.No)
            //    {

            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");

            //}
            //finally
            //{
            //}
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

        private void addprocedure_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            
        }

        private void searchprocess_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DBManager c = new DBManager();
                string option = option_cb.Text;
                if (option == "Seguro")
                {
                    if (code_rbtn.Checked)
                    {
                        string query = "Select id as ID, code as Codigo, pinsurance as Descripcion, tariff as Tarifa, coverage as Cobertura, difference as Diferencia, insurance as Seguro from detailsinsurance where insurance = '" + insurance_txt.Text + "' and code like '%" + searchprocess_txt.Text + "%'";
                        c.load_dgv(dataGridView4, query);
                    }
                    else if (des_rbtn.Checked) { 
                    string query = "Select id as ID, code as Codigo, pinsurance as Descripcion, tariff as Tarifa, coverage as Cobertura, difference as Diferencia, insurance as Seguro from detailsinsurance where insurance = '" + insurance_txt.Text + "' and pinsurance like '%"+searchprocess_txt.Text+"%'";
                    c.load_dgv(dataGridView4, query);
                    }
                }
                else if (option == "Sin seguro")
                {
                    if (code_rbtn.Checked)
                    {
                        string query = "Select id as ID, code as Codigo, pinsurance as Descripcion, tariff as Tarifa, coverage as Cobertura, difference as Diferencia, insurance as Seguro from detailsinsurance where insurance = 'NO SEGURO' and code like '%" + searchprocess_txt.Text + "%'";
                        c.load_dgv(dataGridView4, query);
                    }
                    else if (des_rbtn.Checked)
                    {
                        string query = "Select id as ID, code as Codigo, pinsurance as Descripcion, tariff as Tarifa, coverage as Cobertura, difference as Diferencia, insurance as Seguro from detailsinsurance where insurance = 'NO SEGURO' and pinsurance like '%" + searchprocess_txt.Text + "%'";
                        c.load_dgv(dataGridView4, query);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DBManager c = new DBManager();
            try
            {

                DialogResult result = MessageBox.Show("Seguro que desea pasar a ser un procedimientoRegular?", "Pasar a Procedimiento Regular", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = "UPDATE [procedure] set ptype = 'Regular'";
                    c.command(query);
                    if (c.valor == "si")
                    {
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
            finally
            {
            }
        }

        private void descuent_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void tooth_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addprocedure_Activated(object sender, EventArgs e)
        {
            loadsubprocedure();
            sums();
        }

        private void printprocedure_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DBManager c = new DBManager();
                string query = "select * from [procedure] where idprocedure = '" + idprocedure_txt.Text + "'";
                string tb = "Procedure";
                string xml = "procedure.xml";
                string rpt = "reportprocedure.rpt";
                c.test_printreport(query, tb, xml, rpt);

                string query3 = "select insurance, affiliate from patient where idpatient = '" + pidpatient_txt.Text + "'";
                string tb3 = "insuranceafi";
                string xml3 = "insuranceafi.xml";
                string rpt3 = "reportprocedure.rpt";
                c.test_printreport(query3, tb3, xml3, rpt3);

                string query2 = "select * from [subprocedure] where idprocedure = '" + idprocedure_txt.Text + "'";
                string tb2 = "SubProcedure";
                string xml2 = "subprocedure.xml";
                string rpt2 = "reportprocedure.rpt";
                c.printreport(query2, tb2, xml2, rpt2);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Errror al cargar el reporte, Causa: " + ex, "Error");
            }
        }

        private void gaindoctor_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void notes_btn_Click(object sender, EventArgs e)
        {
            string idpro = idprocedure_txt.Text;

            viewnotes frm = new viewnotes();
            frm.MdiParent = this.MdiParent;
            frm.vn_idpro_txt.Text = idpro;
            frm.Show();
        }

        private void dataGridView4_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            string idpro = idprocedure_txt.Text;
            variussubpro frm = new variussubpro();
            frm.MdiParent = this.MdiParent;

            DataGridViewRow act = dataGridView4.Rows[e.RowIndex];

            frm.vsp_activity_txt.Text = act.Cells["Descripcion"].Value.ToString();

            try
            {
                frm.vsp_tariff_txt.Text = act.Cells["Tarifa"].Value.ToString();
            }
            catch
            {
            }
            frm.vsp_coverage_txt.Text = act.Cells["Cobertura"].Value.ToString();
            frm.vsp_difference_txt.Text = act.Cells["Diferencia"].Value.ToString();
            frm.vsp_codeinsu_txt.Text = act.Cells["Codigo"].Value.ToString();
            frm.vsp_insurance_txt.Text = act.Cells["Seguro"].Value.ToString();

            frm.vsp_idprocedure_txt.Text = idpro;
            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
