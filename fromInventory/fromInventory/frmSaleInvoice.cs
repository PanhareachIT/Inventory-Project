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
    public partial class frmSaleInvoice : Form
    {
        public frmSaleInvoice()
        {
            InitializeComponent();
        }

        private void frmSaleInvoice_Load(object sender, EventArgs e)
        {

            this.rptViewerSaleInvoice.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            rptViewerSaleInvoice.SetDisplayMode(DisplayMode.PrintLayout);
            rptViewerSaleInvoice.ZoomMode = ZoomMode.Percent;
            rptViewerSaleInvoice.ZoomPercent = 100;
        }
    }
}
