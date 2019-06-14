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
        public login()
        {
            InitializeComponent();
        }

        //Esta parte va debajo del public del formulario, fuera de las llavez de este.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);

        public void startseccion()
        {

            DBManager c = new DBManager();
            string user = Convert.ToString(usercb1.Text);
            string pass = Convert.ToString(passtxt.Text);
            c.startseccion(user,pass);
            if (c.valor == "si")
            {
                Homeform frm = new Homeform();
                this.Hide();
                frm.ShowDialog();
                this.Show();
                passtxt.Clear();
            }

        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            startseccion();
        }

        private void login_Load(object sender, EventArgs e)
        {
            
            DBManager c = new DBManager();
            c.cbusers(usercb1);

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
                startseccion();
                
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
    }
}
