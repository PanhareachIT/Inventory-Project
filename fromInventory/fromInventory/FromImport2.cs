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
    public partial class FromImport2 : Form
    {
        public FromImport2()
        {
            InitializeComponent();
        }
        int sID = 0;
        int supID = 0;
        SqlDataAdapter da;
        SqlCommand com;
        DataTable dt;
        Boolean b = false;
        decimal total;
       
        
        private void fillCmb(string id, string name, string tb, ComboBox bx) 
        {
            da = new SqlDataAdapter("Select "+ id +"," + name + " from " + tb , Myoper.con);
            //da = new SqlDataAdapter("select " + aa + "," + bb + " from " + cc + "", Myoper.con);
          //  da = new SqlDataAdapter("Select proID, proName form tbProduct", Myoper.con);
            dt = new DataTable();
            da.Fill(dt);
            bx.DataSource = dt;
            bx.DisplayMember = name;
            bx.ValueMember = id;



        }
        private void FromImport2_Load(object sender, EventArgs e)
        {
            Myoper.myconnection();
           fillCmb("supID", "supName", "tbSupplier", cmbSupName);
           fillCmb("proID", "proName", "tbProduct", cmbProName);
            fillCmb("catID", "category", "tb_Category", cmbCate);
            txtImpID.Text = "auto Number";
            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("Pro ID ", 100);
            listView1.Columns.Add("Pro Name ", 150);
            listView1.Columns.Add("Qty ", 100);
            listView1.Columns.Add("upis ", 120);
            listView1.Columns.Add("Amount", 130);
            listView1.Columns.Add("Category ", 150);
            listView1.Columns.Add("Category ID",0);

        }

        private void cmbSupName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtSupID.Text = cmbSupName.SelectedValue.ToString();
            com = new SqlCommand("select supContact from tbSupplier where supID = '" + txtSupID.Text+"'", Myoper.con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtSupContact.Text = dr[0].ToString();
            }
            dr.Dispose();
            com.Dispose();
        }

        private void cmbCate_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtProID_TextChanged(object sender, EventArgs e)
        {
            com = new SqlCommand("select catID from tbProduct where proID = '" + txtProID.Text+"'", Myoper.con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                cmbProName.SelectedValue = txtProID.Text;
                cmbCate.SelectedValue = dr[0].ToString();
            }
            dr.Dispose();
            com.Dispose();
        }

        private void cmbProName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtProID.Text = cmbProName.SelectedValue.ToString();
        }

        private void btnNewSup_Click(object sender, EventArgs e)
        {
            if (btnNewSup.Text == "New Supplier")
            {
                b = true;
               
                txtSupID.Text = "Auto Number";
                btnNewSup.Text = "Old Supplier";
            }
            else
            {
                b = false;
                txtSupID.Text = null;
                btnNewSup.Text = "New Supplier";
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal amount ;
            string[] arr = new string[7];
            arr[0] = txtProID.Text;
            arr[1] = cmbProName.Text;
            arr[2] = txtQuantity.Text;
            arr[3] = string.Format("{0:c}",decimal.Parse(txtPrice.Text));
            amount = decimal.Parse( txtQuantity.Text) * decimal.Parse(txtPrice.Text);
            arr[4] = string.Format("{0:c}",amount);
            arr[5] = cmbCate.Text;
            arr[6] = cmbCate.SelectedValue.ToString();
            ListViewItem item =new  ListViewItem(arr);
            listView1.Items.Add(item);
            total = total + amount;
            txtTotalPrice.Text = string.Format("{0:c}", total);


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dtMaster = new DataTable();
            dtMaster.Columns.Add("ImportDate", typeof(DateTime));
            dtMaster.Columns.Add("supID", typeof(int));
            dtMaster.Columns.Add("supName", typeof(string));
            dtMaster.Columns.Add("supCon", typeof(string));
            dtMaster.Columns.Add("empId", typeof(string));
            dtMaster.Columns.Add("empName", typeof(string));
            dtMaster.Columns.Add("Total", typeof(decimal));

            DateTime impDate = dtpImportDate.Value;
            if(b==true){
                supID = 0;
            }
           // string sid = txtSupID.Text;
            string sn = cmbSupName.Text;
            string sc = txtSupContact.Text;
            string eid = "0";
            string en = "admin";

            dtMaster.Rows.Add(impDate, supID, sn, sc, eid, en, total);

            DataTable dtDetail = new DataTable();
            dtDetail.Columns.Add("ProID", typeof(string));
            dtDetail.Columns.Add("ProName", typeof(string));
            dtDetail.Columns.Add("Quantity", typeof(int));
            dtDetail.Columns.Add("UPIS", typeof(decimal));
            dtDetail.Columns.Add("CatID", typeof(int));

            DataTable dtImport = new DataTable();
            dtImport.Columns.Add("ProID", typeof(string));
            dtImport.Columns.Add("ProName", typeof(string));
            dtImport.Columns.Add("qty", typeof(string));
            dtImport.Columns.Add("price", typeof(string));
            dtImport.Columns.Add("amount", typeof(string));

            listView1.Columns.Add("Pro ID ", 100);
            listView1.Columns.Add("Pro Name ", 150);
            listView1.Columns.Add("Qty ", 100);
            listView1.Columns.Add("upis ", 120);
            listView1.Columns.Add("Amount", 130);
            listView1.Columns.Add("Category ", 150);
            listView1.Columns.Add("Category ID",0);
            foreach (ListViewItem item in listView1.Items)
            {
                string pid = item.SubItems[0].Text;
                string pn = item.SubItems[1].Text;
                int q = int.Parse(item.SubItems[2].Text);
                decimal up = decimal.Parse(item.SubItems[3].Text, NumberStyles.Currency);
                int cid = int.Parse(item.SubItems[6].Text);
                decimal amount = q * up; 

                dtDetail.Rows.Add(pid, pn, q, up, cid);
                dtImport.Rows.Add(pid, pn, q, cid, amount);
            }

            com = new SqlCommand("insertImport6", Myoper.con);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@IM";
            p1.SqlDbType = SqlDbType.Structured;
            p1.Value = dtMaster;
            com.Parameters.Add(p1);

            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@ID";
            p2.SqlDbType = SqlDbType.Structured;
            p2.Value =  dtDetail;
            com.Parameters.Add(p2);
            com.ExecuteNonQuery();
            MessageBox.Show("successfully");
            listView1.Items.Clear();


            
            frmReportImport frm = new frmReportImport();
            frmSaleInvoice frmm = new frmSaleInvoice();
            frm.reportViewer1.ProcessingMode = ProcessingMode.Local;

            LocalReport lcrp = frm.reportViewer1.LocalReport ;
            lcrp.DisplayName = "rptImport.rdlc";

            ReportDataSource rpds = new ReportDataSource("DataSet1", dtImport);

            lcrp.DataSources.Clear();
            lcrp.DataSources.Add(rpds);

            ReportParameter par1 = new ReportParameter("invdate", dtpImportDate.Value.ToString());
            lcrp.SetParameters(par1);

            ReportParameter par2 = new ReportParameter("supid", txtSupID.Text);
            lcrp.SetParameters(par2);

            ReportParameter par3 = new ReportParameter("supname", cmbSupName.Text);
            lcrp.SetParameters(par3);

            ReportParameter par4 = new ReportParameter("total", txtTotalPrice.Text);
            lcrp.SetParameters(par4);

            frm.ShowDialog();
            frm.reportViewer1.Refresh();

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }
    }
}
