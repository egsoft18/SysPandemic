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
        DBManager c = new DBManager();
        public agrescitas()
        {
            InitializeComponent();
        }

        private void agrescitas_Load(object sender, EventArgs e)
        {
            string query = "Select idpatient as ID, name as Nombre, sex as Sexo, idperson as Cedula from patient";
            c.load_dgv(dataGridView1, query);
            
            query = "Select idstaff as ID, namestaff as Nombre, sexstaff as Sexo, idpersonstaff as Cedula from staff";
            c.load_dgv(dataGridView2, query);

            query = "Select id as ID, namepa as Paciente, namedoctor as Doctor, assist as Asistencia, date as Fecha, time as Hora from datem";
            c.load_dgv(dataGridView3, query);
               
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string query0 = "Select * from datem where date = '" + dtpfecha.Text + "' and time = '" + dtphora.Text + "' and iddoctor = '" + txtiddo.Text+"'";
            c.validation(query0);
            if (c.valor == "si")
            {
                MessageBox.Show("NO se puede agregar, debido a que ya hay una cita a esa hora");
                c.valor = "";

            }
            else if (c.valor == "no")
            {
            string query = "INSERT INTO datem(idpatient,namepa,iddoctor,namedoctor,assist,date,time) values('" + txtidpa.Text + "','" + txtpaciente.Text + "','" + txtiddo.Text + "','" + txtdoct.Text + "','Pendiente','" + dtpfecha.Text + "','" + dtphora.Text + "')";
            c.command(query);
            txtidpa.Clear();
            txtpaciente.Clear();
            txtdoct.Clear();
            txtiddo.Clear();

            c.valor = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
                DialogResult result = MessageBox.Show("Seguro que desea Actualizar?", "Actualizar datos del Paciente", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = "UPDATE datem  set idpatient ='" + txtidpa.Text + "', namepa ='" + txtpaciente.Text + "', iddoctor = '" + txtiddo.Text + "', namedoctor = '" + txtdoct.Text + "', date = '" + dtpfecha.Text + "', time = '" + dtphora.Text + "' where id = '" + txtid.Text + "'";
                    
                    c.command(query);
                this.Close();
                }
                else if (result == DialogResult.No)
                {

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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buscard();
        }
        private void buscard()
        {
            string query = "Select idstaff as ID, namestaff as Nombre, sexstaff as Sexo, idpersonstaff as Cedula from staff where namestaff like '%" + txtbuscardoc.Text + "%'";
            c.load_dgv(dataGridView2, query);
               
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar esta Cita?", "Eliminar Cita", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                    string query = "DELETE FROM datem WHERE id = '" + txtid.Text + "'";
                    c.command(query);
                    Close();
                    

            }
            else if (result == DialogResult.No)
            {
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
                string asis = "Asistio";
                string query = "UPDATE datem  set assist = '" + asis + "' where id = '" + txtid.Text + "'";
                c.command(query);
            this.Close();
        }

        private void btncanc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtbuscarp_TextChanged(object sender, EventArgs e)
        {
            buscarp();
        }
        private void buscarp()
        {
            string query = "Select idpatient as ID, name as Nombre, sex as Sexo, idperson as Cedula from patient where name like '%" + txtbuscarp.Text + "%'";
            c.load_dgv(dataGridView1, query);
                
        }

        private void txtbuscardoc_TextChanged(object sender, EventArgs e)
        {
            buscard();
        }

        private void agent()
        {
            if (string.IsNullOrEmpty(txtiddo.Text))
            {
                string query = "Select id as ID, namepa as Paciente, namedoctor as Doctor, assist as Asistencia, date as Fecha, time as Hora from datem where date = '"+dtpfecha.Text+"' and time = '"+dtphora.Text+"'";
                c.load_dgv(dataGridView3, query);
            }
            else
            {
                string query = "Select id as ID, namepa as Paciente, namedoctor as Doctor, assist as Asistencia, date as Fecha, time as Hora from datem where date = '" + dtpfecha.Text + "' and time = '" + dtphora.Text + "' and iddoctor = '"+txtiddo.Text+"'";
                c.load_dgv(dataGridView3, query);
            }
        }

        private void txtiddo_TextChanged(object sender, EventArgs e)
        {
            agent();
        }

        private void dtpfecha_ValueChanged(object sender, EventArgs e)
        {
            agent();
        }

        private void dtphora_ValueChanged(object sender, EventArgs e)
        {
            agent();
        }
    }
}

