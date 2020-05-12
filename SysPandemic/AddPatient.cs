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
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace SysPandemic
{
    public partial class AddPatient : Form
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

        public AddPatient()
        {
            InitializeComponent();
        }
        //Funcion especifica para movilidad del Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        /********** FUNCIONES & METODOS **********/

        // Para ocultar y mostrar los botones Actualizar y Guardar el Form
        private void buttons()
        {
            if(txt_p_id.Text.Length > 0)
            {
                btn_save.Hide();
                btn_update.Show();
            }
            else if (txt_p_id.Text.Length <= 0)
            {
                btn_save.Show();
                btn_update.Hide();
            }
        }

        // Se verifica que se ha realizado el diagnostico medico, al menos los campos de Combobox
        private void dm_check()
        {
            if(!cb_pm_tmed.SelectedIndex.Equals(-1) && !cb_pm_mica.SelectedIndex.Equals(-1) && !cb_pm_ps.SelectedIndex.Equals(-1) && !cb_pm_diab.SelectedIndex.Equals(-1) && !cb_pm_hep.SelectedIndex.Equals(-1) && !cb_pm_pr.SelectedIndex.Equals(-1) && !cb_pm_pe.SelectedIndex.Equals(-1) && !cb_pm_pa.SelectedIndex.Equals(-1) && !cb_pm_hemo.SelectedIndex.Equals(-1) && !cb_pm_aler.SelectedIndex.Equals(-1))
            {
                adminpaciente();
            }
            else
            {
                MessageBox.Show("No ha realizado el diagnostico medico completo para poder procesar la información, por favor verifique y vuelva a intentar. \n\n Si considera que esto es un error del sistema, favor comuníquese con el administrador.", "Falta Diagnostico Medico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // Funcion que llama y trabaja con el procedimiento almacenado para guardar o actualizar los datos-
        // generales del Paciente
        private void adminpaciente()
        {
            if (!cb_p_sex.SelectedIndex.Equals(-1) && txt_p_name.Text.Length > 0 && dtp_p_bday.Text.Length > 0 && !cb_i_id.SelectedIndex.Equals(-1) && txt_p_address.Text.Length > 0)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("admin_patient", c.cnx))
                    {
                        int inttxt_p_id;
                        if (txt_p_id.Text.Length > 0)
                        {
                            inttxt_p_id = Convert.ToInt32(txt_p_id.Text);
                        }
                        else
                        {
                            inttxt_p_id = 0;
                        }

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@p_id", SqlDbType.Int).Value = inttxt_p_id;
                        cmd.Parameters.Add("@i_id", SqlDbType.Int).Value = Convert.ToInt32(cb_i_id.SelectedValue);
                        cmd.Parameters.Add("@p_name", SqlDbType.NVarChar).Value = txt_p_name.Text;
                        cmd.Parameters.Add("@p_idperson", SqlDbType.NVarChar).Value = txt_p_idperson.Text;
                        cmd.Parameters.Add("@p_bday", SqlDbType.Date).Value = dtp_p_bday.Text;
                        cmd.Parameters.Add("@p_sex", SqlDbType.NVarChar).Value = cb_p_sex.Text;
                        cmd.Parameters.Add("@p_address", SqlDbType.NVarChar).Value = txt_p_address.Text;
                        cmd.Parameters.Add("@p_tel", SqlDbType.NVarChar).Value = txt_p_tel.Text;
                        cmd.Parameters.Add("@p_cel", SqlDbType.NVarChar).Value = txt_p_cel.Text;
                        cmd.Parameters.Add("@p_telwork", SqlDbType.NVarChar).Value = txt_p_telwork.Text;
                        cmd.Parameters.Add("@p_email", SqlDbType.NVarChar).Value = txt_p_email.Text;
                        cmd.Parameters.Add("@p_affiliate", SqlDbType.NVarChar).Value = txt_p_affiliate.Text;

                        cmd.Parameters.Add("@u_id", SqlDbType.Int).Value = ActualUser.userid;
                        cmd.Parameters.Add("@p_lu", SqlDbType.Date).Value = ActualUser.hoy;

                        cmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;


                        //cmd.ExecuteNonQuery();

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                           adminpacientemd(Convert.ToInt32(cmd.Parameters["@id"].Value));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo agregar la infromacion. La causa: " + ex.Message, "adminpaciente try fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los campos: Nombre, Fecha de nacimiento, Sexo y Dirección del Paciente son campos obligatorios, favor verifique y vuelva a intentar. \n\n Si considera que esto es un error del sistema, favor comuníquese con el administrador.", "No se ha podido realizar la acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_p_name.Select();
            }
        }

        // Funcion que llama y trabaja con el procedimiento almacenado para guardar o actualizar los datos-
        // del Diagnostico Medico del Paciente
        private void adminpacientemd(int pid)
        {
            if(pid > 0)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("admin_patient_medical", c.cnx))
                    {
                        int inttxt_pm_id;
                        if (txt_pm_id.Text.Length > 0)
                        {
                            inttxt_pm_id = Convert.ToInt32(txt_pm_id.Text);
                        }
                        else
                        {
                            inttxt_pm_id = 0;
                        }

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@pm_id", SqlDbType.Int).Value = inttxt_pm_id;
                        cmd.Parameters.Add("@p_id", SqlDbType.Int).Value = pid;
                        cmd.Parameters.Add("@pm_tmed", SqlDbType.Int).Value = Convert.ToInt32(cb_pm_tmed.SelectedIndex.ToString());
                        cmd.Parameters.Add("@pm_tmedcom", SqlDbType.NVarChar).Value = txt_pm_tmedcom.Text;
                        cmd.Parameters.Add("@pm_mica", SqlDbType.Int).Value = Convert.ToInt32(cb_pm_mica.SelectedIndex.ToString());
                        cmd.Parameters.Add("@pm_micacom", SqlDbType.NVarChar).Value = txt_pm_micacom.Text;
                        cmd.Parameters.Add("@pm_ps", SqlDbType.Int).Value = Convert.ToInt32(cb_pm_ps.SelectedIndex.ToString());
                        cmd.Parameters.Add("@pm_diab", SqlDbType.Int).Value = Convert.ToInt32(cb_pm_diab.SelectedIndex.ToString());
                        cmd.Parameters.Add("@pm_hep", SqlDbType.Int).Value = Convert.ToInt32(cb_pm_hep.SelectedIndex.ToString());
                        cmd.Parameters.Add("@pm_hepcom", SqlDbType.NVarChar).Value = txt_pm_hepcom.Text;
                        cmd.Parameters.Add("@pm_pr", SqlDbType.Int).Value = Convert.ToInt32(cb_pm_pr.SelectedIndex.ToString());
                        cmd.Parameters.Add("@pm_pe", SqlDbType.Int).Value = Convert.ToInt32(cb_pm_pe.SelectedIndex.ToString());
                        cmd.Parameters.Add("@pm_pecom", SqlDbType.NVarChar).Value = txt_pm_pecom.Text;
                        cmd.Parameters.Add("@pm_pa", SqlDbType.Int).Value = Convert.ToInt32(cb_pm_pa.SelectedIndex.ToString());
                        cmd.Parameters.Add("@pm_pacom", SqlDbType.NVarChar).Value = txt_pm_pacom.Text;
                        cmd.Parameters.Add("@pm_hemo", SqlDbType.Int).Value = Convert.ToInt32(cb_pm_hemo.SelectedIndex.ToString());
                        cmd.Parameters.Add("@pm_aler", SqlDbType.Int).Value = Convert.ToInt32(cb_pm_aler.SelectedIndex.ToString());
                        cmd.Parameters.Add("@pm_alercom", SqlDbType.NVarChar).Value = txt_pm_alercom.Text;
                        cmd.Parameters.Add("@pm_commentary", SqlDbType.NVarChar).Value = txt_pm_commentary.Text;


                        cmd.Parameters.Add("@u_id", SqlDbType.Int).Value = ActualUser.userid;
                        cmd.Parameters.Add("@pm_lu", SqlDbType.Date).Value = ActualUser.hoy;

                        cmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;


                        //cmd.ExecuteNonQuery();

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Se ha realizado la accion", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //limpiar();

                            txt_p_id.Text = pid.ToString();
                            txt_pm_id.Text = Convert.ToString(cmd.Parameters["@id"].Value);

                            if (formulario_devolver == true)
                            {
                                clear(0);
                                this.DialogResult = DialogResult.OK;
                                this.Close();

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo agregar la infromacion. La causa: " + ex.Message, "adminpaciente try fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los datos generales del Paciente han sido guardados, en cambio no se puede proceder a guardar el Diagnostico Medico debido a que la base de datos no cedió ningún ID al próximo procedimiento. Comuníquese con el administrador del sistema.", "No se recibio ID de la DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_p_name.Select();
            }
        }

        // Para llenar el ComboBox de las ARS (Seguros Medicos)
        private void load_insurance()
        {
            try
            {
                string query = "SELECT [i_id], [i_name] FROM [dbo].[insurances] where [i_status] = 1";
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, c.cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                cb_i_id.DisplayMember = "i_name";
                cb_i_id.ValueMember = "i_id";
                cb_i_id.DataSource = dt;

                if (txt_p_id.Text.Length <= 0)
                {
                    cb_i_id.SelectedItem = null;
                }
                else
                {
                    try
                    {
                        string query2 = "SELECT [i_id] FROM [dbo].[patient] where [p_id] =   '" + txt_p_id.Text + "'";
                        SqlCommand insertion = new SqlCommand(query2, c.cnx);
                        SqlDataReader leer = insertion.ExecuteReader();
                        if (leer.Read() == true)
                        {
                            cb_i_id.SelectedValue = Convert.ToString(leer["i_id"]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo seleccionar la ARS (Seguro) del Paciente. Razón: " + ex.Message, "Error al seleccionar la ARS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar las ARS (Seguros). Razón: " + ex.Message, "NO cargaron las ARS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Para llenar el ComboBox de Doctor en el buscador del Historial del Paciente
        private void load_doctors()
        {
            try
            {
                string query = "SELECT [s_id], [s_name] FROM [dbo].[staff] where [s_status] = 1 and [r_id] = 2";
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, c.cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                cb_s_id.DisplayMember = "s_name";
                cb_s_id.ValueMember = "s_id";
                cb_s_id.DataSource = dt;
                cb_s_id.SelectedItem = null;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar los Doctores en la ventana de Historial del Paciente. Razón: " + ex.Message, "NO cargaron los Doctores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cargar los datos de la Informacion General del Paciente
        private void load_patient_info()
        {
            try
            {
                string query = "SELECT [p_id], [i_id], [p_name], [p_idperson], FORMAT(p_bday,'dd/MM/yyyy') as  p_bday, [p_sex], [p_address], [p_tel], [p_cel], [p_telwork], [p_email], [p_affiliate] FROM [dbo].[patient] where [p_id] = '" + txt_p_id.Text + "'";
                SqlCommand insertion = new SqlCommand(query, c.cnx);
                SqlDataReader leer = insertion.ExecuteReader();
                if (leer.Read() == true)
                {
                    // LLENAR LOS TEXTBOX DEL TAP INFORMACION DEL PACIENTE 

                    txt_p_name.Text = Convert.ToString(leer["p_name"]);
                    txt_p_idperson.Text = Convert.ToString(leer["p_idperson"]);
                    dtp_p_bday.Text = Convert.ToString(leer["p_bday"]);
                    txt_p_address.Text = Convert.ToString(leer["p_address"]);
                    txt_p_tel.Text = Convert.ToString(leer["p_tel"]);
                    txt_p_cel.Text = Convert.ToString(leer["p_cel"]);
                    txt_p_telwork.Text = Convert.ToString(leer["p_telwork"]);
                    txt_p_email.Text = Convert.ToString(leer["p_email"]);
                    txt_p_affiliate.Text = Convert.ToString(leer["p_affiliate"]);

                    // LLENAR LOS COMBOBOX DEL TAP INFORMACION DEL PACIENTE 
                    if(Convert.ToString(leer["p_sex"]) == "M")
                    {
                        cb_p_sex.SelectedIndex = 0;
                    }
                    else if (Convert.ToString(leer["p_sex"]) == "F")
                    {
                        cb_p_sex.SelectedIndex = 1;
                    }
                    else
                    {
                        MessageBox.Show("No se consiguio el Sexo del Paciente");
                        cb_p_sex.SelectedIndex = -1;
                    }

                    cb_i_id.SelectedValue = Convert.ToString(leer["i_id"]);

                    // LLENAR LOS TEXTBOX DEL ID DEL PACIENTE EN EL TAP DE DIAGNOSTICO MEDICO
                    txt_mp_p_id.Text = Convert.ToString(leer["p_id"]);
                    txt_mp_p_name.Text = Convert.ToString(leer["p_name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar los datos del Paciente. Razón: " + ex.Message, "Error al cargar el Paciente (Informacion General)", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        // Cargar los datos del Diagnostico Medico del Paciente
        private void load_mp_info()
        {
            try
            {
                string query = "SELECT [pm_id], [p_id], [pm_tmed], [pm_tmedcom], [pm_mica], [pm_micacom], [pm_ps], [pm_diab], [pm_hep], [pm_hepcom], [pm_pr], [pm_pe], [pm_pecom], [pm_pa], [pm_pacom], [pm_hemo], [pm_aler], [pm_alercom], [pm_commentary] FROM [dbo].[patient_medical] where [p_id] = '" + txt_p_id.Text + "'";
                SqlCommand insertion = new SqlCommand(query, c.cnx);
                SqlDataReader leer = insertion.ExecuteReader();
                if (leer.Read() == true)
                {
                    // LLENAR LOS TEXTBOX DEL TAP DIAGNOSTICO MEDICO

                    txt_pm_id.Text = Convert.ToString(leer["pm_id"]);
                    txt_pm_tmedcom.Text = Convert.ToString(leer["pm_tmedcom"]);
                    txt_pm_micacom.Text = Convert.ToString(leer["pm_micacom"]);
                    txt_pm_hepcom.Text = Convert.ToString(leer["pm_hepcom"]);
                    txt_pm_pecom.Text = Convert.ToString(leer["pm_pecom"]);
                    txt_pm_pacom.Text = Convert.ToString(leer["pm_pacom"]);
                    txt_pm_alercom.Text = Convert.ToString(leer["pm_alercom"]);
                    txt_pm_commentary.Text = Convert.ToString(leer["pm_commentary"]);


                    // LLENAR LOS COMBOBOX DEL TAP DIAGNOSTICO MEDICO

                    cb_pm_tmed.SelectedIndex = Convert.ToInt32(leer["pm_tmed"]);
                    cb_pm_mica.SelectedIndex = Convert.ToInt32(leer["pm_mica"]);
                    cb_pm_ps.SelectedIndex = Convert.ToInt32(leer["pm_ps"]);
                    cb_pm_diab.SelectedIndex = Convert.ToInt32(leer["pm_diab"]);
                    cb_pm_hep.SelectedIndex = Convert.ToInt32(leer["pm_hep"]);
                    cb_pm_pr.SelectedIndex = Convert.ToInt32(leer["pm_pr"]);
                    cb_pm_pe.SelectedIndex = Convert.ToInt32(leer["pm_pe"]);
                    cb_pm_pa.SelectedIndex = Convert.ToInt32(leer["pm_pa"]);
                    cb_pm_hemo.SelectedIndex = Convert.ToInt32(leer["pm_hemo"]);
                    cb_pm_aler.SelectedIndex = Convert.ToInt32(leer["pm_aler"]);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar los datos del Diagnostico Medico del Paciente. Razón: " + ex.Message, "Error al cargar el Paciente (Diagnostico Medico)", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        // Cargar los datos del Historial del Paciente en el DataGridView
        private void load_ph_dgv()
        {
            string buscar = "";

            if(cbx_ph_date.Checked == true)
            {
                if(!cb_s_id.SelectedIndex.Equals(-1))
                {
                    buscar = " and [ph_activity] like '%" + txt_ph_activity.Text + "%' and [ph_tooth] like '%" + txt_ph_tooth.Text + "%' and [ph_date] = '" + dtp_ph_date.Text + "' and ph.s_id = '" + cb_s_id.SelectedValue + "' order by ph.ph_date desc ";
                }
                else
                {
                    buscar = " and [ph_activity] like '%" + txt_ph_activity.Text + "%' and [ph_tooth] like '%" + txt_ph_tooth.Text + "%' and [ph_date] = '" + dtp_ph_date.Text + "' order by ph.ph_date desc ";
                }
            }
            else
            {
                if (!cb_s_id.SelectedIndex.Equals(-1))
                {
                    buscar = " and [ph_activity] like '%" + txt_ph_activity.Text + "%' and [ph_tooth] like '%" + txt_ph_tooth.Text + "%'  and ph.s_id = '" + cb_s_id.SelectedValue + "' order by ph.ph_date desc ";
                }
                else
                {
                    buscar = " and [ph_activity] like '%" + txt_ph_activity.Text + "%' and [ph_tooth] like '%" + txt_ph_tooth.Text + "%' order by ph.ph_date desc ";
                }
            }

            SqlCommand comando = new SqlCommand();

            SqlDataReader dr;
            comando.Connection = c.cnx;


            string query = "SELECT [ph_id], [p_id], s.s_name, [ph_activity], [ph_tooth], [ph_qtypay], [ph_date], u.u_user, [ph_lu] FROM [dbo].[patient_history] as ph inner join [dbo].[staff] as s on s.s_id = ph.s_id inner join [dbo].[users] as u on u.u_id = ph.u_id where [ph_id] = '"+txt_p_id.Text+"' "+buscar;

            comando.CommandText = query;

            comando.CommandType = CommandType.Text;
            DataGridView dgv = dgv_patient_history;
            dgv.Rows.Clear();

            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                int renglon = dgv.Rows.Add();

                dgv.Rows[renglon].Cells["ph_id"].Value = Convert.ToString(dr.GetInt32(dr.GetOrdinal("ph_id")));
                dgv.Rows[renglon].Cells["ph_activity"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("ph_activity")));
                dgv.Rows[renglon].Cells["ph_tooth"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("ph_tooth")));
                dgv.Rows[renglon].Cells["ph_date"].Value = Convert.ToString(dr.GetDateTime(dr.GetOrdinal("ph_date")).ToString("dd/MM/yyyy"));
                dgv.Rows[renglon].Cells["s_name"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("s_name")));
                dgv.Rows[renglon].Cells["ph_qtypay"].Value = "RD$ " + Convert.ToString(dr.GetDecimal(dr.GetOrdinal("ph_qtypay")));
                dgv.Rows[renglon].Cells["p_id"].Value = Convert.ToString(dr.GetInt32(dr.GetOrdinal("p_id")));

                dgv.Rows[renglon].Cells["u_user"].Value = Convert.ToString(dr.GetString(dr.GetOrdinal("u_user")));
                dgv.Rows[renglon].Cells["ph_lu"].Value = Convert.ToString(dr.GetDateTime(dr.GetOrdinal("ph_lu")).ToString("dd/MM/yyyy"));

            }
        }

        // Limipiar todo el Form
        private void clear(int pid)
        {
            if(pid == 0)
            {
                txt_p_id.Clear();
            }

            txt_p_name.Clear();
            txt_p_idperson.Clear();
            txt_p_address.Clear();
            txt_p_tel.Clear();
            txt_p_cel.Clear();
            txt_p_telwork.Clear();
            txt_p_email.Clear();
            txt_p_affiliate.Clear();
            txt_pm_id.Clear();
            txt_mp_p_id.Clear();
            txt_mp_p_name.Clear();
            txt_pm_tmedcom.Clear();
            txt_pm_hepcom.Clear();
            txt_pm_pecom.Clear();
            txt_pm_pacom.Clear();
            txt_pm_micacom.Clear();
            txt_pm_alercom.Clear();
            txt_pm_commentary.Clear();
            txt_ph_id.Clear();
            txt_ph_activity.Clear();
            txt_ph_tooth.Clear();

            dtp_p_bday.Text = DateTime.Today.ToString("dd-MM-yyyy");
            dtp_ph_date.Text = DateTime.Today.ToString("dd/MM/yyyy");

            cb_p_sex.SelectedIndex = -1;
            cb_i_id.SelectedIndex = -1;
            cb_s_id.SelectedIndex = -1;
            cb_pm_tmed.SelectedIndex = -1;
            cb_pm_mica.SelectedIndex = -1;
            cb_pm_ps.SelectedIndex = -1;
            cb_pm_diab.SelectedIndex = -1;
            cb_pm_hep.SelectedIndex = -1;
            cb_pm_pr.SelectedIndex = -1;
            cb_pm_pe.SelectedIndex = -1;
            cb_pm_pa.SelectedIndex = -1;
            cb_pm_hemo.SelectedIndex = -1;
            cb_pm_aler.SelectedIndex = -1;

            cbx_ph_date.Checked = false;

            dgv_patient_history.Rows.Clear();
        }

        // Seleccionar todos los NO en Diagnostico Medico
        private void allnot()
        {
            cb_pm_tmed.SelectedIndex = 0;
            cb_pm_mica.SelectedIndex = 0;
            cb_pm_ps.SelectedIndex = 0;
            cb_pm_diab.SelectedIndex = 0;
            cb_pm_hep.SelectedIndex = 0;
            cb_pm_pr.SelectedIndex = 0;
            cb_pm_pe.SelectedIndex = 0;
            cb_pm_pa.SelectedIndex = 0;
            cb_pm_hemo.SelectedIndex = 0;
            cb_pm_aler.SelectedIndex = 0;
        }

        /********** FIN DE FUNCIONES & METODOS **********/

        private void AddPatient_Load(object sender, EventArgs e)
        {
            load_insurance();
            load_doctors();
            buttons();

            if (txt_p_id.Text.Length > 0)
            {
                gb_ph.Enabled = true;
            }
            else
            {
                gb_ph.Enabled = false;
            }
            dtp_ph_date.Enabled = false;
        }

        private void savepatient_txt_Click(object sender, EventArgs e)
        {
            DateTime ayer = DateTime.Now.Date;
            ayer = ayer.AddDays(-1);

            if (dtp_p_bday.Value.Date <= ayer)
            {
                dm_check();
            }
            else
            {
                MessageBox.Show("No puede agregar al Paciente, debido a que la fecha de nacimiento esta mal digitada. Favor verifique y velva a intentar.", "Error en la Fecha de nacimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp_p_bday.Select();
            }
        }

        private void updatepatient_btn_Click(object sender, EventArgs e)
        {
            DateTime ayer = DateTime.Now.Date;
            ayer = ayer.AddDays(-1);

            if (dtp_p_bday.Value.Date <= ayer)
            {
                dm_check();
                clear(0);
                this.Close();
            }
            else
            {
                MessageBox.Show("No puede agregar al Paciente, debido a que la fecha de nacimiento esta mal digitada. Favor verifique y velva a intentar.", "Error en la Fecha de nacimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp_p_bday.Select();
            }
        }

        private void clearform_btn_Click(object sender, EventArgs e)
        {
            clear(0);
        }


        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void telpatient_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void celpatient_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tworkpatient_txt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void searchhistory_txt_TextChanged(object sender, EventArgs e)
        {
            load_ph_dgv();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            allnot();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //Esta parte va en el evento MouseDown del panel en la parte superior del formulario
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            searchpatient f = new searchpatient();
            f.formulario_devolver = true;
            if (f.ShowDialog() == DialogResult.OK)
            {
                clear(0);
                txt_p_id.Text = f.textBox1.Text;
            }
        }

        private void txt_p_id_TextChanged(object sender, EventArgs e)
        {
            clear(1);
            load_patient_info();
            load_mp_info();
            if(txt_p_id.Text.Length > 0)
            {
                gb_ph.Enabled = true;
                load_ph_dgv();
            }
            else
            {
                gb_ph.Enabled = false;
            }
            
            buttons();
        }

        private void txt_p_idperson_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_p_tel_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_p_cel_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_p_telwork_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_ph_activity_TextChanged(object sender, EventArgs e)
        {
            load_ph_dgv();
        }

        private void txt_ph_tooth_TextChanged(object sender, EventArgs e)
        {
            load_ph_dgv();
        }

        private void dtp_ph_date_ValueChanged(object sender, EventArgs e)
        {
            load_ph_dgv();
        }

        private void cbx_ph_date_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_ph_date.Checked)
            {
                dtp_ph_date.Enabled = true;
            }
            else
            {
                dtp_ph_date.Enabled = false;
            }
            load_ph_dgv();
        }

        private void cb_s_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_ph_dgv();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            load_ph_dgv();
        }

        private void txt_p_idperson_Click(object sender, EventArgs e)
        {
            functions fc = new functions();
            fc.starttext(txt_p_idperson);
        }

        private void txt_p_tel_Click(object sender, EventArgs e)
        {
            functions fc = new functions();
            fc.starttext(txt_p_tel);
        }

        private void txt_p_cel_Click(object sender, EventArgs e)
        {
            functions fc = new functions();
            fc.starttext(txt_p_cel);
        }

        private void txt_p_idperson_Enter(object sender, EventArgs e)
        {
            functions fc = new functions();
            fc.starttext(txt_p_idperson);
        }

        private void txt_p_tel_Enter(object sender, EventArgs e)
        {
            functions fc = new functions();
            fc.starttext(txt_p_tel);
        }

        private void txt_p_cel_Enter(object sender, EventArgs e)
        {
            functions fc = new functions();
            fc.starttext(txt_p_cel);
        }

        private void txt_p_telwork_Enter(object sender, EventArgs e)
        {
            functions fc = new functions();
            fc.starttext(txt_p_telwork);
        }

        private void label26_MouseDown(object sender, MouseEventArgs e)
        {
            //Esta parte va en el evento MouseDown del panel en la parte superior del formulario
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            //Esta parte va en el evento MouseDown del panel en la parte superior del formulario
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
