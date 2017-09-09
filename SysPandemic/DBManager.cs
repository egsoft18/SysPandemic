using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SysPandemic
{
    class DBManager
    {
        //string cadena = "Data Surce=DELLPC;Initial Catalog=SysPandemic; Integrated Security=True";
        //public SqlConnection cnx = new SqlConnection();

        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataReader dr;
        public DBManager()
        {
            try
            {
                cnx = new SqlConnection("Data Source=DELLPC;Initial Catalog=SysPandemic; Integrated Security=True");
                cnx.Open();
                //MessageBox.Show("Conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar " + ex.Message);

            }
        }
        public void cbusers(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("Select usu from userpass", cnx);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    cb.Items.Add(dr["usu"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar " + ex.Message);
                
            }
            finally
            {
            }
        }
        public void startseccion(string user, string pass)
        {
            try
            {
                cmd = new SqlCommand("Select usu, pass from userpass where usu = '"+user+"' and pass = '"+pass+"'", cnx);
                DataSet ds = new DataSet();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                ds.Tables.Add(dt);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Usuario o contraseña invalida, intente de nuevo.");
                }
                else
                {
                    Homeform frm = new Homeform();
                    login lfrm = new login();
                    lfrm.Hide();
                    frm.ShowDialog();
                    lfrm.passtxt.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo hacer el login; " + ex.Message);
            }
        }

    }
}
