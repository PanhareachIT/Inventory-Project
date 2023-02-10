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
    public partial class frmSale2 : Form
    {
        public frmSale2()
        {
            InitializeComponent();
        }
        SqlCommand com;
        SqlDataAdapter da;
        DataTable dt;
        Boolean b = false;
        int cid;
        decimal total;
        public void fillCbo(string id, string name, string table, ComboBox cbo)
        {
            da = new SqlDataAdapter("select "+id+", "+name+" from "+table+"", Myoper.con);
            dt = new DataTable();
            da.Fill(dt);
            cbo.DataSource = dt;
            cbo.DisplayMember = name;
            cbo.ValueMember = id;
            cbo.Text = null;
        }
        private void frmSale2_Load(object sender, EventArgs e)
        {
            Myoper.myconnection();
            fillCbo("proID", "proName", "tbProduct", cmbProName);
            fillCbo("catID", "category", "tb_Category",cmbCate);
            fillCbo("cusID", "cusName", "tbCustomer", cmbCusName);
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("ProID", 150);
            listView1.Columns.Add("ProName", 150);
            listView1.Columns.Add("Quantity", 150);
            listView1.Columns.Add("Unit Price", 150);
            listView1.Columns.Add("Amount", 150);
            txtSaleID.Text = "Auto Number";
            txtSaleID.ForeColor = Color.Gray;
            txtCusID.ForeColor = Color.Gray;
        }

        private void cmbProName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtProID.Text = cmbProName.SelectedValue.ToString();
        }

        private void txtProID_TextChanged(object sender, EventArgs e)
        {
            com =new SqlCommand("select catID from tbProduct where proID = '"+txtProID.Text+"'",Myoper.con);
            SqlDataReader dr  = com.ExecuteReader();
            while(dr.Read()){
               
                cmbCate.SelectedValue = dr[0].ToString();
                cmbProName.SelectedValue = txtProID.Text;

            }
            com.Dispose();
            dr.Dispose();
        }

        private void btnNewSup_Click(object sender, EventArgs e)
        {
            if (btnNewSup.Text == "New Customer")
            {
                b = true;
                btnNewSup.Text = "Old Customer";
                txtCusID.Text = "Auto Number";
            }
            else
            {
                btnNewSup.Text = "New Customer";
                txtCusID.Text = null;

            }
        }

        private void cmbCusName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int a = int.Parse(cmbCusName.SelectedValue.ToString());
            com = new SqlCommand("select cusID, cusName, cusContact from tbCustomer where cusID = '"+a+"'", Myoper.con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtCusID.Text = dr[0].ToString();
                txtCusContact.Text = dr[2].ToString();
            }
            com.Dispose();
            dr.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] arr = new string[5];
            arr[0] = txtProID.Text;
            arr[1] = cmbProName.Text;
            arr[2] = txtQuantity.Text;
            arr[3] = string.Format("{0:c}", decimal.Parse(txtPrice.Text));
            
            decimal sum = decimal.Parse(txtQuantity.Text) * decimal.Parse(txtPrice.Text);
            total = total + sum;
            arr[4] = string.Format("{0:c}", sum);
            ListViewItem item = new ListViewItem(arr);
            listView1.Items.Add(item);
            txtTotalPrice.Text = string.Format("{0:c}",total);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dtMaster = new DataTable();
            dtMaster.Columns.Add("SaleDate",typeof(DateTime));
            dtMaster.Columns.Add("EmpID",typeof(int));
            dtMaster.Columns.Add("EmpName",typeof(string));
            dtMaster.Columns.Add("CusID",typeof(int));
            dtMaster.Columns.Add("CusName",typeof(string));
            dtMaster.Columns.Add("CusCon",typeof(string));
            dtMaster.Columns.Add("Totala",typeof(decimal));

            DateTime sda = dtpsaleDate.Value;
            int eid = Myoper.empID;
            string en = Myoper.empName;
            if (b == true)
            {
                cid = 0;
            }
            string cn = cmbCusName.Text;
            string cc = txtCusContact.Text;
            decimal to = total;
            dtMaster.Rows.Add(sda, eid, en, cid, cn, cc, to);

            DataTable dtDetail = new DataTable();
            dtDetail.Columns.Add("ProID", typeof(string));
            dtDetail.Columns.Add("ProName", typeof(string));
            dtDetail.Columns.Add("Quantity", typeof(int));
            dtDetail.Columns.Add("Unit Price", typeof(decimal));

            foreach (ListViewItem item in listView1.Items)
            {
                string pid = item.SubItems[0].Text;
                string pn = item.SubItems[1].Text;
                int qty = int.Parse(item.SubItems[2].Text);
                decimal un = decimal.Parse(item.SubItems[3].Text, NumberStyles.Currency);
                dtDetail.Rows.Add(pid, pn, qty, un);
            }


            com = new SqlCommand("insertsale1", Myoper.con);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter par1 = new SqlParameter();
            par1.ParameterName = "@SM";
            par1.SqlDbType = SqlDbType.Structured;
            par1.Value = dtMaster;

            SqlParameter par2 = new SqlParameter();
            par1.ParameterName = "@SD";
            par1.SqlDbType = SqlDbType.Structured;
            par1.Value = dtDetail;
            com.Parameters.Add("@sid", SqlDbType.Int).Direction = ParameterDirection.Output;
            com.ExecuteNonQuery();
            var ss = int.Parse(com.Parameters["@sid"].Value.ToString());
            MessageBox.Show(ss.ToString());

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
