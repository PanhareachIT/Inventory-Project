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

namespace fromInventory
{
    public partial class FormCategory1 : Form
    {
        public FormCategory1()
        {
            InitializeComponent();
        }
        SqlCommand com;
        SqlDataAdapter dr;
        DataTable dt,dt1;
        private void load_dataCate()
        {

            dr = new SqlDataAdapter("select * From dbo.getCategory()", Myoper.con);
            dt = new DataTable();
            dr.Fill(dt);
            dt1 = new DataTable();
            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("ID",70);
            listView1.Columns.Add("Category",130);
            string []arr =  new string[2];
            for(int i=0; i<dt.Rows.Count; ++i)
            {
                DataRow row = dt.Rows[i];
                arr[0] = row[0].ToString();
                arr[1]= row[1].ToString();
                ListViewItem item = new ListViewItem(arr);
                listView1.Items.Add(item);
            }
            dr.Dispose();
            dt.Dispose();
 
           
                
           
        }
        private void FormCategory_Load(object sender, EventArgs e)
        {
            
            
            
            
        }

        private void txtNew_Click(object sender, EventArgs e)
        {
         
           
            
        }

        private void FormCategory_Load_1(object sender, EventArgs e)
        {
            Myoper.myconnection();
            load_dataCate();
        }
        private void modify(string x)
        {
            com = new SqlCommand(x, Myoper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@i", txtNum.Text);
            com.Parameters.AddWithValue("@c", txtName.Text);

            com.ExecuteNonQuery();
        }
            
        private void txtSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do u want to add ","Add",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                modify("addCategory");
                MessageBox.Show("Added successfully");
                FormCategory_Load_1(sender,e);
            }
            else
            {
                return;
                }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do u want to add ", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                modify("updateCatetory");
                MessageBox.Show("Update successfully");
                FormCategory_Load_1(sender, e);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                txtNum.Text = item.SubItems[0].Text;
                txtName.Text = item.SubItems[1].Text;
            }

        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmMain fmain = new frmMain();
                this.Hide();
                fmain.ShowDialog();
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            com = new SqlCommand("setCatByTxt",Myoper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@c",textBox1.Text);
            
            dr = new SqlDataAdapter();
            dr.SelectCommand = com;
            dt = new DataTable();
            dr.Fill(dt);
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("ID",200);
            listView1.Columns.Add("Category",200);
            string []arr = new string[2];
            for(int i=0; i<dt.Rows.Count; ++i){
                DataRow row = dt.Rows[i];
                arr[0] = row[0].ToString();
                arr[1] = row[1].ToString();
                ListViewItem item = new ListViewItem(arr);
                listView1.Items.Add(item);
            }
            if (dt.Rows.Count < 1)
            {
                com = new SqlCommand("setCatByID", Myoper.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", textBox1.Text);

                dr = new SqlDataAdapter();
                dr.SelectCommand = com;
                dt = new DataTable();
                dr.Fill(dt);
                listView1.Items.Clear();
                listView1.View = View.Details;
                listView1.Columns.Add("ID", 200);
                listView1.Columns.Add("Category", 200);
                string[] arrr = new string[2];
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    DataRow row = dt.Rows[i];
                    arrr[0] = row[0].ToString();
                    arrr[1] = row[1].ToString();
                    ListViewItem item = new ListViewItem(arrr);
                    listView1.Items.Add(item);
                }
            }

            //com.Dispose();
            //dr.Dispose();
        //    com = new SqlCommand("getCategoryByText", Myoper.con);
        //    com.CommandType = CommandType.StoredProcedure;
        //    com.Parameters.AddWithValue("@c", textBox1.Text);
        //    dr = new SqlDataAdapter();
        //    dt = new DataTable();
        //    dr.SelectCommand = com;
        //    dr.Fill(dt);
        //    listView1.Clear();
        //    listView1.View = View.Details;
        //    listView1.Columns.Add("ID");
        //    listView1.Columns.Add("Category");
        //    string[] arr = new string[2];
        //    for (int i = 0; i < dt.Rows.Count; ++i)
        //    {
        //        DataRow row = dt.Rows[i];
        //        arr[0] = row[0].ToString();
        //        arr[1] = row[1].ToString();
        //        ListViewItem item = new ListViewItem(arr);
        //        listView1.Items.Add(item);
        //    }
        //    if (dt.Rows.Count < 1)
        //    {
        //        com = new SqlCommand("getCategoryByID", Myoper.con);
        //        com.CommandType = CommandType.StoredProcedure;
        //        com.Parameters.AddWithValue("@i", textBox1.Text);
        //        dr = new SqlDataAdapter();
        //        dt = new DataTable();
        //        dr.SelectCommand = com;
        //        dr.Fill(dt);
        //        listView1.Clear();
        //        listView1.View = View.Details;
        //        listView1.Columns.Add("ID");
        //        listView1.Columns.Add("Category");
        //        //string []arr = new string[2];
        //        for (int i = 0; i < dt.Rows.Count; ++i)
        //        {
        //            DataRow row = dt.Rows[i];
        //            arr[0] = row[0].ToString();
        //            arr[1] = row[1].ToString();
        //            ListViewItem item = new ListViewItem(arr);
        //            listView1.Items.Add(item);
        //        }
        //    }
        }

        }
    }

