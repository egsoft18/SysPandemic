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
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace SysPandemic
{
    
    public partial class login : Form
    {

        SqlCommand cmd;
        SqlDataReader dr;
        OpenDB c = new OpenDB();

        public login()
        {
            m_aeroEnabled = false;
            InitializeComponent();
        }

        /***** Shadow en el Form *****/

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
   (
       int nLeftRect, // x-coordinate of upper-left corner
       int nTopRect, // y-coordinate of upper-left corner
       int nRightRect, // x-coordinate of lower-right corner
       int nBottomRect, // y-coordinate of lower-right corner
       int nWidthEllipse, // height of ellipse
       int nHeightEllipse // width of ellipse
    );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:                        // box shadow
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
                m.Result = (IntPtr)HTCAPTION;
        }

        /***** FIN Shadow en el Form *****/


        //Codigo para movilidad del formulario.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);


        /*************** FUNCIONES & METODOS ***************/
        private void iniciar()
        {
            try
            {
                cmd = new SqlCommand("SELECT [u_id], [u_user], [u_password], [u_right] FROM [users] where [u_user] = '" + txt_u_user.Text + "' and [u_password] = '" + txt_u_password.Text + "' and [u_status] = 1", c.cnx);
                DataSet ds = new DataSet();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                ds.Tables.Add(dt);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Usuario o contraseña invalida o bien el usuario no se encuantra activo en el sistema, intente de nuevo.", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_u_user.Focus();
                }
                else
                {
                    try
                    {
                        SqlDataReader leer = cmd.ExecuteReader();
                        if (leer.Read() == true)
                        {
                            ActualUser.userid = Convert.ToString(leer["u_id"]);
                            ActualUser.permisos = Convert.ToString(leer["u_right"]);
                            //MessageBox.Show(ActualUser.permisos);
                            //MessageBox.Show(ActualUser.userid);
                            txt_u_password.Clear();
                            this.Hide();
                            Homeform frm = new Homeform();
                            
                            frm.txt_u_name.Text = Convert.ToString(leer["u_user"]);
                            switch (Convert.ToString(leer["u_right"]))
                            {
                                case "A": frm.txt_u_right.Text = "Administrador";
                                    break;
                                case "M": frm.txt_u_right.Text = "Manejador";
                                    break;
                                case "P": frm.txt_u_right.Text = "Profesional";
                                    break;
                                default:
                                    frm.txt_u_right.Text = "";
                                    break;
                            }

                            frm.ShowDialog();
                            this.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo obtener el ID del usuario. Razón: " + ex.Message, "Error al obtener el ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo iniciar sesión en SysPandemic, la razón fue; " + ex.Message, "Error al iniciar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /********** FINAL DE FUNCIONES & METODOS **********/


        private void loginbtn_Click(object sender, EventArgs e)
        {
            iniciar();
        }

        private void login_Load(object sender, EventArgs e)
        {
            txt_u_user.Select();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Si no tiene un usuario no puede acceder a el sistema, en cambio, puede comunicarse con el administrador del sistema para concederle uno de ser necesario.", "No tengo Usuario");
        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void passtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iniciar();
                
            }
        }

        private void usercb1_TextChanged(object sender, EventArgs e)
        {
            //passtxt.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txt_u_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_u_password.Text.Length > 0)
            {
                iniciar();
            }
            else if (e.KeyCode == Keys.Enter && txt_u_password.Text.Length <= 0)
            {
                MessageBox.Show("Ingrese una contraseña.", "Falta contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_u_password.Select();
            }
        }
    }
}
