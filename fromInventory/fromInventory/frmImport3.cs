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
    public partial class frmImport3 : Form
    {
        public frmImport3()
        {
            InitializeComponent();
        }
        SqlCommand com;
        SqlDataAdapter da;
        DataTable dt;
        int supID;
        bool b = false;
        decimal total;
        private void btnSave_Click(object sender, EventArgs e)
        {
        
        }
        private void fill(string id, string name, string tb, ComboBox cmb)
        {
            da = new SqlDataAdapter("select "+id+", "+name+" from "+tb+" ", Myoper.con);
            dt = new DataTable();
            da.Fill(dt);
            cmb.DataSource = dt;
            cmb.DisplayMember = name;
            cmb.ValueMember = id;
            
            
        }
        private void frmImport3_Load(object sender, EventArgs e)
        {
            Myoper.myconnection();
            fill("supID", "supName", "tbSupplier", cmbSupName);
            fill("proID", "proName", "tbProduct", cmbProName);
            fill("catID", "category", "tb_Category", cmbCate);
            txtImpID.Text = "Auto Number";
            txtImpID.BackColor = Color.Gray;
            listView1.View = View.Details;
            listView1.Items.Clear();
            listView1.Columns.Add("ProID", 150);
            listView1.Columns.Add("ProName", 150);
            listView1.Columns.Add("Quantity", 150);
            listView1.Columns.Add("Unit Price", 150);
            listView1.Columns.Add("Amount", 150);
            listView1.Columns.Add("Category", 150);
            listView1.Columns.Add("CatID", 0);
            //txtImpID.Enabled = false;

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        
        }

        private void cmbProName_SelectionChangeCommitted(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }

        private void btnNewSup_Click(object sender, EventArgs e)
        {
        
        }

        private void cmbSupName_SelectionChangeCommitted(object sender, EventArgs e)
        {
        
        }

        private void txtProID_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            DataTable dtMaster = new DataTable();
            dtMaster.Columns.Add("impDate",typeof(DateTime));
            dtMaster.Columns.Add("SupID",typeof(int));
            dtMaster.Columns.Add("supName",typeof(string));
            dtMaster.Columns.Add("supCon",typeof(string));
            dtMaster.Columns.Add("empID",typeof(string));
            dtMaster.Columns.Add("empName",typeof(string));
            dtMaster.Columns.Add("money",typeof(decimal));
            DateTime ida = dtpImportDate.Value;
            if (b == true)
            {
                supID = 0;
            }
            else
            {
                supID = int.Parse(txtSupID.Text);
            }
            string sn = cmbSupName.Text;
            string sc = txtSupContact.Text;
            Myoper.empID = 0;
            Myoper.empName = "admin";
            decimal money = total;
            dtMaster.Rows.Add(ida, supID, sn, sc, Myoper.empID, Myoper.empName, money);

            DataTable dtReport = new DataTable();
            dtReport.Columns.Add("ProID", typeof(string));
            dtReport.Columns.Add("ProName", typeof(string));
            dtReport.Columns.Add("qty", typeof(string));
            dtReport.Columns.Add("price", typeof(string));
            dtReport.Columns.Add("amount", typeof(string));

            DataTable dtDetail = new DataTable();
            dtDetail.Columns.Add("ProID",typeof(string));
            dtDetail.Columns.Add("ProName",typeof(string));
            dtDetail.Columns.Add("Quantity",typeof(int));
            dtDetail.Columns.Add("UnitPrice",typeof(decimal));
            dtDetail.Columns.Add("CatID",typeof(int));
            foreach (ListViewItem item in listView1.Items)
            {
                string pid = item.SubItems[0].Text;
                string pn = item.SubItems[1].Text;
                int qty = int.Parse(item.SubItems[2].Text);
                decimal up = decimal.Parse(item.SubItems[3].Text, NumberStyles.Currency);
                int cid = int.Parse(item.SubItems[6].Text);
         
                dtDetail.Rows.Add(pid, pn, qty, up, cid);
                dtReport.Rows.Add(pid, pn, qty, item.SubItems[3].Text, item.SubItems[4].Text);
            }
            com = new SqlCommand("insertImport6", Myoper.con);
            com.CommandType = CommandType.StoredProcedure;

            SqlParameter par1 = new SqlParameter();
            par1.Value = dtMaster;
            par1.SqlDbType = SqlDbType.Structured;
            par1.ParameterName = "@IM";

            SqlParameter par2 = new SqlParameter();
            par2.Value = dtDetail;
            par2.SqlDbType = SqlDbType.Structured;
            par2.ParameterName = "@ID";

            com.Parameters.Add(par1);
            com.Parameters.Add(par2);
            com.ExecuteNonQuery();
            MessageBox.Show("successfully");
            frmReportImport frm = new frmReportImport();
            frm.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            LocalReport lcrp = frm.reportViewer1.LocalReport;
            lcrp.DisplayName = "rptImport.rdlc";

            lcrp.DataSources.Clear();

            ReportDataSource rpds = new ReportDataSource("DataSet1", dtReport);
            lcrp.DataSources.Add(rpds);
            

            ReportParameter p1 = new ReportParameter("invdate", dtpImportDate.Value.ToString("dd-MM-yy"));
            lcrp.SetParameters(p1);
            ReportParameter p2 = new ReportParameter("supname", cmbSupName.Text);
            lcrp.SetParameters(p2);
            ReportParameter p3 = new ReportParameter("supid", txtSupID.Text);
            lcrp.SetParameters(p3);
            ReportParameter p4 = new ReportParameter("total", string.Format("{0:c}", total));
            lcrp.SetParameters(p4);

            frm.ShowDialog();
            frm.reportViewer1.Refresh();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPrice.Text) || !string.IsNullOrEmpty(txtPrice.Text))
            {
                txtPrice.Text = string.Format("{0:c}", decimal.Parse(txtPrice.Text));
            }
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPrice.Text) || !string.IsNullOrEmpty(txtPrice.Text))
            {

                var ss = int.Parse(txtPrice.Text, NumberStyles.Currency);
                txtPrice.Text = ss.ToString();
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbProName_SelectionChangeCommitted_1(object sender, EventArgs e)

        {
            int n = int.Parse(cmbProName.SelectedValue.ToString());
            com = new SqlCommand("select proID, catID from tbProduct where proID = '"+n+"'", Myoper.con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtProID.Text = dr[0].ToString();
                cmbCate.SelectedValue = dr[1].ToString();
            }
            com.Dispose();
            dr.Dispose();
        }

        private void txtProID_TextChanged_1(object sender, EventArgs e)
        {
            cmbProName.SelectedValue = txtProID.Text;
        }

        private void cmbSupName_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            int n = int.Parse(cmbCate.SelectedValue.ToString());
            com = new SqlCommand("select supID, supContact from tbSupplier where supID = '"+n+"'", Myoper.con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtSupContact.Text = dr[1].ToString();
                txtSupID.Text = dr[0].ToString();
             }
            com.Dispose();
            dr.Dispose();

        }

        private void btnNewSup_Click_1(object sender, EventArgs e)
        {
            if (btnNewSup.Text == "New Supplier")
            {
                btnNewSup.Text = "Old Supplier";
                b = true;
                txtSupID.Text = "Auto Number";

            }
            else
            {
                btnNewSup.Text = "New Supplier";
                txtSupID.Text = cmbSupName.SelectedValue.ToString();
                b = false;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string[] arr = new string[7];
            arr[0] = txtProID.Text;
            arr[1] = cmbProName.Text;
            arr[2] = txtQuantity.Text;
            decimal price = decimal.Parse(txtPrice.Text, NumberStyles.Currency);
            decimal amount = int.Parse(txtQuantity.Text) * price;
            arr[3] = txtPrice.Text;
            arr[4] = string.Format("{0:c}", amount);
            arr[5] = cmbCate.Text;
            arr[6] = cmbCate.SelectedValue.ToString();
            ListViewItem item = new ListViewItem(arr);
            listView1.Items.Add(item);
            total = total + amount;
            txtTotalPrice.Text = string.Format("{0:c}", total);

        }
       
        
        
    }
}
