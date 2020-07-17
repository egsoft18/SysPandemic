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
    public partial class addsupplier : Form
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
        functions fu = new functions();

        public bool formulario_devolver = false;

        public addsupplier()
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
            if (txt_pv_id.Text.Length > 0)
            {
                btn_save.Hide();
                btn_update.Show();
            }
            else if (txt_pv_id.Text.Length <= 0)
            {
                btn_save.Show();
                btn_update.Hide();
            }
        }        

        private void adminsupplier()
        {
            if (txt_pv_name.Text.Length > 0 && txt_pv_phone.Text.Length > 0)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("admin_provider", c.cnx))
                    {
                        int inttxt_pv_id;
                        if (txt_pv_id.Text.Length > 0)
                        {
                            inttxt_pv_id = Convert.ToInt32(txt_pv_id.Text);
                        }
                        else
                        {
                            inttxt_pv_id = 0;
                        }

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("pv_id", SqlDbType.Int).Value = inttxt_pv_id;
                        cmd.Parameters.Add("pv_name", SqlDbType.NVarChar).Value = txt_pv_name.Text;
                        cmd.Parameters.Add("pv_address", SqlDbType.NVarChar).Value = txt_pv_address.Text;
                        cmd.Parameters.Add("pv_phone", SqlDbType.NVarChar).Value = txt_pv_phone.Text;
                        cmd.Parameters.Add("pv_email", SqlDbType.NVarChar).Value = txt_pv_email.Text;
                        cmd.Parameters.Add("pv_contact", SqlDbType.NVarChar).Value = txt_pv_contact.Text;
                        cmd.Parameters.Add("pv_contactposition", SqlDbType.NVarChar).Value = txt_pv_contactposition.Text;
                        cmd.Parameters.Add("pv_phonecontact", SqlDbType.NVarChar).Value = txt_pv_phonecontact.Text;

                        int status = 1;
                        if(cbx_pv_status.Checked == true)
                        {
                            status = 1;
                        }
                        else
                        {
                            status = 0;
                        }
                        cmd.Parameters.Add("pv_status", SqlDbType.Int).Value = status;

                        cmd.Parameters.Add("u_id", SqlDbType.Int).Value = ActualUser.userid;
                        cmd.Parameters.Add("pv_lu", SqlDbType.Date).Value = ActualUser.hoy;

                        cmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;


                        //cmd.ExecuteNonQuery();

                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Se ha realizado la accion", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //clear(0);
                            txt_pv_id.Text = Convert.ToString(cmd.Parameters["@id"].Value);
                            txt_pv_name.Select();

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
                    MessageBox.Show("No se pudo agregar la infromacion. La causa: " + ex.Message, "adminsupplier try fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Los campos: Nombre del Suplidor y el Teléfono son campos obligatorios, favor verifique y vuelva a intentar. \n\n Si considera que esto es un error del sistema, favor comuníquese con el administrador.", "No se ha podido realizar la acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errors();
                txt_pv_name.Select();
            }
        }        

        private void load_supplier_info()
        {
            try
            {
                string query = "SELECT [pv_id], [pv_name], [pv_address], [pv_phone], [pv_email], [pv_contact], [pv_contactposition], [pv_phonecontact], [pv_status], [u_id], [pv_lu] FROM [dbo].[provider] where [pv_id] =  '" + txt_pv_id.Text + "'";
                SqlCommand insertion = new SqlCommand(query, c.cnx);
                SqlDataReader leer = insertion.ExecuteReader();
                if (leer.Read() == true)
                {
                    txt_pv_name.Text = Convert.ToString(leer["pv_name"]);
                    txt_pv_address.Text = Convert.ToString(leer["pv_address"]);
                    txt_pv_phone.Text = Convert.ToString(leer["pv_phone"]);
                    txt_pv_email.Text = Convert.ToString(leer["pv_email"]);
                    txt_pv_contact.Text = Convert.ToString(leer["pv_contact"]);
                    txt_pv_contactposition.Text = Convert.ToString(leer["pv_contactposition"]);
                    txt_pv_phonecontact.Text = Convert.ToString(leer["pv_phonecontact"]);

                    // Para seleccionar o no el cbx de status.
                    if (Convert.ToInt32(leer["pv_status"]) == 1)
                    {
                        cbx_pv_status.Checked = true;
                        cbx_pv_status.Text = "Activo";
                    }
                    else if (Convert.ToInt32(leer["pv_status"]) == 0)
                    {
                        cbx_pv_status.Checked = false;
                        cbx_pv_status.Text = "Inactivo";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar los datos del Suplidor. Razón: " + ex.Message, "Error al cargar el Suplidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear(int did)
        {
            if (did == 0)
            {
                txt_pv_id.Clear();
            }

            txt_pv_name.Clear();
            txt_pv_address.Clear();
            txt_pv_phone.Clear();
            txt_pv_email.Clear();
            txt_pv_contact.Clear();
            txt_pv_contactposition.Clear();
            txt_pv_phonecontact.Clear();

            cbx_pv_status.Checked = true;

        }

        private void errors()
        {
            error.Clear();

            // Datos Generales
            if (txt_pv_name.Text.Length <= 0) error.SetError(txt_pv_name, "No puede estar vacío.");
            if (txt_pv_phone.Text.Length <= 0) error.SetError(txt_pv_phone, "No puede estar vacío.");            
        }

        private void cbx()
        {
            if (cbx_pv_status.Checked)
            {
                cbx_pv_status.Text = "Activo";
            }
            else
            {
                cbx_pv_status.Text = "inactivo";
            }
        }

        /********** FIN DE FUNCIONES & METODOS **********/

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

        private void btn_save_Click(object sender, EventArgs e)
        {
            adminsupplier();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            adminsupplier();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear(0);
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clear(0);
            this.Close();
        }

        private void txt_pv_id_TextChanged(object sender, EventArgs e)
        {
            load_supplier_info();
            buttons();
            cbx();
        }

        private void txt_pv_phone_Click(object sender, EventArgs e)
        {
            fu.starttext(txt_pv_phone);
        }

        private void txt_pv_phonecontact_Click(object sender, EventArgs e)
        {
            fu.starttext(txt_pv_phonecontact);
        }

        private void cbx_pv_status_CheckedChanged(object sender, EventArgs e)
        {
            cbx();
        }

        private void addsupplier_Load(object sender, EventArgs e)
        {
            buttons();
            cbx_pv_status.Checked = true;
            cbx();
        }
    }
}
