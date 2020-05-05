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

        }

        public void starttext(MaskedTextBox txt)
        {
            if (txt.Text.Length <= 0)
            {
                txt.Select(0, 0);
            }

        }

    }
}
