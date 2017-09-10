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
                    MessageBox.Show("Bienvenido a SysPandemic " + user);
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

        public void add_patient(String namepatient, String bdaypatient, String sexpatient, String idperson, String addresspatient, String telpatient, String celpatient, String tworkpatient, String insurancepatient, String affiliatepatient)
        {
            try { 
            AddPatient frm = new AddPatient();
            string comando = "INSERT INTO patient(name, bday, sex, idperson, address, tel, cel, telwork, insurance, affiliate) VALUES('" + namepatient + "','" + bdaypatient + "','" + sexpatient + "','" + idperson + "','" + addresspatient + "','" + telpatient + "','" + celpatient + "','" + tworkpatient + "','" + insurancepatient + "','" + affiliatepatient + "')";
            SqlCommand insertion = new SqlCommand(comando, cnx);

            if (insertion.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Se agrego correctamente", "Hecho");
               
            }
                }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar la infromacion del paciente: " + ex.Message);
            }
        }

        public void update_patient(String idpatient, String namepatient, String bdaypatient, String sexpatient, String idperson, String addresspatient, String telpatient, String celpatient, String tworkpatient, String insurancepatient, String affiliatepatient)
        {
            try
            {
                DialogResult result = MessageBox.Show("Seguro que desea Actualizar?", "Actualizar datos del Paciente", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    AddPatient frm = new AddPatient();
                    string comando = "UPDATE patient set name = '" + namepatient + "', sex = '" + bdaypatient + "', bday = '" + bdaypatient + "', idperson = '" + idperson + "', address = '" + addresspatient + "', tel = '" + telpatient + "', cel = '" + celpatient + "', telwork = '" + tworkpatient + "', insurance = '" + insurancepatient + "', affiliate = '" + affiliatepatient + "' WHERE idpatient = '" + idpatient + "'";
                    SqlCommand insertion = new SqlCommand(comando, cnx);

                    if (insertion.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Se ha actualizado correctamente", "Hecho");
                        frm.Close();

                    }
                }
                else if (result == DialogResult.No)
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se llego a actualizar. Causa: "+ex.Message);

            }
        }
        public void delete_patient(string idpatient)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar este Paciente?", "Eliminar paciente", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    AddPatient frm = new AddPatient();
                    string comando = "DELETE FROM patient WHERE idpatient = '" + idpatient + "'";
                    SqlCommand insertion = new SqlCommand(comando, cnx);

                    if (insertion.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Se ha Borrado correctamente", "Hecho");
                        frm.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }

            }
            else if (result == DialogResult.No)
            {
            }
        }

        public void patient_administrator(DataGridView dgv)
        {
            
            try
            {
                searchpatient frm = new searchpatient(); 
                SqlDataAdapter adac = new SqlDataAdapter("Select idpatient as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient", cnx);
                DataTable tabla = new DataTable("Pacientes");
                adac.Fill(tabla);
                dgv.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro cargar el visor. Causa: "+ex.Message);
            }
        }
        public void search_patient(DataGridView dgv, string condition, string value)
        {
            try
            {
                searchpatient frm = new searchpatient();
                SqlDataAdapter adac = new SqlDataAdapter("Select idpatient as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient where "+condition+" like '%"+value+"%'", cnx);
                DataTable tabla = new DataTable("Pacientes");
                adac.Fill(tabla);
                dgv.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro cargar el visor. Causa: " + ex.Message);
            }
        }
    }
}
