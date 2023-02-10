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
using System.Data;
namespace fromInventory
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }
        Boolean b;
        string eid = "0";
        string pos = "";
        int eeid;
        SqlCommand com;
        SqlDataAdapter da;
        DataTable dt;
        int id;
        public void filList()
        {
            string sql = "select * from GetUser()";  
            string sql1 = "select * from getauser("+Myoper.empID+")";
           // da = new SqlDataAdapter(sql1, Myoper.con);
            if (Myoper.empID == 0 || Myoper.empPos == "admin")
            {
                da = new SqlDataAdapter(sql, Myoper.con);
            }
            else
            {
                da = new SqlDataAdapter(sql1, Myoper.con);
            }
           /* da = new SqlDataAdapter("select * from GetUser()", Myoper.con);*/
            dt = new DataTable();
            da.Fill(dt);
          /*/comboBox1.Items.Clear();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "username";
            comboBox1.ValueMember = "empID";*/
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            
            listBox1.DataSource = dt;
          //  listBox1.DisplayMember = " empID";
         //   listBox1.ValueMember = "username";
            listBox1.DisplayMember = "username";
            listBox1.ValueMember = "empID";
        }
        
        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            
            Myoper.myconnection();
            filList();
            fillCmb();
        }
        private void fillCmb()
        {
            da = new SqlDataAdapter("Select empName, empID from createNonUser()", Myoper.con);
            dt = new DataTable();
            da.Fill(dt);
            //cmbUser.Items.Clear();
            cmbUser.DataSource = dt;
            cmbUser.DisplayMember = "empName";
            cmbUser.ValueMember = "empID";
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            fillCmb();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                txtaccount.Text = listBox1.Text;
                 id = int.Parse(listBox1.SelectedValue.ToString());
                //txtaccount.Text = id.ToString();
               da = new SqlDataAdapter("select empID , empName from tbUser where empID = " +id,Myoper.con);
                dt = new DataTable();
                da.Fill(dt);
                cmbUser.DataSource = null;
                cmbUser.Items.Clear();
                cmbUser.DataSource = dt;
                cmbUser.DisplayMember = "empName";
                cmbUser.ValueMember ="empID";

            }
        }
        private void modify(string x)
        {
            com = new SqlCommand(x, Myoper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@i", eid);
            com.Parameters.AddWithValue("@en", cmbUser.Text);
            com.Parameters.AddWithValue("@us", txtaccount.Text);
            com.Parameters.AddWithValue("@pw", txtPassword.Text);
            com.Parameters.AddWithValue("@ep", pos);

            com.ExecuteNonQuery();
            com.Dispose();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do u really want to delete ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                txtPassword.Text = id.ToString();
                com = new SqlCommand("deeAccount", Myoper.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@i", id);
                com.ExecuteNonQuery();
                MessageBox.Show("successfully");
                frmCreateAccount_Load(sender, e);
            }
            else
            {
                MessageBox.Show("unsuccessfully");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtaccount.Text.Trim()))
            {
                MessageBox.Show("can not be null");
                return;
            }
            if(string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("can not be null");
                return;
            }
            if(string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                MessageBox.Show("can not be null");
                return;
            }
            if(txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password and Confirm Password is different");
                return ;
            }
            modify("createAcc");
            frmCreateAccount_Load(sender, e);
            
        }

        private void cmbUser_SelectionChangeCommitted(object sender, EventArgs e)
        {
            eid = cmbUser.SelectedValue.ToString();
            da = new SqlDataAdapter("select pos from tbemployee where empID = '" + eid + "'", Myoper.con);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                pos = dt.Rows[0][0].ToString();


            }
            else {
                MessageBox.Show("Dont have row");
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtaccount.Text.Trim()))
            {
                MessageBox.Show("can not be null");
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("can not be null");
                return;
            }
            if (string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                MessageBox.Show("can not be null");
                return;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password and Confirm Password is different");
                return;
            }
            modify("updateAcc");
            frmCreateAccount_Load(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormLogin frm = new FormLogin();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtaccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
