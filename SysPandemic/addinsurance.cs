using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPandemic
{
    public partial class addinsurance : Form
    {

        /********** GLOSARIO **********/
        // txt = TextBox or MaskedTextBox
        // cb = ComboBox
        // btn = Button
        // cbx = CheckBox
        // dtp = DateTimePicker
        // dgv = DataGridView
        // gb = GroupBox

        // p = patient (paciente)
        // pm = patient's medical (Diagnostico Medico)
        // ph = patient's historial (Historial del Paciente)


        //SqlCommand cmd;
        //SqlDataReader dr;

        OpenDB c = new OpenDB();

        public bool formulario_devolver = false;
        public addinsurance()
        {
            InitializeComponent();
        }

        //Funcion especifica para movilidad del Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        /********** FUNCIONES & METODOS **********/
        private void buttons()
        {
            if (txt_i_id.Text.Length > 0)
            {
                btn_save.Hide();
                btn_update.Show();
            }
            else if (txt_i_id.Text.Length <= 0)
            {
                btn_save.Show();
                btn_update.Hide();
            }

            if (txt_di_id.Text.Length > 0)
            {
                btn_save_di.Hide();
                btn_update_di.Show();
            }
            else if (txt_di_id.Text.Length <= 0)
            {
                btn_save_di.Show();
                btn_update_di.Hide();
            }
        }

        private void difference()
        {

            if (txt_di_tariff.Text.Length > 0 && txt_di_coverage.Text.Length > 0)
            {
                txt_di_difference.Text = (Convert.ToDecimal(txt_di_tariff.Text) - Convert.ToDecimal(txt_di_coverage.Text)).ToString();
            }
            else if (txt_di_tariff.Text.Length > 0 && txt_di_coverage.Text.Length <= 0)
            {
                txt_di_difference.Text = (Convert.ToDecimal(txt_di_tariff.Text)).ToString();
            }
        }

        private void admininsurance()
        {
            if (txt_i_name.Text.Length > 0 && txt_i_contract.Text.Length > 0 && txt_i_pss.Text.Length > 0)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("admin_insurances", c.cnx))
                    {
                        int inttxt_i_id;
                        if (txt_i_id.Text.Length > 0)
                        {
                            inttxt_i_id = Convert.ToInt32(txt_i_id.Text);
                        }
                        else
                        {
                            inttxt_i_id = 0;
                        }

                        cmd.CommandType = CommandType.StoredProcedure;
                        
                        cmd.Parameters.Add("i_id", SqlDbType.Int).Value = inttxt_i_id;
                        cmd.Parameters.Add("i_name", SqlDbType.NVarChar).Value = txt_i_name.Text;
                        cmd.Parameters.Add("i_contract", SqlDbType.NVarChar).Value = txt_i_contract.Text;
                        cmd.Parameters.Add("i_pss", SqlDbType.NVarChar).Value = txt_i_pss.Text;
                        cmd.Parameters.Add("i_telephone", SqlDbType.NVarChar).Value = txt_i_telephone.Text;
                        cmd.Parameters.Add("i_email", SqlDbType.NVarChar).Value = txt_i_email.Text;
                        
                        int status = 1;
                        if (cbx_i_status.Checked == true)
                        {
                            status = 1;
                        }
                        else
                        {
                            status = 0;
                        }
                        cmd.Parameters.Add("i_status", SqlDbType.Int).Value = status;

                        cmd.Parameters.Add("u_id", SqlDbType.Int).Value = ActualUser.userid;
                        cmd.Parameters.Add("i_lu", SqlDbType.Date).Value = ActualUser.hoy;

                        cmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;


                        //cmd.ExecuteNonQuery();

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            //adminpacientemd(Convert.ToInt32(cmd.Parameters["@id"].Value));
                            MessageBox.Show("Se ha realizado la accion", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //clear(0);
                            txt_i_id.Text = Convert.ToString(cmd.Parameters["@id"].Value);
                            txt_i_name.Select();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo agregar la infromacion. La causa: " + ex.Message, "adminstaff try fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los campos: Nombre de la ARS, Contrato y PSS son campos obligatorios, favor verifique y vuelva a intentar. \n\n Si considera que esto es un error del sistema, favor comuníquese con el administrador.", "No se ha podido realizar la acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errors1();
                txt_i_name.Select();
            }
        }

        private void admindetail_insurance()
        {
            if (txt_i_id.Text.Length > 0 && txt_di_code.Text.Length > 0 && txt_di_procedure.Text.Length > 0 && txt_di_tariff.Text.Length > 0 && txt_di_coverage.Text.Length > 0)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("admin_detail_insurance", c.cnx))
                    {
                        int inttxt_di_id;
                        if (txt_di_id.Text.Length > 0)
                        {
                            inttxt_di_id = Convert.ToInt32(txt_di_id.Text);
                        }
                        else
                        {
                            inttxt_di_id = 0;
                        }

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@di_id", SqlDbType.Int).Value = inttxt_di_id;
                        cmd.Parameters.Add("@i_id", SqlDbType.Int).Value = Convert.ToInt32(txt_i_id.Text);
                        cmd.Parameters.Add("@di_code", SqlDbType.NVarChar).Value = txt_di_code.Text;
                        cmd.Parameters.Add("@di_procedure", SqlDbType.NVarChar).Value = txt_di_procedure.Text;
                        cmd.Parameters.Add("@di_tariff", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_di_tariff.Text);
                        cmd.Parameters.Add("@di_coverage", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_di_coverage.Text);
                        cmd.Parameters.Add("@di_difference", SqlDbType.Decimal).Value = Convert.ToDecimal(txt_di_difference.Text);

                        cmd.Parameters.Add("@u_id", SqlDbType.Int).Value = ActualUser.userid;
                        cmd.Parameters.Add("@di_lu", SqlDbType.Date).Value = ActualUser.hoy;

                        cmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;

                        //cmd.ExecuteNonQuery();

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            //adminpacientemd(Convert.ToInt32(cmd.Parameters["@id"].Value));
                            MessageBox.Show("Se ha realizado la accion", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear2();
                            load_details_insurance_dgv();
                            //txt_i_id.Text = Convert.ToString(cmd.Parameters["@id"].Value);
                            txt_di_code.Select();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo agregar la infromacion. La causa: " + ex.Message, "admindetail_insurance fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos deben contener información, favor verifique y vuelva a intentar. \n\n Si considera que esto es un error del sistema, favor comuníquese con el administrador.", "No se ha podido realizar la acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_di_procedure.Select();
                errors2();
            }
        }

        private void load_insurance_info()
        {
            try
            {
                string query = "SELECT [i_id], [i_name], [i_contract], [i_pss], isnull([i_telephone], '') as i_telephone, isnull([i_email], '') as i_email, [i_status] FROM [dbo].[insurances] where [i_id] = '" + txt_i_id.Text + "'";
                SqlCommand insertion = new SqlCommand(query, c.cnx);
                SqlDataReader leer = insertion.ExecuteReader();
                if (leer.Read() == true)
                {
                    //cb_s_user.SelectedValue = Convert.ToInt32(leer["s_user"]);
                    txt_i_name.Text = Convert.ToString(leer["i_name"]);
                    txt_i_contract.Text = Convert.ToString(leer["i_contract"]);
                    txt_i_pss.Text = Convert.ToString(leer["i_pss"]);
                    txt_i_telephone.Text = Convert.ToString(leer["i_telephone"]);
                    txt_i_email.Text = Convert.ToString(leer["i_email"]);

                    // Para seleccionar o no el cbx de status.
                    if (Convert.ToInt32(leer["i_status"]) == 1)
                    {
                        cbx_i_status.Checked = true;
                        cbx_i_status.Text = "Activo";
                    }
                    else if (Convert.ToInt32(leer["i_status"]) == 0)
                    {
                        cbx_i_status.Checked = false;
                        cbx_i_status.Text = "Inactivo";
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar los datos de la ARS. Razón: " + ex.Message, "Error al cargar la ARS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void load_detail_insurance_info()
        {
            try
            {
                string query = "SELECT [di_id], [i_id], [di_code], [di_procedure], [di_tariff], [di_coverage], [di_difference] FROM [dbo].[detail_insurance] where [di_id] =  '" + txt_di_id.Text + "'";
                SqlCommand insertion = new SqlCommand(query, c.cnx);
                SqlDataReader leer = insertion.ExecuteReader();
                if (leer.Read() == true)
                {
                    //cb_s_user.SelectedValue = Convert.ToInt32(leer["s_user"]);
                    txt_di_code.Text = Convert.ToString(leer["di_code"]);
                    txt_di_procedure.Text = Convert.ToString(leer["di_procedure"]);
                    txt_di_tariff.Text = Convert.ToString(leer["di_tariff"]);
                    txt_di_coverage.Text = Convert.ToString(leer["di_coverage"]);
                    txt_di_difference.Text = Convert.ToString(leer["di_difference"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar los procedimientos de la ARS. Razón: " + ex.Message, "Error al cargar procedimientos de la ARS", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void load_details_insurance_dgv()
        {

            SqlCommand comando = new SqlCommand();

            SqlDataReader dr;
            comando.Connection = c.cnx;


            string query = "SELECT [di_id], [i_id], [di_code], [di_procedure], [di_tariff], [di_coverage], [di_difference] FROM [dbo].[detail_insurance] where [i_id] = '" + txt_i_id.Text + "'";

            comando.CommandText = query;

            comando.CommandType = CommandType.Text;
            DataGridView dgv = dgv_detail_insurance;
            dgv.Rows.Clear();

            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                int renglon = dgv.Rows.Add();

                dgv.Rows[renglon].Cells["di_id"].Value = Convert.ToString(dr.GetInt32(dr.GetOrdinal("di_id")));
                dgv.Rows[renglon].Cells["i_id"].Value = Convert.ToString(dr.GetInt32(dr.GetOrdinal("i_id")));
                dgv.Rows[renglon].Cells["di_code"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("di_code")));
                dgv.Rows[renglon].Cells["di_procedure"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("di_procedure")));
                dgv.Rows[renglon].Cells["di_tariff"].Value = Convert.ToString(dr.GetDecimal(dr.GetOrdinal("di_tariff")));
                dgv.Rows[renglon].Cells["di_coverage"].Value = Convert.ToString(dr.GetDecimal(dr.GetOrdinal("di_coverage")));
                dgv.Rows[renglon].Cells["di_difference"].Value = Convert.ToString(dr.GetDecimal(dr.GetOrdinal("di_difference")));
            }
        }

        private void clear(int did)
        {
            if (did == 0)
            {
                txt_i_id.Clear();
            }

            txt_i_name.Clear();
            txt_i_contract.Clear();
            txt_i_pss.Clear();
            txt_i_telephone.Clear();
            txt_i_email.Clear();

            cbx_i_status.Checked = true;
        }

        private void clear2()
        {
            txt_di_id.Clear();
            txt_di_code.Clear();
            txt_di_procedure.Clear();
            txt_di_tariff.Clear();
            txt_di_coverage.Clear();
            txt_di_difference.Clear();
        }

        private void errors1()
        {
            error.Clear();

            // Datos Generales
          
            if (txt_i_name.Text.Length <= 0) error.SetError(txt_i_name, "No puede estar vacío.");
            if (txt_i_contract.Text.Length <= 0) error.SetError(txt_i_contract, "No puede estar vacío.");
            if (txt_i_pss.Text.Length <= 0) error.SetError(txt_i_pss, "No puede estar vacío.");

        }

        private void errors2()
        {
            error.Clear();

            // Datos Generales

            if (txt_di_code.Text.Length <= 0) error.SetError(txt_di_code, "No puede estar vacío.");
            if (txt_di_procedure.Text.Length <= 0) error.SetError(txt_di_procedure, "No puede estar vacío.");
            if (txt_di_tariff.Text.Length <= 0) error.SetError(txt_di_tariff, "No puede estar vacío.");
            if (txt_di_coverage.Text.Length <= 0) error.SetError(txt_di_coverage, "No puede estar vacío.");

        }

        /********** FIN DE FUNCIONES & METODOS **********/


        private void addinsurance_Load(object sender, EventArgs e)
        {

            if (txt_i_id.Text.Length <= 0)
            {
                cbx_i_status.Checked = true;
                cbx_i_status.Text = "Activo";
            }

            if (txt_i_id.Text.Length > 0)
            {
                load_details_insurance_dgv();
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
                dgv_detail_insurance.Rows.Clear();
            }

            load_details_insurance_dgv();
            buttons();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            clear(0);
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txt_di_tariff_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            //Esta parte va en el evento MouseDown del panel en la parte superior del formulario
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            admininsurance();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            admininsurance();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear(0);
        }

        private void txt_i_id_TextChanged(object sender, EventArgs e)
        {
            buttons();
            load_insurance_info();
            if (txt_i_id.Text.Length > 0)
            {
                load_details_insurance_dgv();
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
                dgv_detail_insurance.Rows.Clear();
            }
        }

        private void txt_i_telephone_Click(object sender, EventArgs e)
        {
            functions fc = new functions();
            fc.starttext(txt_i_telephone);
        }

        private void txt_i_telephone_Enter(object sender, EventArgs e)
        {
            functions fc = new functions();
            fc.starttext(txt_i_telephone);
        }

        private void cbx_i_status_CheckedChanged(object sender, EventArgs e)
        {

            if (cbx_i_status.Checked == true)
            {
                cbx_i_status.Text = "Activo";
            }
            else if (cbx_i_status.Checked == false)
            {
                cbx_i_status.Text = "Inactivo";
            }
        }

        private void btn_clear_di_Click(object sender, EventArgs e)
        {
            clear2();
        }

        private void txt_di_id_TextChanged(object sender, EventArgs e)
        {
            buttons();
            load_detail_insurance_info();
        }

        private void btn_save_di_Click(object sender, EventArgs e)
        {
            admindetail_insurance();
        }

        private void btn_update_di_Click(object sender, EventArgs e)
        {
            admindetail_insurance();
        }

        private void txt_di_coverage_TextChanged(object sender, EventArgs e)
        {
            difference();
        }

        private void txt_di_tariff_TextChanged(object sender, EventArgs e)
        {
            if (txt_di_tariff.Text.Length > 0)
            {
                txt_di_coverage.Enabled = true;
            }
            else
            {
                txt_di_coverage.Enabled = false;
            }
            difference();
        }

        private void dgv_detail_insurance_DoubleClick(object sender, EventArgs e)
        {
            txt_di_id.Text = dgv_detail_insurance.Rows[dgv_detail_insurance.CurrentRow.Index].Cells["di_id"].Value.ToString();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            searchinsurances f = new searchinsurances();
            f.formulario_devolver = true;
            if (f.ShowDialog() == DialogResult.OK)
            {
                clear(0);
                txt_i_id.Text = f.textBox1.Text;
            }
        }
    }
}
