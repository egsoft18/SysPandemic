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

namespace SysPandemic
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
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
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
