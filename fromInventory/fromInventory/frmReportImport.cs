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
    public partial class frmReportImport : Form
    {
        public frmReportImport()
        {
            InitializeComponent();
        }

        private void frmReportImport_Load(object sender, EventArgs e)
        {
            //rptViewerSaleInvoice.SetDisplayMode(DisplayMode.PrintLayout);
            //rptViewerSaleInvoice.ZoomMode = ZoomMode.Percent;
            //rptViewerSaleInvoice.ZoomPercent = 100;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            
            //this.rptImport.RefreshReport();
this.reportViewer1.RefreshReport();
        }
    }
}
