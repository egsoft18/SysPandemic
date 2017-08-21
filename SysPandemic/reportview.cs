using CrystalDecisions.CrystalReports.Engine;
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
    public partial class reportview : Form
    {
        public reportview(string name_report)
        {
            InitializeComponent();
            
                ReportDocument cryrpt = new ReportDocument();
                cryrpt.Load(name_report);
                crystalReportViewer1.ReportSource = cryrpt;
                crystalReportViewer1.RefreshReport();
           
           
        }

        private void reportview_Load(object sender, EventArgs e)
        {

        }
    }
}
