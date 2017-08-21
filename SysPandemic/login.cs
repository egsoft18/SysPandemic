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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public void startseccion()
        {
            string actuser = Convert.ToString(usercb1.Text);
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteDataAdapter ad;
                DataTable dt = new DataTable();
                SQLiteCommand cmd = cnx.CreateCommand();
                cmd.CommandText = "Select * from userpass  where user = '" + usercb1.Text + "' and pass = '" + passtxt.Text + "'";
                ad = new SQLiteDataAdapter(cmd);

                DataSet ds = new DataSet();
                ad.Fill(dt);
                ds.Tables.Add(dt);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Usuario o contraseña invalida, intente de nuevo.");
                }
                else
                {
                    Homeform frm = new Homeform();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                    passtxt.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            startseccion();
        }

        private void login_Load(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                string cmd = "Select id, user from userpass";
                SQLiteDataAdapter dept = new SQLiteDataAdapter(cmd, cnx);
                DataTable user = new DataTable();
                dept.Fill(user);
                usercb1.DataSource = user;
                usercb1.DisplayMember = "user";
                usercb1.ValueMember = "id";
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
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
    }
}
