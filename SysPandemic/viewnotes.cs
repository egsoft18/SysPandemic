using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPandemic
{
    public partial class viewnotes : Form
    {
        DBManager c = new DBManager();
        public viewnotes()
        {
            InitializeComponent();
        }

        private void viewnotes_Activated(object sender, EventArgs e)
        {
            load();

            if (vn_idnote_txt.Text == "")
            {
                vn_addnotes_btn.Text = "Agregar";
            }
            else
            {
                vn_addnotes_btn.Text = "Actualizar";
            }
        }

        private void vn_addnotes_txt_Click(object sender, EventArgs e)
        {
            if(vn_idnote_txt.Text == "")
            {
                string query = "insert into procedurenotes (idprocedure, note) values ('" + vn_idpro_txt.Text + "', '" + vn_note_txt.Text + "')";
                c.command(query);
                load();
                vn_note_txt.Clear();
            }
            else
            {
                string query = "update procedurenotes set note = '" + vn_note_txt.Text + "' where idnote = '" + vn_idnote_txt.Text + "'";
                c.command(query);
                load();
                vn_idnote_txt.Clear();
                vn_note_txt.Clear();
            }

            
        }

        private void viewnotes_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            string query = "select idnote as ID, note as Nota from procedurenotes where idprocedure = '" + vn_idpro_txt.Text + "'";
            c.load_dgv(dataGridView1, query);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow act = dataGridView1.Rows[e.RowIndex];

            vn_idnote_txt.Text = act.Cells["ID"].Value.ToString();
            vn_note_txt.Text = act.Cells["Nota"].Value.ToString();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridViewRow act = dataGridView1.Rows[e.RowIndex];

            string id = act.Cells["ID"].Value.ToString();
            DialogResult result = MessageBox.Show("Seguro que desea borrar?", "Borrar nota del procedimiento", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE from procedurenotes where idnote = '" + id + "'";
                c.command(query);
                load();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void vn_idnote_txt_TextChanged(object sender, EventArgs e)
        {
            if (vn_idnote_txt.Text == "")
            {
                vn_addnotes_btn.Text = "Agregar";
            }
            else
            {
                vn_addnotes_btn.Text = "Actualizar";
            }
        }
    }
}
