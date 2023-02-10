using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using Microsoft.Reporting.WinForms;
namespace fromInventory
{
    public partial class frmSale3 : Form
    {
        public frmSale3()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        SqlCommand com;
        DataTable dt;
        Boolean b = false;
        decimal total;
        int cid;
        public void fillCbo(string id, string name, string tb, ComboBox cbo)
        {
            da = new SqlDataAdapter("Select "+id+", "+name+" from "+tb, Myoper.con);
            dt = new DataTable();
            da.Fill(dt);
            cbo.DataSource = dt;
            cbo.DisplayMember = name;
            cbo.ValueMember = id;
        }
        private void frmSale3_Load(object sender, EventArgs e)
        {
            Myoper.myconnection();
            fillCbo("proID", "proName", "tbProduct", cmbProName);
            fillCbo("catID", "category", "tb_Category", cmbCate);
            fillCbo("cusID", "cusName", "tbCustomer", cmbCusName);
            txtSaleInvoice.Text = "Auto Number";
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("ProID", 150);
            listView1.Columns.Add("ProName", 150);
            listView1.Columns.Add("Quantity", 150);
            listView1.Columns.Add("UnitPrice", 150);
            listView1.Columns.Add("Amount", 150);
        }

        private void cmbProName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtProID.Text = cmbProName.SelectedValue.ToString();
        }

        private void txtProID_TextChanged(object sender, EventArgs e)
        {
            
            com = new SqlCommand("select catID from tbProduct where proID = '"+txtProID.Text+"'", Myoper.con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                cmbProName.SelectedValue = txtProID.Text;
                cmbCate.SelectedValue = dr[0].ToString();
            }
            com.Dispose();
            dr.Dispose();
        }

        private void cmbCusName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            com = new SqlCommand("select cusID , cusContact from tbCustomer where cusName = '"+cmbCusName.Text+"'", Myoper.con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtCusID.Text = dr[0].ToString();
                txtCusContact.Text = dr[1].ToString();
            }
            com.Dispose();
            dr.Dispose();
        }

        private void btnNewSup_Click(object sender, EventArgs e)
        {
            if (btnNewSup.Text == "New Customer")
            {
                btnNewSup.Text = "Old Customer";
                b = true;
                txtCusID.Text = "Auto Number";
            }
            else
            {
                btnNewSup.Text = "New Customer";
                b = false;
                txtCusID.Text = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] arr = new string[5];
            arr[0] = txtProID.Text;
            arr[1] = cmbProName.Text;
            arr[2] = txtQuantity.Text;
            string price = string.Format("{0:c}", decimal.Parse(txtPrice.Text));
            arr[3] = price;
            decimal amount = decimal.Parse(txtQuantity.Text) * decimal.Parse(txtPrice.Text);
            arr[4] = string.Format("{0:c}", amount);
            total = total + amount;
            ListViewItem item = new ListViewItem(arr);
            listView1.Items.Add(item);
            txtTotalPrice.Text = string.Format("{0:c}", total); ;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dtMaster = new DataTable();
            dtMaster.Columns.Add("SaleDate", typeof(DateTime));
            dtMaster.Columns.Add("EmpID", typeof(string));
            dtMaster.Columns.Add("EmpName", typeof(string));
            dtMaster.Columns.Add("CusID", typeof(int));
            dtMaster.Columns.Add("CusName", typeof(string));
            dtMaster.Columns.Add("CusCon", typeof(string));
            dtMaster.Columns.Add("Total", typeof(Decimal));

            DateTime sda = dtpsaleDate.Value;
            Myoper.empID = 0;
            Myoper.empName = "admin";
            if (b == true)
            {
                 cid = 0;
            }
            string cn = cmbCusName.Text;
            string cc = txtCusContact.Text;
            decimal total = decimal.Parse(txtTotalPrice.Text, NumberStyles.Currency);
            dtMaster.Rows.Add(sda, Myoper.empID, Myoper.empName, cid, cn, cc, total);

            DataTable dtDetail = new DataTable();

            dtDetail.Columns.Add("ProID",typeof(string));
            dtDetail.Columns.Add("ProName",typeof(string));
            dtDetail.Columns.Add("Quantity",typeof(int));
            dtDetail.Columns.Add("up",typeof(decimal));


            DataTable dtInvoice = new DataTable();

            dtInvoice.Columns.Add("ProID",typeof(string));
            dtInvoice.Columns.Add("ProName", typeof(string));
            dtInvoice.Columns.Add("q", typeof(int));
            dtInvoice.Columns.Add("price", typeof(decimal));
            dtInvoice.Columns.Add("amount", typeof(decimal));

            foreach(ListViewItem item in listView1.Items)
            {
                string pid = item.SubItems[0].Text;
                string pn = item.SubItems[1].Text;
                int q = int.Parse(item.SubItems[2].Text);
                decimal up = decimal.Parse(item.SubItems[3].Text, NumberStyles.Currency);
                decimal amount = q * up;
                dtDetail.Rows.Add(pid, pn, q, up);
                dtInvoice.Rows.Add(pid, pn, q, up, amount);
            }
            com = new SqlCommand("insertSale3", Myoper.con);
            com.CommandType = CommandType.StoredProcedure;

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@SM";
            p1.SqlDbType = SqlDbType.Structured;
            p1.Value = dtMaster;
            com.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@SD";
            p2.SqlDbType = SqlDbType.Structured;
            p2.Value = dtDetail;
            com.Parameters.Add(p2);

            com.Parameters.Add("@sid", SqlDbType.Int).Direction = ParameterDirection.Output;
            com.ExecuteNonQuery();
            var ss = int.Parse(com.Parameters["@sid"].Value.ToString());

            frmSaleInvoice frm = new frmSaleInvoice();
            frm.rptViewerSaleInvoice.ProcessingMode = ProcessingMode.Local;
            LocalReport lcr = frm.rptViewerSaleInvoice.LocalReport;
            lcr.DisplayName = "rptSaleInvoice.rdlc";

            ReportDataSource rpds = new ReportDataSource("DataSet1", dtInvoice);
            lcr.DataSources.Clear();
            lcr.DataSources.Add(rpds);

            ReportParameter par1 = new ReportParameter("InvNo", ss.ToString());
            lcr.SetParameters(par1);

            ReportParameter par2 = new ReportParameter("InvDate", dtpsaleDate.Value.ToString());
            lcr.SetParameters(par2);

            ReportParameter par3 = new ReportParameter("EmpID", Myoper.empID.ToString());
            lcr.SetParameters(par3);

            ReportParameter par4 = new ReportParameter("CusID", txtCusID.Text);
            lcr.SetParameters(par4);

            ReportParameter par5 = new ReportParameter("CusName", cmbCusName.Text);
            lcr.SetParameters(par5);

            ReportParameter par6 = new ReportParameter("Total", string.Format("{0:c}", total));
            lcr.SetParameters(par6);

            frm.Show();
            frm.rptViewerSaleInvoice.Refresh();


           

        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

    }
}
