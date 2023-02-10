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
    public partial class frmSale : Form
    {
        public frmSale()
        {
            InitializeComponent();
        }
        SqlCommand com;
        SqlDataAdapter da;
        DataTable dt;
        Boolean b = false;
        decimal total;
        int cid;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        public void filldata(string aa,string bb, string cc, ComboBox dd)
        
        {
            
            da = new SqlDataAdapter("select "+aa+","+bb+" from "+cc+"",Myoper.con);
            dt = new DataTable();
            da.Fill(dt);
            dd.DataSource =dt;
            dd.DisplayMember = bb;
            dd.ValueMember = aa;
        }

        private void formSalse_Load(object sender, EventArgs e)
        {
            
            Myoper.myconnection();
            filldata("cusID","cusName","tbcustomer",cmbCusName);
            filldata("proID", "proName", "tbProduct", cmbProName);
            filldata("catID", "category", "tb_Category", cmbCate);
            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("Product ID",150);
            listView1.Columns.Add("Product Name", 200);
            listView1.Columns.Add("Quantity",100);
            listView1.Columns.Add("Unit Price",150);
            listView1.Columns.Add("Amount",100);
            txtSaleID.Text = "Auto Number";
           // txtCusID.Text = "Auto Number";
        }
        private void show_tolist()
        {
            
        }
        private void txtProID_TextChanged(object sender, EventArgs e)
        {
            com = new SqlCommand("select catID,sup from tbProduct where proID = '" + txtProID.Text+"'", Myoper.con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                cmbProName.SelectedValue = txtProID.Text;
                cmbCate.SelectedValue =dr[0].ToString();
                txtPrice.Text = dr[1].ToString();
            }

            com.Dispose();
            dr.Dispose();
            
        }

        private void btnNewSup_Click(object sender, EventArgs e)
        {
            if (btnNewSup.Text == "New Customer")
            {
                b = true;
              
                txtCusID.Text = "Auto Number";
                btnNewSup.Text = "Old Customer";
                
                

            }else{
                b = false;
                btnNewSup.Text = "New Customer";
                txtCusID.Text = null;
                
               
            }
        }

        private void cmbProName_SelectedIndexChanged(object sender, EventArgs e)
        {
           // txtProID.Text = cmbProName.SelectedValue.ToString();
        }

        private void cmbCusName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int cusID = int.Parse(cmbCusName.SelectedValue.ToString());
            com = new SqlCommand("select cusID, cusContact from tbCustomer where cusID = '" + cusID + "'", Myoper.con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtCusContact.Text = dr[1].ToString();
                txtCusID.Text = dr[0].ToString();
            }
            com.Dispose();
            dr.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal t =0;
            string[] arr = new string[5];
            arr[0] = txtProID.Text;
            arr[1] = cmbProName.Text;
            arr[2] = txtQuantity.Text;
            arr[3] = string.Format("{0:c}",decimal.Parse(txtPrice.Text));
            t = decimal.Parse(txtQuantity.Text) * decimal.Parse(txtPrice.Text);
            arr[4] = string.Format("{0:C}", t);
            ListViewItem item = new ListViewItem(arr);
            listView1.Items.Add(item);
            total = total + t;
            txtTotalPrice.Text = string.Format("{0:C}", total);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dtMaster = new DataTable();
            dtMaster.Columns.Add("saleDate", typeof(DateTime));
            dtMaster.Columns.Add("empID", typeof(string));
            dtMaster.Columns.Add("empName", typeof(string));
            dtMaster.Columns.Add("cusID", typeof(string));
            dtMaster.Columns.Add("cusName", typeof(string));
            dtMaster.Columns.Add("cusCon", typeof(string));
            dtMaster.Columns.Add("Total", typeof(decimal));

            DateTime sdate = dtpsaleDate.Value;
            string empID = "1";
            string empName = "Piseth";

            if (b == true)
            {
                cid = 0;
            }
            string cn = cmbCusName.Text;
            string cc = txtCusContact.Text;
            // decimal to = total;
            dtMaster.Rows.Add(sdate, empID, empName, cid, cn, cc, total);


            DataTable dtDetail = new DataTable();
            dtDetail.Columns.Add("ProID", typeof(string));
            dtDetail.Columns.Add("ProName", typeof(string));
            dtDetail.Columns.Add("Qty", typeof(int));
            dtDetail.Columns.Add("Unit Price", typeof(decimal));

            DataTable dtInvoice = new DataTable();
            dtInvoice.Columns.Add("ProID",typeof(string));
            dtInvoice.Columns.Add("ProName",typeof(string));
            dtInvoice.Columns.Add("Qty",typeof(int));
            dtInvoice.Columns.Add("price", typeof(decimal));
            dtInvoice.Columns.Add("Amount",typeof(decimal));
            foreach (ListViewItem item in listView1.Items)
            {
                string pid = item.SubItems[0].Text;
                string pn = item.SubItems[1].Text;
                int qty = int.Parse(item.SubItems[2].Text);
                decimal up = decimal.Parse(item.SubItems[3].Text, NumberStyles.Currency);
                decimal amount = qty * up;
                dtDetail.Rows.Add(pid, pn, qty, up);
                dtInvoice.Rows.Add(pid, pn, qty, amount, amount);
            }
            com = new SqlCommand("inserttSalee", Myoper.con);
            com.CommandType = CommandType.StoredProcedure;

            SqlParameter par1 = new SqlParameter();
            par1.ParameterName = "@SM";
            par1.SqlDbType = SqlDbType.Structured;
            par1.Value = dtMaster;
            com.Parameters.Add(par1);

            SqlParameter par2 = new SqlParameter();
            par2.ParameterName = "@SD";
            par2.SqlDbType = SqlDbType.Structured;
            par2.Value = dtDetail;
            com.Parameters.Add(par2);

            com.Parameters.Add("@sid", SqlDbType.Int).Direction = ParameterDirection.Output;
            com.ExecuteNonQuery();
            
            int ss = int.Parse(com.Parameters["@sid"].Value.ToString());
            frmSaleInvoice FsaleIn = new frmSaleInvoice();
            FsaleIn.rptViewerSaleInvoice.ProcessingMode = ProcessingMode.Local;
            LocalReport localre = FsaleIn.rptViewerSaleInvoice.LocalReport;
            localre.DisplayName = "rptSaleInvoice.rdlc";

            ReportDataSource rds = new ReportDataSource("DataSet1", dtInvoice);
            localre.DataSources.Clear();
            localre.DataSources.Add(rds);
            

            ReportParameter p1 = new ReportParameter("InvNo", ss.ToString());
            FsaleIn.rptViewerSaleInvoice.LocalReport.SetParameters(p1);
            ReportParameter p2 = new ReportParameter("InvDate",dtpsaleDate.Value.ToString());
            FsaleIn.rptViewerSaleInvoice.LocalReport.SetParameters(p2);
            ReportParameter p3 = new ReportParameter("EmpID",empID);
            FsaleIn.rptViewerSaleInvoice.LocalReport.SetParameters(p3);
            ReportParameter p4 = new ReportParameter("CusID", txtCusID.Text);
            FsaleIn.rptViewerSaleInvoice.LocalReport.SetParameters(p4);
            ReportParameter p5 = new ReportParameter("CusName", cmbCusName.Text);
            FsaleIn.rptViewerSaleInvoice.LocalReport.SetParameters(p5);
            ReportParameter p6 = new ReportParameter("Total", total.ToString());
            FsaleIn.rptViewerSaleInvoice.LocalReport.SetParameters(p6);


            FsaleIn.ShowDialog();
            FsaleIn.rptViewerSaleInvoice.Refresh();

            //DataTable dtMaster = new DataTable();
            //dtMaster.Columns.Add("SaleDate", typeof(DateTime));
            //dtMaster.Columns.Add("EmpID", typeof(string));
            //dtMaster.Columns.Add("EmpName", typeof(string));
            //dtMaster.Columns.Add("CusID", typeof(string));
            //dtMaster.Columns.Add("CusName", typeof(string));
            //dtMaster.Columns.Add("CusCon", typeof(string));
            //dtMaster.Columns.Add("Total", typeof(decimal));

            //DateTime sd = dtpsaleDate.Value;
            //string eid = "1";
            //string en = "Piseth";
            //if (b == true)
            //{
            //    cid = 0;
            //}


            //string cn = cmbCusName.Text;
            //string cc = txtCusContact.Text;
            //dtMaster.Rows.Add(sd, eid, en, cid, cn, cc, total);

            //DataTable dtDetail = new DataTable();

            //dtDetail.Columns.Add("ProID", typeof(string));
            //dtDetail.Columns.Add("ProName", typeof(string));
            //dtDetail.Columns.Add("Quantity", typeof(int));
            //dtDetail.Columns.Add("Unit Price", typeof(decimal));

            //DataTable dtInvoice = new DataTable();
            //dtInvoice.Columns.Add("ProID", typeof(string));
            //dtInvoice.Columns.Add("ProName", typeof(string));
            //dtInvoice.Columns.Add("Qty", typeof(int));
            //dtInvoice.Columns.Add("Price", typeof(decimal));
            //dtInvoice.Columns.Add("Amount", typeof(decimal));

            //foreach (ListViewItem item in listView1.Items)
            //{
            //    string pid = item.SubItems[0].Text;
            //    string pn = item.SubItems[1].Text;
            //    int qty = int.Parse(item.SubItems[2].Text);
            //    decimal up = decimal.Parse(item.SubItems[3].Text, NumberStyles.Currency);
            //    decimal am = qty * up;
            //    dtDetail.Rows.Add(pid, pn, qty, up);
            //    dtInvoice.Rows.Add(pid, pn, qty, up, qty * up);
            //}



            //com = new SqlCommand("insertSateee", Myoper.con);
            //com.CommandType = CommandType.StoredProcedure;
            //SqlParameter par1 = new SqlParameter();
            //par1.ParameterName = "@SM";
            //par1.SqlDbType = SqlDbType.Structured;
            //par1.Value = dtMaster;
            //com.Parameters.Add(par1);
            //SqlParameter par2 = new SqlParameter();
            //par2.ParameterName = "@SD";
            //par2.SqlDbType = SqlDbType.Structured;
            //par2.Value = dtDetail;
            //com.Parameters.Add(par2);
            //com.Parameters.Add("@sid", SqlDbType.Int).Direction = ParameterDirection.Output;


            //com.ExecuteNonQuery();
            //var ss = int.Parse(com.Parameters["@sid"].Value.ToString());
            // frmSaleInvoice fsi = new frmSaleInvoice();
            //fsi.rptViewerSaleInvoice.ProcessingMode = ProcessingMode.Local;
            //LocalReport lrpSaleInvoice = fsi.rptViewerSaleInvoice.LocalReport;
            //lrpSaleInvoice.DisplayName = "rptSaleInvoice.rdlc";
            //lrpSaleInvoice.DataSources.Clear();
            //ReportDataSource rds = new ReportDataSource("DataSet1", dtInvoice);
            //lrpSaleInvoice.DataSources.Add(rds);

            //ReportParameter p1 = new ReportParameter("InvNo", string.Format("{0:000000}",ss.ToString()));
            //lrpSaleInvoice.SetParameters(p1);

            //ReportParameter p2 = new ReportParameter("InvDate", dtpsaleDate.Value.ToString("dd-MM-yy"));
            //lrpSaleInvoice.SetParameters(p2);

            //ReportParameter p3 = new ReportParameter("EmpID", Myoper.empID.ToString());
            //lrpSaleInvoice.SetParameters(p3);

            //ReportParameter p4 = new ReportParameter("CusID", txtCusID.Text);
            //lrpSaleInvoice.SetParameters(p4);

            //ReportParameter p5 = new ReportParameter("CusName",cmbCusName.Text);
            //lrpSaleInvoice.SetParameters(p5);

            //ReportParameter p6 = new ReportParameter("Total", txtTotalPrice.Text);
            //lrpSaleInvoice.SetParameters(p6);

            //fsi.Show();
            //fsi.rptViewerSaleInvoice.Refresh();


            ///*MessageBox.Show(ss.ToString());
            MessageBox.Show("successfully");
            listView1.Items.Clear();
            formSalse_Load(sender, e);
           
            

        }

        private void cmbProName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtProID.Text = cmbProName.SelectedValue.ToString();
        }

        private void btnButoon_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmMain fmain = new frmMain();
                this.Hide();
                fmain.ShowDialog();
                this.Close();
            }
        }

        private void cmbCusName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
