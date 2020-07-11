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
    public partial class addappointment : Form
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

        public addappointment()
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
            if (txt_dm_id.Text.Length > 0)
            {
                btn_save.Hide();
                btn_update.Show();
            }
            else if (txt_dm_id.Text.Length <= 0)
            {
                btn_save.Show();
                btn_update.Hide();
            }
            int status = 0;
            if (txt_dm_status.Text.Length > 0)
            {
                status = Convert.ToInt32(txt_dm_status.Text);
            }

            if (status == 1)
            {
                btn_take_turn.Show();
                btn_attended.Hide();
            }
            else if (status == 2)
            {
                btn_take_turn.Hide();
                btn_attended.Show();
            }
            else
            {
                btn_take_turn.Hide();
                btn_attended.Hide();
            }
        }

        private void appointment_check(string condition) // para validar las distintas condicionales antes de agregar o actualizar una Visita
        {
            if (cb_s_id.SelectedIndex.Equals(-1))
            {
                errors();
            }
            else
            {
                try
                {
                    // CON ESTE COMANDO VERIFICAMOS QUE Doctor este activo
                    cmd = new SqlCommand("SELECT [s_id] FROM [dbo].[staff] where s_id = '" + cb_s_id.SelectedValue + "' and [s_status] = 1", c.cnx);
                    DataSet ds = new DataSet();
                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    ds.Tables.Add(dt);

                    if (dt.Rows.Count > 0) //El Doctor esta activo
                    {
                        // Verificamos que el doctor no tenga el momento de la visita ocupado   
                        DateTime dat = DateTime.Parse(dtp_dm_date2.Text);

                        cmd = new SqlCommand("SELECT * FROM [dbo].[datem] where [s_id] = '" + cb_s_id.SelectedValue + "' and [dm_date] = '" + Convert.ToDateTime(dtp_dm_date1.Text).ToString("yyyy/MM/dd") + " " + dat.ToString("HH:mm") + "'", c.cnx);
                        DataSet ds2 = new DataSet();
                        SqlDataAdapter ad2 = new SqlDataAdapter(cmd);
                        DataTable dt2 = new DataTable();
                        ad2.Fill(dt2);
                        ds2.Tables.Add(dt2);
                        if (dt2.Rows.Count <= 0)
                        {
                            // No hay Visitas con el Doctor a el momento citado
                            adminappointment(condition);
                            //MessageBox.Show("No hay nada");
                        }
                        else
                        {
                            // Verificamos si la visita encontrada es la misma que se esta editando                     
                            cmd = new SqlCommand("SELECT * FROM [dbo].[datem] where [s_id] = '" + cb_s_id.SelectedValue + "' and [dm_id] = '" + txt_dm_id.Text + "' and [dm_date] = '" + Convert.ToDateTime(dtp_dm_date1.Text).ToString("yyyy/MM/dd") + " " + dat.ToString("HH:mm") + "'", c.cnx);
                            DataSet ds3 = new DataSet();
                            SqlDataAdapter ad3 = new SqlDataAdapter(cmd);
                            DataTable dt3 = new DataTable();
                            ad3.Fill(dt3);
                            ds3.Tables.Add(dt3);
                            if (dt3.Rows.Count > 0)
                            {
                                // No hay Visitas con el Doctor a el momento citado
                                adminappointment(condition);
                                //MessageBox.Show("Es el mismo que se esta Editando");
                            }
                            else
                            {
                                // EL USUARIO ESTA OCUPADO Y PERO ES POR EL STAFF QUE ESTAMOS TRABAJANDO
                                MessageBox.Show("No se puede agendar la Visita debido a que el Doctor seleccionado ya cuenta con una Visita con los datos seleccionados.", "No se puede agregar la Visita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else if (dt.Rows.Count <= 0) // El Doctor no esta activo
                    {
                        MessageBox.Show("No se puede agendar la Visita debido a que el Doctor seleccionado no se encuentra activo.", "No se puede agregar la Visita", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo validar si la Visita. Razón; " + ex.Message, "Error en validar la Visita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }

        private void adminappointment(string condition)
        {
            if (txt_p_id.Text.Length > 0 && !cb_s_id.SelectedIndex.Equals(-1) && dtp_dm_date1.Text.Length > 0 && dtp_dm_date2.Text.Length > 0)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("admin_datem", c.cnx))
                    {
                        int inttxt_dm_id;
                        if (txt_dm_id.Text.Length > 0)
                        {
                            inttxt_dm_id = Convert.ToInt32(txt_dm_id.Text);
                        }
                        else
                        {
                            inttxt_dm_id = 0;
                        }

                        int turn = 0;
                        if (txt_dm_turn.Text.Length > 0)
                        {
                            turn = Convert.ToInt32(txt_dm_turn.Text);
                        }

                        DateTime dt = DateTime.Parse(dtp_dm_date2.Text);

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("dm_id", SqlDbType.Int).Value = inttxt_dm_id;
                        cmd.Parameters.Add("p_id", SqlDbType.Int).Value = Convert.ToInt32(txt_p_id.Text);
                        cmd.Parameters.Add("s_id", SqlDbType.Int).Value = Convert.ToInt32(cb_s_id.SelectedValue);
                        cmd.Parameters.Add("dm_turn", SqlDbType.Int).Value = turn;
                        cmd.Parameters.Add("dm_date", SqlDbType.DateTime).Value = Convert.ToDateTime(dtp_dm_date1.Text).ToString("dd/MM/yyyy") + " " + dt.ToString("HH:mm");
                        cmd.Parameters.Add("dm_status", SqlDbType.NVarChar).Value = 1;

                        cmd.Parameters.Add("u_id", SqlDbType.Int).Value = ActualUser.userid;
                        cmd.Parameters.Add("dm_lu", SqlDbType.Date).Value = ActualUser.hoy;

                        cmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;


                        //cmd.ExecuteNonQuery();

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Se ha realizado la accion", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //clear(0);
                            txt_dm_id.Text = Convert.ToString(cmd.Parameters["@id"].Value);
                            //txt_dm_name.Select();
                            if(condition != "t")
                            {
                                clear();
                                if (formulario_devolver == true)
                                {
                                    clear();
                                    this.DialogResult = DialogResult.OK;
                                    this.Close();

                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo agregar la infromacion. La causa: " + ex.Message, "adminappointment try fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los campos: ID Paciente, Doctor, Fecha y Hora son campos obligatorios, favor verifique y vuelva a intentar. \n\n Si considera que esto es un error del sistema, favor comuníquese con el administrador.", "No se ha podido realizar la acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errors();
                //txt_p_name.Select();
            }
        }

        private void adminturn()
        {
            try
            {
                appointment_check("t");
                using (SqlCommand cmd = new SqlCommand("admin_turn", c.cnx))
                {
                    int inttxt_dm_id;
                    if (txt_dm_id.Text.Length > 0)
                    {
                        inttxt_dm_id = Convert.ToInt32(txt_dm_id.Text);
                    }
                    else
                    {
                        inttxt_dm_id = 0;
                    }
                    DateTime dt = DateTime.Parse(dtp_dm_date2.Text);
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("dm_id", SqlDbType.Int).Value = inttxt_dm_id;
                    cmd.Parameters.Add("s_id", SqlDbType.Int).Value = Convert.ToInt32(cb_s_id.SelectedValue);
                    cmd.Parameters.Add("dm_date", SqlDbType.DateTime).Value = Convert.ToDateTime(dtp_dm_date1.Text).ToString("dd/MM/yyyy");

                    cmd.Parameters.Add("u_id", SqlDbType.Int).Value = ActualUser.userid;
                    cmd.Parameters.Add("dm_lu", SqlDbType.Date).Value = ActualUser.hoy;
                    //cmd.ExecuteNonQuery();
                    
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        //MessageBox.Show("Se ha realizado la accion", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        clear();
                        if (formulario_devolver == true)
                        {
                            clear();
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                }

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar la infromacion. La causa: " + ex.Message, "adminturn try fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void attended()
        {
            if (txt_dm_status.Text == "2")
            {
                try
                {
                    SqlCommand insertion = new SqlCommand("Update [dbo].[datem] set [dm_status] = '3', [dm_turn] = 0, [u_id] = '" + ActualUser.userid + "', [dm_lu] = '" + ActualUser.hoy + "' where [dm_id] = '" + txt_dm_id.Text + "'", c.cnx);
                    if (insertion.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Se ha pasado la Visita a estado Atendida", "Visita Atendida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.Close();
                        if (formulario_devolver == true)
                        {
                            clear();
                            this.DialogResult = DialogResult.OK;
                            this.Close();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo realizar la accion. La causa: " + ex.Message, "Error al cambiar a Realizada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La Visita no se encuentra en un estado en el cual pueda pasar a ser Atendida, favor verifique que el estado de la Visita sea Asistida y que la misma ya tenga un turno. \n\nSi el problema persiste, favor contacte al administrador del sistema.", "Error al pasar a Atendida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cancel()
        {
            if (txt_dm_status.Text == "1")
            {
                try
                {
                    SqlCommand insertion = new SqlCommand("Update [dbo].[datem] set [dm_status] = '0', [dm_turn] = 0, [u_id] = '" + ActualUser.userid + "', [dm_lu] = '" + ActualUser.hoy + "' where [dm_id] = '" + txt_dm_id.Text + "'", c.cnx);
                    if (insertion.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Se ha pasado la Visita a estado Atendida", "Visita Atendida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo realizar la accion. La causa: " + ex.Message, "Error al cambiar a Realizada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La Visita no se encuentra en un estado en el cual pueda pasar a ser Cancelada, favor verifique que el estado de la Visita sea Agendada. \n\nSi el problema persiste, favor contacte al administrador del sistema.", "Error al pasar a Atendida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_doctors()
        {
            try
            {
                string query = "SELECT [s_id], [s_name] FROM [dbo].[staff] where [r_id] = 2"; /* <----------- Modificar en caso de que los doctores cambien de 2 */
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, c.cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                cb_s_id.DisplayMember = "s_name";
                cb_s_id.ValueMember = "s_id";
                cb_s_id.DataSource = dt;

                if (txt_dm_id.Text.Length <= 0)
                {
                    cb_s_id.SelectedItem = null;
                }
                else
                {
                    try
                    {
                        string query2 = "SELECT [s_id] FROM [dbo].[datem] where [dm_id] =  '" + txt_dm_id.Text + "'";
                        SqlCommand insertion = new SqlCommand(query2, c.cnx);
                        SqlDataReader leer = insertion.ExecuteReader();
                        if (leer.Read() == true)
                        {
                            cb_s_id.SelectedValue = Convert.ToString(leer["s_id"]);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo seleccionar el Doctor. Razón: " + ex.Message, "Error al seleccionar el Doctor", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar los Doctores. Razón: " + ex.Message, "NO cargaron los Doctores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_patient_info()
        {
            try
            {
                string query = "SELECT [p_id], i.i_name, [p_name], [p_idperson], [p_affiliate] FROM [dbo].[patient] as p inner join [dbo].[insurances] as i on i.i_id = p.i_id where [p_id] = '" + txt_p_id.Text + "'";
                SqlCommand insertion = new SqlCommand(query, c.cnx);
                SqlDataReader leer = insertion.ExecuteReader();
                if (leer.Read() == true)
                {
                    //cb_s_user.SelectedValue = Convert.ToInt32(leer["s_user"]);
                    txt_p_name.Text = Convert.ToString(leer["p_name"]);
                    txt_p_idpersons.Text = Convert.ToString(leer["p_idperson"]);
                    txt_p_affiliate.Text = Convert.ToString(leer["p_affiliate"]);
                    txt_i_name.Text = Convert.ToString(leer["i_name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar los datos del Paciente. Razón: " + ex.Message, "Error al cargar el Paciente (Datos del Paciente)", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void load_appointment_info()
        {
            try
            {
                string query = "SELECT [dm_id], [p_id], [s_id], [dm_turn], [dm_date], [dm_status] FROM [dbo].[datem] where dm_id =  '" + txt_dm_id.Text + "'";
                SqlCommand insertion = new SqlCommand(query, c.cnx);
                SqlDataReader leer = insertion.ExecuteReader();
                if (leer.Read() == true)
                {
                    txt_p_id.Text = Convert.ToString(leer["p_id"]);
                    cb_s_id.SelectedValue = Convert.ToInt32(leer["s_id"]);
                    txt_dm_turn.Text = Convert.ToString(leer["dm_turn"]);
                    dtp_dm_date1.Text = Convert.ToDateTime(leer["dm_date"]).ToString("dd/MM/yyyy");
                    dtp_dm_date2.Text = Convert.ToDateTime(leer["dm_date"]).ToString("HH:mm");
                    txt_dm_status.Text = Convert.ToString(leer["dm_status"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar los datos de la Visita. Razón: " + ex.Message, "Error al cargar la Visita", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void clear()
        {
            txt_p_id.Clear();
            
            txt_p_name.Clear();
            txt_p_idpersons.Clear();
            txt_i_name.Clear();
            txt_p_affiliate.Clear();

            txt_dm_id.Clear();
            txt_dm_turn.Clear();
            txt_dm_status.Clear();
            cb_s_id.SelectedIndex = -1;

            dtp_dm_date1.Text = DateTime.Today.ToString("dd/MM/yyyy");
            dtp_dm_date2.Text = DateTime.Now.ToString("HH:mm");
        }

        private void errors()
        {
            error.Clear();

            // Datos Generales            
            if (txt_p_id.Text.Length <= 0)
            {
                error.SetError(txt_p_id, "No puede estar vacío.");
                dtp_dm_date2.Select();
            }
            if (cb_s_id.SelectedIndex.Equals(-1))
            {
                error.SetError(cb_s_id, "Debe de seleccionar un valor.");
                dtp_dm_date2.Select();
            }
            if (dtp_dm_date1.Text.Length <= 0)
            {
                error.SetError(dtp_dm_date1, "No puede estar vacío.");
                dtp_dm_date2.Select();
            }
            if (dtp_dm_date2.Text.Length <= 0)
            {
                error.SetError(dtp_dm_date2, "No puede estar vacío.");
                dtp_dm_date2.Select();
            }
        }

        /********** FIN DE FUNCIONES & METODOS **********/

        private void adddoctor_Load(object sender, EventArgs e)
        {
            //if(txt_p_id.Text.Length <= 0)
            //{
            //    cbx_s_status.Checked = true;
            //    cbx_s_status.Text = "Activo";
            //}

            load_doctors();
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
            DateTime ayer = DateTime.Now.Date;
            ayer = ayer.AddDays(-1);

            if (dtp_dm_date1.Value.Date <= ayer)
            {
                MessageBox.Show("No puede Guardar la Visita para una fecha anterior a la de hoy. Favor verifique y velva a intentar.", "Error al Registrar Visita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp_dm_date1.Select();
            }
            else
            {
                appointment_check("s");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txt_dm_status.Text) == 1)
            {
                DateTime ayer = DateTime.Now.Date;
                ayer = ayer.AddDays(-1);

                if (dtp_dm_date1.Value.Date <= ayer)
                {
                    MessageBox.Show("No puede Actualizar la Visita para una fecha anterior a la de hoy. Favor verifique y velva a intentar.", "Error al Registrar Visita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtp_dm_date1.Select();
                }
                else
                {
                    appointment_check("u");
                }
            }
            else if (Convert.ToInt32(txt_dm_status.Text) == 0)
            {
                MessageBox.Show("No se puede actualizar debido a que la Visita se encuentra Cancelada, por ende no puede ser modificada. \n\n Si considera que esto es un error del sistema, favor comuníquese con el administrador.", "No se puede Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(txt_dm_status.Text) > 1)
            {
                MessageBox.Show("No se puede actualizar debido a que la Visita se encuentra en un estado mayor a Agendada, por ende no puede ser modificada. \n\n Si considera que esto es un error del sistema, favor comuníquese con el administrador.", "No se puede Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            //DateTime dt = DateTime.Parse(dtp_dm_date2.Text);
            //MessageBox.Show(Convert.ToDateTime(dtp_dm_date1.Text).ToString("dd/MM/yyyy") + " " + dt.ToString("HH:mm"));
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cancel();
        }

        private void txt_s_idpersons_Click(object sender, EventArgs e)
        {
            functions fc = new functions();
            fc.starttext(txt_p_idpersons);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(txt_dm_id.Text.Length > 0)
            {
                MessageBox.Show("No se puede editar el Paciente de una Visita ya guardada.", "No puede cambiar el Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                searchpatient f = new searchpatient();
                f.formulario_devolver = true;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    clear();
                    txt_p_id.Text = f.textBox1.Text;
                }
            }            
        }

        private void txt_p_id_TextChanged(object sender, EventArgs e)
        {
            load_patient_info();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            searchappointment f = new searchappointment();
            f.formulario_devolver = true;
            if (f.ShowDialog() == DialogResult.OK)
            {
                clear();
                txt_dm_id.Text = f.textBox1.Text;
            }
        }

        private void txt_dm_id_TextChanged(object sender, EventArgs e)
        {
            if(txt_dm_id.Text.Length < 1)
            {
                clear();
                buttons();
            }
            else
            {
                load_appointment_info();
                buttons();
            }
        }

        private void btn_take_turn_Click(object sender, EventArgs e)
        {
            adminturn();
        }

        private void btn_attended_Click(object sender, EventArgs e)
        {
            attended();
        }
    }
}
