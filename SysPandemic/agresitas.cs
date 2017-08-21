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
    public partial class agrescitas : Form
    {
        public agrescitas()
        {
            InitializeComponent();
        }

        private void agrescitas_Load(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, sex as Sexo, idperson as Cedula from patient", cnx);
                DataTable tabla = new DataTable("Pacientes");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;

                SQLiteDataAdapter adac2 = new SQLiteDataAdapter("Select iddoctors as ID, name as Nombre, sex as Sexo, idperson as Cedula from doctors", cnx);
                DataTable tabla2 = new DataTable("doctors");
                adac2.Fill(tabla2);
                dataGridView2.DataSource = tabla2;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                string comando = "INSERT INTO datem(idpatient,namepa,iddoctor,namedoctor,assist,date,time) values('" + txtidpa.Text + "','" + txtpaciente.Text + "','" + txtiddo.Text + "','" + txtdoct.Text + "','Pendiente','" + dtpfecha.Text + "','" + dtphora.Text + "')";
                SQLiteCommand insertion = new SQLiteCommand(comando, cnx);


                if (insertion.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Se agrego correctamente");
                    txtidpa.Clear();
                    txtpaciente.Clear();
                    txtdoct.Clear();
                    txtiddo.Clear();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                DialogResult result = MessageBox.Show("Seguro que desea Actualizar?", "Actualizar datos del Paciente", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string comando = "UPDATE datem  set idpatient ='" + txtidpa.Text + "', namepa ='" + txtpaciente.Text + "', iddoctor = '" + txtiddo.Text + "', namedoctor = '" + txtdoct.Text + "', date = '" + dtpfecha.Text + "', time = '" + dtphora.Text + "' where id = '" + txtid.Text + "'";
                    SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
                    if (insertion.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Se ha actualizado!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Algo fallo!!!");
                    }
                }
                else if (result == DialogResult.No)
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow act = dataGridView1.Rows[e.RowIndex];
            txtidpa.Text = act.Cells["ID"].Value.ToString();
            txtpaciente.Text = act.Cells["Nombre"].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow act = dataGridView2.Rows[e.RowIndex];
            txtiddo.Text = act.Cells["ID"].Value.ToString();
            txtdoct.Text = act.Cells["Nombre"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select id as ID, name as Nombre, sex as Sexo, idperson as Cedula from patient where name like '%" + txtbuscarp.Text + "%'", cnx);
                DataTable tabla = new DataTable("Pacientes");
                adac.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                SQLiteDataAdapter adac = new SQLiteDataAdapter("Select iddoctors as ID, name as Nombre, sex as Sexo, idperson as Cedula from doctors where name like '%" + txtbuscardoc.Text + "%'", cnx);
                DataTable tabla = new DataTable("Doctores");
                adac.Fill(tabla);
                dataGridView2.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar esta Cita?", "Eliminar Cita", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
                try
                {
                    cnx.Open();
                    string comando = "DELETE FROM datem WHERE id = '" + txtid.Text + "'";
                    SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
                    if (insertion.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Se ha eliminado!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Algo fue mal");
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

        private void button4_Click(object sender, EventArgs e)
        {
            SQLiteConnection cnx = new SQLiteConnection("Data Source=C:\\syspandemic\\db\\syspandemic.db;Version=3;");
            try
            {
                cnx.Open();
                string asis = "Asistio";
                string comando = "UPDATE datem  set assist = '" + asis + "' where id = '" + txtid.Text + "'";
                SQLiteCommand insertion = new SQLiteCommand(comando, cnx);
                if (insertion.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Se ha actualizado!");
                    Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncanc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

