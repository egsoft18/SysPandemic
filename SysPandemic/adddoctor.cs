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
    public partial class adddoctor : Form
    {
        /********** GLOSARIO **********/
        // txt = TextBox or MaskedTextBox
        // cb = ComboBox
        // btn = Button
        // cbx = CheckBox
        // dtp = DateTimePicker
        // dgv = DataGridView
        // gb = GroupBox


        SqlCommand cmd;
        //SqlDataReader dr;

        OpenDB c = new OpenDB();

        public bool formulario_devolver = false;

        public adddoctor()
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
            if (txt_s_id.Text.Length > 0)
            {
                btn_save.Hide();
                btn_update.Show();
            }
            else if (txt_s_id.Text.Length <= 0)
            {
                btn_save.Show();
                btn_update.Hide();
            }
        }

        private void user_check() // para validad el usuario cambiar codigo.
        {
            try
            {
                // CON ESTE COMANDO VERIFICAMOS QUE EL USUARIO ASIGNADO NO ESTE OCUPADO
                cmd = new SqlCommand("SELECT [s_id] FROM [dbo].[staff] where s_user = '"+cb_s_user.SelectedValue+"' ", c.cnx);
                DataSet ds = new DataSet();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                ds.Tables.Add(dt);

                if(dt.Rows.Count > 0) //El Usuario esta ocupado
                {
                    if (txt_s_id.Text.Length > 0) //Validamos que se este actualizando
                    {
                        // SI EL USUARIO SELECIONADO ESTA OCUPADO, VALIDAMOS QUE NO SI ES EL EL MISMO USUARIO QUE ESTAMOS TRABAJANDO
                        cmd = new SqlCommand("SELECT [s_id] FROM [dbo].[staff] where s_id = '" + txt_s_id.Text + "' and s_user = '" + cb_s_user.SelectedValue + "' ", c.cnx);
                        DataSet ds2 = new DataSet();
                        SqlDataAdapter ad2 = new SqlDataAdapter(cmd);
                        DataTable dt2 = new DataTable();
                        ad2.Fill(dt2);
                        ds2.Tables.Add(dt2);
                        if (dt2.Rows.Count <= 0)
                        {
                            // EL USUARIO ESTA OCUPADO Y NO ES CON EL STAFF QUE ESTAMOS TRABAJANDO
                            MessageBox.Show("NO se puede asignar el usuario del sistema seleccionado debido a que este ya cuenta con otro personal del consultorio asignado. \n\n Si considera que esto es un error del sistema, favor comuníquese con el Administrador del Sistema.", "Usuario del Sistema duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // EL USUARIO ESTA OCUPADO Y PERO ES POR EL STAFF QUE ESTAMOS TRABAJANDO
                            adminstaff();
                        }
                    }
                    else // Como se encontro el usuario esta ocupado, pero no estamos actualizando rechaza
                    {
                        MessageBox.Show("NO se puede asignar el usuario del sistema seleccionado debido a que este ya cuenta con otro personal del consultorio asignado. \n\n Si considera que esto es un error del sistema, favor comuníquese con el Administrador del Sistema.", "Usuario del Sistema duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (dt.Rows.Count <= 0) // No se encontro 
                {
                    // SI EL USUARIO SELECIONADO NO ESTA OCUPADO
                    adminstaff();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo validar si el usario esta ocupado. Razón; " + ex.Message, "Error en validar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void adminstaff()
        {
            if (!cb_s_user.SelectedIndex.Equals(-1) && txt_s_name.Text.Length > 0 && txt_s_idpersons.Text.Length > 0 && !cb_s_sex.SelectedIndex.Equals(-1) && txt_s_address.Text.Length > 0)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("admin_staff", c.cnx))
                    {
                        int inttxt_s_id;
                        if (txt_s_id.Text.Length > 0)
                        {
                            inttxt_s_id = Convert.ToInt32(txt_s_id.Text);
                        }
                        else
                        {
                            inttxt_s_id = 0;
                        }

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("s_id", SqlDbType.Int).Value = inttxt_s_id;
                        cmd.Parameters.Add("s_user", SqlDbType.Int).Value = Convert.ToInt32(cb_s_user.SelectedValue);
                        cmd.Parameters.Add("r_id", SqlDbType.Int).Value = 2;  // < ---- CAMBIAR SI EL ID DE DOCTORES EN LA TABLA DE ROLES NO ES 2
                        cmd.Parameters.Add("s_name", SqlDbType.NVarChar).Value = txt_s_name.Text;
                        cmd.Parameters.Add("s_sex", SqlDbType.NVarChar).Value = cb_s_sex.Text;
                        cmd.Parameters.Add("s_idpersons", SqlDbType.NVarChar).Value = txt_s_idpersons.Text;
                        cmd.Parameters.Add("s_address", SqlDbType.NVarChar).Value = txt_s_address.Text;
                        cmd.Parameters.Add("s_tel", SqlDbType.NVarChar).Value = txt_s_tel.Text;
                        cmd.Parameters.Add("s_cel", SqlDbType.NVarChar).Value = txt_s_cel.Text;
                        decimal salary = 0;
                        if(txt_s_salary.Text.Length > 0)
                        {
                            salary = Convert.ToDecimal(txt_s_salary.Text);
                        }
                        cmd.Parameters.Add("s_salary", SqlDbType.Decimal).Value = salary;
                        decimal procent = 0;
                        if (txt_s_doctorprocent.Text.Length > 0)
                        {
                            procent = Convert.ToDecimal(txt_s_doctorprocent.Text);
                        }
                        cmd.Parameters.Add("s_doctorprocent", SqlDbType.Decimal).Value = procent;
                        int status = 1;
                        if(cbx_s_status.Checked == true)
                        {
                            status = 1;
                        }
                        else
                        {
                            status = 0;
                        }
                        cmd.Parameters.Add("s_status", SqlDbType.Int).Value = status;

                        cmd.Parameters.Add("u_id", SqlDbType.Int).Value = ActualUser.userid;
                        cmd.Parameters.Add("s_lu", SqlDbType.Date).Value = ActualUser.hoy;

                        cmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;


                        //cmd.ExecuteNonQuery();

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Se ha realizado la accion", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //clear(0);
                            txt_s_id.Text = Convert.ToString(cmd.Parameters["@id"].Value);
                            txt_s_name.Select();

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
                    MessageBox.Show("No se pudo agregar la infromacion. La causa: " + ex.Message, "adminstaff try fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los campos: Usuario del sistema, Nombre, Cedula,  Sexo y Dirección del Doctor son campos obligatorios, favor verifique y vuelva a intentar. \n\n Si considera que esto es un error del sistema, favor comuníquese con el administrador.", "No se ha podido realizar la acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_s_name.Select();
            }
        }

        private void load_users()
        {
            try
            {
                string query = "SELECT [u_id], [u_user] FROM [dbo].[users] where u_status = 1";
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, c.cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                cb_s_user.DisplayMember = "u_user";
                cb_s_user.ValueMember = "u_id";
                cb_s_user.DataSource = dt;

                if (txt_s_id.Text.Length <= 0)
                {
                    cb_s_user.SelectedItem = null;
                }
                else
                {
                    try
                    {
                        string query2 = "SELECT [s_user] FROM [dbo].[staff] where [s_id] = '" + txt_s_id.Text + "'";
                        SqlCommand insertion = new SqlCommand(query2, c.cnx);
                        SqlDataReader leer = insertion.ExecuteReader();
                        if (leer.Read() == true)
                        {
                            cb_s_user.SelectedValue = Convert.ToString(leer["s_user"]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo seleccionar el Usuario del Sistema del Doctor. Razón: " + ex.Message, "Error al seleccionar el Usuario del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar las ARS (Seguros). Razón: " + ex.Message, "NO cargaron las ARS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_staff_info()
        {
            try
            {
                string query = "SELECT  [s_id], [s_user], [s_name], [s_sex], [s_idpersons], [s_address], [s_tel], [s_cel], [s_salary], [s_doctorprocent], [s_status] FROM [dbo].[staff] where [s_id] = '" + txt_s_id.Text + "'";
                SqlCommand insertion = new SqlCommand(query, c.cnx);
                SqlDataReader leer = insertion.ExecuteReader();
                if (leer.Read() == true)
                {
                    //cb_s_user.SelectedValue = Convert.ToInt32(leer["s_user"]);
                    txt_s_name.Text = Convert.ToString(leer["s_name"]);
                    txt_s_idpersons.Text = Convert.ToString(leer["s_idpersons"]);
                    txt_s_address.Text = Convert.ToString(leer["s_address"]);
                    txt_s_tel.Text = Convert.ToString(leer["s_tel"]);
                    txt_s_cel.Text = Convert.ToString(leer["s_cel"]);
                    txt_s_salary.Text = Convert.ToString(leer["s_salary"]);
                    txt_s_doctorprocent.Text = Convert.ToString(leer["s_doctorprocent"]);
                    
                    // Para seleccionar o no el cbx de status.
                    if (Convert.ToInt32(leer["s_status"]) == 1)
                    {
                        cbx_s_status.Checked = true;
                        cbx_s_status.Text = "Activo";
                    }
                    else if (Convert.ToInt32(leer["s_status"]) == 0)
                    {
                        cbx_s_status.Checked = false;
                        cbx_s_status.Text = "Inactivo";
                    }

                    // Seleccionar el sexo del Doctor.
                    if (Convert.ToString(leer["s_sex"]) == "M")
                    {
                        cb_s_sex.SelectedIndex = 0;
                    }
                    else if (Convert.ToString(leer["p_sex"]) == "F")
                    {
                        cb_s_sex.SelectedIndex = 1;
                    }
                    else
                    {
                        MessageBox.Show("No se consiguio el Sexo del Doctor");
                        cb_s_sex.SelectedIndex = -1;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar los datos del Paciente. Razón: " + ex.Message, "Error al cargar el Paciente (Informacion General)", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void clear(int did)
        {
            if (did == 0)
            {
                txt_s_id.Clear();
            }

            txt_s_name.Clear();
            txt_s_idpersons.Clear();
            txt_s_address.Clear();
            txt_s_tel.Clear();
            txt_s_cel.Clear();
            txt_s_salary.Clear();
            txt_s_doctorprocent.Clear();

            cb_s_user.SelectedIndex = -1;
            cb_s_sex.SelectedIndex = -1;

            cbx_s_status.Checked = true;

        }

        /********** FIN DE FUNCIONES & METODOS **********/

        private void adddoctor_Load(object sender, EventArgs e)
        {
            if(txt_s_id.Text.Length <= 0)
            {
                cbx_s_status.Checked = true;
                cbx_s_status.Text = "Activo";
            }

            load_users();
            buttons();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            user_check();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            user_check();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear(0);
        }

        private void txt_s_id_TextChanged(object sender, EventArgs e)
        {
            load_staff_info();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clear(0);
            this.Close();
        }

        private void txt_s_idpersons_Click(object sender, EventArgs e)
        {
            functions fc = new functions();
            fc.starttext(txt_s_idpersons);
        }

        private void txt_s_tel_KeyDown(object sender, KeyEventArgs e)
        {
            functions fc = new functions();
            fc.starttext(txt_s_tel);
        }

        private void txt_s_cel_Click(object sender, EventArgs e)
        {
            functions fc = new functions();
            fc.starttext(txt_s_cel);
        }

        private void cbx_s_status_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_s_status.Checked == true)
            {
                cbx_s_status.Text = "Activo";
            }
            else if (cbx_s_status.Checked == false)
            {
                cbx_s_status.Text = "Inactivo";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //searchdoctors f = new searchdoctors();
            //f.formulario_devolver = true;
            //if (f.ShowDialog() == DialogResult.OK)
            //{
            //    clear(0);
            //    txt_s_id.Text = f.textBox1.Text;
            //}
        }
    }
}
