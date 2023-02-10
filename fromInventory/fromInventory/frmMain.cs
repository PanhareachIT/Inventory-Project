using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fromInventory
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = Myoper.empName;
            lblDate.Text = DateTime.Now.ToString("dd:MM:yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnToEmp_Click(object sender, EventArgs e)
        {
            FormEmployee fem = new FormEmployee();
            this.Hide();
            fem.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSale fSale = new frmSale();   
            this.Hide();
            fSale.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmSaleInvoice fSaleInvoice = new frmSaleInvoice();
            this.Hide();
            fSaleInvoice.ShowDialog();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FromImport2 Fim = new FromImport2();
            this.Hide();
            Fim.ShowDialog();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formProduct fPro = new formProduct();
            this.Hide();
            fPro.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCategory1 fcat = new FormCategory1();
            this.Hide();
            fcat.ShowDialog();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmImportReport ipr = new frmImportReport();
            this.Hide();
            ipr.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmCreateAcc2 frm = new frmCreateAcc2();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }


    }
}
