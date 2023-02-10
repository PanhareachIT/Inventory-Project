using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace fromInventory
{
    public partial class frmRptEmp : Form
    {
        public frmRptEmp()
        {
            InitializeComponent();
        }

        private void frmRptEmp_Load(object sender, EventArgs e)
        {
            rptViewerEmp.SetDisplayMode(DisplayMode.PrintLayout);
            rptViewerEmp.ZoomMode = ZoomMode.Percent;
            rptViewerEmp.ZoomPercent = 100;
        }
    }
}
