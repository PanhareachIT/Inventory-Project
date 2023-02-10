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

namespace fromInventory
{
    public partial class ImportForm : Form
    {
        public ImportForm()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        SqlCommand com;
        DataTable dt;
        Boolean b = false;
        decimal total;
        int supID;
        private void load_data()
        {
            da = new SqlDataAdapter("Select supID, supName from tbSupplier", Myoper.con);
            dt = new DataTable();
            da.Fill(dt);
            cmbSupName.Items.Clear();
            cmbSupName.DataSource = dt;
            cmbSupName.DisplayMember = "supName";
            cmbSupName.ValueMember = "supID";
            cmbSupName.Text= null;
        }
        private void load_datacate()
        {
            da = new SqlDataAdapter("select CatID, category From tb_Category", Myoper.con);
            dt = new DataTable();
            da.Fill(dt);
            cmbProType.Items.Clear();
            cmbProType.DataSource = dt;
            cmbProType.DisplayMember = "category";
            cmbProType.ValueMember = "CatID";
            cmbProType.Text = "";
           
        }
        private void load_dataPro()
        {
            da = new SqlDataAdapter("select proID, proName from  tbProduct", Myoper.con);
            dt = new DataTable();
            da.Fill(dt);
            cmbProName.Items.Clear();
            cmbProName.DataSource = dt;
            cmbProName.DisplayMember = "proName";
            cmbProName.ValueMember = "proID";
            cmbProName.Text = "";
        

        }
        private void ImportForm_Load(object sender, EventArgs e)
        {
            Myoper.myconnection();
            load_data();
            load_datacate();
            load_dataPro();
            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("Product ID", 100);
            listView1.Columns.Add("Product Name", 200);
            listView1.Columns.Add("Quantity", 100);
            listView1.Columns.Add("Unit Price", 100);
            listView1.Columns.Add("Amount", 100);
            listView1.Columns.Add("Category", 150);
            listView1.Columns.Add("Category ID", 00000);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            decimal amount;
            //ListView item;
            string []arr = new string[7];
            
            arr[0] = txtProCode.Text;
            arr[1] = cmbProName.Text;
            arr[2] = txtQuantity.Text;
            arr[3] = string.Format("{0:C}", int.Parse(txtPrice.Text));
            amount = decimal.Parse(txtQuantity.Text) * decimal.Parse(txtPrice.Text);
            arr[4] = string.Format("{0:C}", amount);
            arr[5] = cmbProType.Text;
            arr[6] = cmbProType.SelectedValue.ToString();
            ListViewItem item = new ListViewItem(arr);
            listView1.Items.Add(item);
            total= total + amount;
            txtTotalPrice.Text = string.Format("{0:C}", total);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbimportID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int num = int.Parse(cmbSupName.SelectedValue.ToString());
            com = new SqlCommand("Select supID, supContact from tbSupplier where supID ="+num , Myoper.con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtSupID.Text = dr[0].ToString();
                txtRelation.Text = dr[1].ToString();
            }
            dr.Dispose();
            com.Dispose();
        }

        private void cmbimportID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtProCode.Text = cmbProName.SelectedValue.ToString();
            com = new SqlCommand("select catID from tbProduct where proID = '" + txtProCode.Text + "'", Myoper.con);
            SqlDataReader dr = com.ExecuteReader() ;
            while (dr.Read())
            {
                cmbProType.SelectedValue = int.Parse(dr[0].ToString());
            }
            dr.Dispose();
            com.Dispose();
        }

        private void txtProCode_TextChanged(object sender, EventArgs e)
        {
            com = new SqlCommand("select catID from tbProduct where proID = '"
                + txtProCode.Text + "'", Myoper.con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                cmbProType.SelectedValue = int.Parse(dr[0].ToString());
                cmbProName.SelectedValue = txtProCode.Text;
                
            }
            com.Dispose();
            dr.Dispose();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dtMaster = new DataTable();
            dtMaster.Columns.Add("ImpDate",typeof(DateTime));
            dtMaster.Columns.Add("SupID",typeof(int));
            dtMaster.Columns.Add("SupName",typeof(string));
            dtMaster.Columns.Add("SupContact",typeof(string));
            dtMaster.Columns.Add("EmpID",typeof(string));
            dtMaster.Columns.Add("EmpNme",typeof(string));
            dtMaster.Columns.Add("Amount", typeof(decimal));

            DateTime impDate = dtpImportDate.Value;
            int sid = int.Parse(txtSupID.Text);
            string sn = cmbSupName.Text;
            string sc = txtRelation.Text;
            string eid = Myoper.empID.ToString();
            string en = Myoper.empName.ToString();
            decimal Total = total;

            dtMaster.Rows.Add(impDate, sid, sn, sc, eid, en, Total);

            DataTable dtDetail = new DataTable();
            dtDetail.Columns.Add("ProID",typeof(string));
            dtDetail.Columns.Add("ProName",typeof(string));
            dtDetail.Columns.Add("Quantity",typeof(int));
            dtDetail.Columns.Add("Unit Price",typeof(decimal));
            dtDetail.Columns.Add("CatID",typeof(int));

            foreach (ListViewItem item in listView1.Items)
            {
                string pid = item.SubItems[0].Text;
                string pn = item.SubItems[1].Text;
                int qty = int.Parse(item.SubItems[2].Text);
                decimal unp = decimal.Parse(item.SubItems[3].Text, NumberStyles.Currency);
                int cid = int.Parse(item.SubItems[6].Text);

                dtDetail.Rows.Add(pid, pn, qty, unp, cid);
            }

            com = new SqlCommand("inserttttImporttttt", Myoper.con);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter par1 = new SqlParameter();
            par1.ParameterName = "@IM";
            par1.SqlDbType = SqlDbType.Structured;
            par1.Value = dtMaster;
            com.Parameters.Add(par1);

            SqlParameter par2 = new SqlParameter();
            par2.ParameterName = "@ID";
            par2.SqlDbType = SqlDbType.Structured;
            par2.Value = dtDetail;
            com.Parameters.Add(par2);
            com.ExecuteNonQuery();
            MessageBox.Show("successfully");
        }
            

        private void txtSupID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; ++i)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items[1].Remove();
                }

            }
            
        }

        private void cmbProType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpImportDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRelation_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ប្រភេទទំនិញ_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    } 
}
