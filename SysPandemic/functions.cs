using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPandemic
{
    class functions
    {

        public void limpiar(Form f)
        {
            foreach (Control oControls in f.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = "";
                }
            }

            foreach (ComboBox oControls in f.Controls)
            {
                if (oControls.SelectedValue == null)
                {
                    oControls.SelectedIndex = -1;
                }
            }

            foreach (DataGridView oControls in f.Controls)
            {
                if (oControls.Rows.Count > 0)
                {
                    oControls.Rows.Clear();
                }
            }

            foreach (DateTimePicker oControls in f.Controls)
            {
                if (oControls.Text != DateTime.Today.ToString("dd-MM-yyyy"))
                {
                    oControls.Text = DateTime.Today.ToString("dd-MM-yyyy");
                }
            }
        }
    }
}
