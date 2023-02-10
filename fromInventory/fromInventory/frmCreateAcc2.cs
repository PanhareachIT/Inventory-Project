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
    public partial class frmCreateAcc2 : Form
    {
        public frmCreateAcc2()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        SqlCommand com;
        DataTable dt;
        string eid;
        string epos;
        string en;
        string pw;
        string us;
        private void btnClose_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
        private void fillCbo()
        {
            da = new SqlDataAdapter("select empID, empName from createNonUser()", Myoper.con);
            dt = new DataTable();
            da.Fill(dt);
            cmbUser.DataSource = null;
            cmbUser.Items.Clear();
            cmbUser.DataSource = dt;
            cmbUser.DisplayMember = "empName";
            cmbUser.ValueMember = "empID";


        }
        private void fillListBox()
        {
            Myoper.empID = 0;
            Myoper.empName = "admin";
            string sql = "select empID, username from GetUser()";
            string sql1 = "select empID, username from getauser('"+Myoper.empID+"')";
            if (Myoper.empID == 0 && Myoper.empName == "admin")
            {
                da = new SqlDataAdapter(sql, Myoper.con);
            }
            else
            {
                da = new SqlDataAdapter(sql1, Myoper.con);
            }
            dt = new DataTable(); 
            da.Fill(dt);
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "username";
            listBox1.ValueMember = "empID";
        }
        private void frmCreateAcc2_Load(object sender, EventArgs e)
        {
            Myoper.myconnection();
            fillListBox();
            fillCbo();
        }


        private void modify(string x)
        {
            com = new SqlCommand(x, Myoper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@i",eid);
            com.Parameters.AddWithValue("@en",cmbUser.Text);
            com.Parameters.AddWithValue("@us", txtaccount.Text);
            com.Parameters.AddWithValue("@pw",txtPassword.Text);
            com.Parameters.AddWithValue("@ep", epos);
            com.ExecuteNonQuery();
            MessageBox.Show("successfully");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtaccount.Text)){
                MessageBox.Show("can not null");
                return ;
            }
            if(txtPassword.Text!=txtConfirmPassword.Text){
                MessageBox.Show("password and confrim password can not different");
                return ;
            }
            modify("createAcc");
            frmCreateAcc2_Load(sender, e);
        }

     

        private void cmbUser_SelectionChangeCommitted(object sender, EventArgs e)
        {
           eid = cmbUser.SelectedValue.ToString();
           dt = new DataTable();
           da = new SqlDataAdapter("select pos from tbemployee where empID ='"+eid+"'", Myoper.con);
           da.Fill(dt);
           if (dt.Rows.Count > 0)
           {
               epos = dt.Rows[0][0].ToString();
           }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ii = "113";
          
        }
    }
}
