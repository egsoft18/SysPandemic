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

        public string valor = "";
        public string actuser = "";

        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataReader dr;
        public DBManager()
        {
            try
            {
                //Conexion para la PC de desarrollo
                cnx = new SqlConnection("Data Source=DESKTOP-RC55N5R;Initial Catalog=SysPandemic; Integrated Security=True; MultipleActiveResultSets=True");

                //Conexion para la pc del consultorio
                //cnx = new SqlConnection(@"Server=INOA-PC\EGSOFT;Database=SysPandemic;User Id=egsoft; Password=1234; MultipleActiveResultSets=True");

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
                while (dr.Read())
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
                cmd = new SqlCommand("Select usu, pass from userpass where usu = '" + user + "' and pass = '" + pass + "'", cnx);
                DataSet ds = new DataSet();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                ds.Tables.Add(dt);
                if (dt.Rows.Count <= 0)
                {

                    //MessageBoxTemporal.Show("Mensaje de prueba para karmany.NET", "Título", 22, true);
                    MessageBox.Show("Usuario o contraseña invalida, intente de nuevo.");

                }
                else
                {
                    valor = "si";


                    //MessageBox.Show("Bienvenido a SysPandemic " + user);
                    //Homeform frm = new Homeform();
                    //login lfrm = new login();
                    //lfrm.Hide();
                    //frm.ShowDialog();
                    //lfrm.passtxt.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo hacer el login; " + ex.Message);
            }
        }

        public void add_patient(String namepatient, String bdaypatient, String sexpatient, String idperson, String addresspatient, String telpatient, String celpatient, String tworkpatient, String insurancepatient, String affiliatepatient)
        {
            try
            {
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
                    string comando = "UPDATE patient set name = '" + namepatient + "', sex = '" + sexpatient + "', bday = '" + bdaypatient + "', idperson = '" + idperson + "', address = '" + addresspatient + "', tel = '" + telpatient + "', cel = '" + celpatient + "', telwork = '" + tworkpatient + "', insurance = '" + insurancepatient + "', affiliate = '" + affiliatepatient + "' WHERE idpatient = '" + idpatient + "'";
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
                MessageBox.Show("No se llego a actualizar. Causa: " + ex.Message);

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
                MessageBox.Show("No se logro cargar el visor. Causa: " + ex.Message);
            }
        }
        public void search_patient(DataGridView dgv, string condition, string value)
        {
            try
            {
                searchpatient frm = new searchpatient();
                SqlDataAdapter adac = new SqlDataAdapter("Select idpatient as ID, name as Nombre, bday as FechaNac, sex as Sexo, idperson as Cedula, address as Direccion, tel as Telefono, cel as Celular, telwork as TelTrabajo, insurance as Seguro, affiliate as Afiliado from patient where " + condition + " like '%" + value + "%'", cnx);
                DataTable tabla = new DataTable("Pacientes");
                adac.Fill(tabla);
                dgv.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro cargar el visor. Causa: " + ex.Message);
            }
        }
        public void add_staff(string namedoctor, string sexdoctor, string idperson, string addressdoctor, string teldoctor, string celdoctor, string role, string salary, string condition)
        {
            try
            {
                AddPatient frm = new AddPatient();
                string comando = "INSERT INTO staff(namestaff, sexstaff, idpersonstaff, addressstaff, telstaff, celstaff, rolestaff, salarystaff) VALUES('" + namedoctor + "','" + sexdoctor + "','" + idperson + "','" + addressdoctor + "','" + teldoctor + "','" + celdoctor + "','" + role + "','" + salary + "')";
                SqlCommand insertion = new SqlCommand(comando, cnx);

                if (insertion.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Se agrego correctamente", "Hecho");
                    valor = "si";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar la infromacion del Doctor: " + ex.Message);
            }
        }
        public void doctor_administrator(DataGridView dgv)
        {
            try
            {
                searchpatient frm = new searchpatient();
                SqlDataAdapter adac = new SqlDataAdapter("Select idstaff as ID, namestaff as Nombre, sexstaff as Sexo, idpersonstaff as Cedula, addressstaff as Direccion, telstaff as Telefono, celstaff as Celular, salarystaff as Salario from staff where rolestaff = 'Doctor'", cnx);
                DataTable tabla = new DataTable("Doctors");
                adac.Fill(tabla);
                dgv.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro cargar el visor. Causa: " + ex.Message);
            }
        }
        public void update_doctor(string iddoctor, string namedoctor, string sexdoctor, string idperson, string addressdoctor, string teldoctor, string celdoctor, string role, string salary)
        {
            try
            {
                AddPatient frm = new AddPatient();
                string comando = "UPDATE staff set namestaff = '" + namedoctor + "', sexstaff = '" + sexdoctor + "', idpersonstaff = '" + idperson + "', addressstaff = '" + addressdoctor + "', telstaff = '" + teldoctor + "', celstaff = '" + celdoctor + "', rolestaff = '" + role + "', salarystaff = '" + salary + "' WHERE idstaff = '" + iddoctor + "'";
                SqlCommand insertion = new SqlCommand(comando, cnx);

                if (insertion.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Se actualizo correctamente", "Hecho");
                    adddoctor f = new adddoctor();
                    f.Close();

                    //f.Close();
                    //f.namedoctor_txt.Text = "";
                    //f.sexdoctor_cb.Text = "";
                    //f.idperson_txt.Text = "";
                    //f.addressdoctor_txt.Text = "";
                    //f.teldoctor_txt.Text = "";
                    //f.celdoctor_txt.Text = "";
                    //f.salary_txt.Text = "";
                    //condition = "yes";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro actualizar el Doctor. Causa: " + ex.Message);
            }
        }
        public void delete_staff(string idstaff)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    AddPatient frm = new AddPatient();
                    string comando = "DELETE FROM staff WHERE idstaff = '" + idstaff + "'";
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
        public void search_staff_doctor(DataGridView dgv, string condition, string value)
        {
            try
            {
                searchpatient frm = new searchpatient();
                SqlDataAdapter adac = new SqlDataAdapter("Select idstaff as ID, namestaff as Nombre, sexstaff as Sexo, idpersonstaff as Cedula, addressstaff as Direccion, telstaff as Telefono, celstaff as Celular, salarystaff as Salario from staff where " + condition + " like '%" + value + "%' and rolestaff = 'Doctor'", cnx);
                DataTable tabla = new DataTable("Pacientes");
                adac.Fill(tabla);
                dgv.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro cargar el visor. Causa: " + ex.Message);
            }
        }
        public void command(string query)
        {
            try
            {

                SqlCommand insertion = new SqlCommand(query, cnx);

                if (insertion.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Se ha realizado la accion", "Hecho");
                    valor = "si";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar la infromacion. La causa: " + ex.Message);
            }
        }
        public void load_dgv(DataGridView dgv, string query)
        {
            try
            {
                searchpatient frm = new searchpatient();
                SqlDataAdapter adac = new SqlDataAdapter(query, cnx);
                DataTable tabla = new DataTable("table");
                adac.Fill(tabla);
                dgv.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro cargar el visor. Causa: " + ex.Message);
            }
        }
        public void fill_CB(ComboBox cb, string query, string item)
        {
            try
            {
                cmd = new SqlCommand(query, cnx);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr[item].ToString());
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
        public void last_id(TextBox ms, string query, string condition)
        {
            try
            {

                SqlCommand insertion = new SqlCommand(query, cnx);
                SqlDataReader leer = insertion.ExecuteReader();
                if (leer.Read() == true)
                {
                    decimal value = Convert.ToDecimal(leer[condition].ToString());
                    string nun = value.ToString();
                    ms.Text = nun;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No consiguio el ID. La causa: " + ex.Message);
            }
        }
        public void command3(string query)
        {
            try
            {

                SqlCommand insertion = new SqlCommand(query, cnx);

                if (insertion.ExecuteNonQuery() > 0)
                {
                    valor = "si";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar la infromacion. La causa: " + ex.Message);
            }
        }
        public void printreport(string query, string tablename, string xml, string reportrpt)
        {

            try
            {
                SqlCommand cmd = cnx.CreateCommand();
                cmd.CommandText = query;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ad.Fill(dt);
                ds.Tables.Add(dt);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("No hay datos que imprimir.");
                }
                else
                {
                    ds.Tables[0].TableName = tablename;
                    ds.WriteXml(@"C:\SysPandemic server\xml\" + xml + "");
                    //MessageBox.Show("Done");
                    reportview rv = new reportview(reportrpt);
                    rv.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        public void fill_txt(TextBox txt, string query, string condition)
        {
            try
            {

                SqlCommand insertion = new SqlCommand(query, cnx);
                SqlDataReader leer = insertion.ExecuteReader();
                if (leer.Read() == true)
                {
                    string text = Convert.ToString(leer[condition]);
                    txt.Text = text;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }
        public void fill_diag(string query, ComboBox tmed_cb, TextBox tmedcom_txt, ComboBox mica_cb, TextBox micacom_txt, ComboBox ps_cb, ComboBox diab_cb, ComboBox hep_cb, TextBox hepcom_txt, ComboBox pr_cb, ComboBox pe_cb, TextBox pecom_txt, ComboBox pa_cb, TextBox pacom_txt, ComboBox hemo_cb, ComboBox aler_cb, TextBox alercom_txt)
        {
            try
            {

                SqlCommand insertion = new SqlCommand(query, cnx);
                SqlDataReader leer = insertion.ExecuteReader();
                if (leer.Read() == true)
                {

                    tmed_cb.Text = Convert.ToString(leer["tmed"]);
                    tmedcom_txt.Text = Convert.ToString(leer["tmedcom"]);
                    mica_cb.Text = Convert.ToString(leer["mica"]);
                    micacom_txt.Text = Convert.ToString(leer["micacom"]);
                    ps_cb.Text = Convert.ToString(leer["ps"]);
                    diab_cb.Text = Convert.ToString(leer["diab"]);
                    hep_cb.Text = Convert.ToString(leer["hep"]);
                    hepcom_txt.Text = Convert.ToString(leer["hepcom"]);
                    pr_cb.Text = Convert.ToString(leer["pr"]);
                    pe_cb.Text = Convert.ToString(leer["pe"]);
                    pecom_txt.Text = Convert.ToString(leer["pecom"]);
                    pa_cb.Text = Convert.ToString(leer["pa"]);
                    pacom_txt.Text = Convert.ToString(leer["pacom"]);
                    hemo_cb.Text = Convert.ToString(leer["hemo"]);
                    aler_cb.Text = Convert.ToString(leer["aler"]);
                    alercom_txt.Text = Convert.ToString(leer["alercom"]);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }
    }
}

