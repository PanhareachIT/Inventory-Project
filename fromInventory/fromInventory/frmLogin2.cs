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
    public partial class frmLogin2 : Form
    {
        public frmLogin2()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        SqlCommand com;
        DataTable dt;
        private void frmLogin2_Load(object sender, EventArgs e)
        {
            Myoper.myconnection();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            com = new SqlCommand("UserLogin", Myoper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@uid", username);
            com.Parameters.AddWithValue("@pwd", password);
            da = new SqlDataAdapter();
            dt = new DataTable();
            da.SelectCommand = com;
            da.Fill(dt);
            
            if (dt.Rows.Count > 0)
            {
                Myoper.empID = int.Parse(dt.Rows[0][0].ToString());
                Myoper.empName = dt.Rows[0][1].ToString();
                Myoper.empPos = dt.Rows[0][2].ToString();
                MessageBox.Show(Myoper.empID.ToString());
                frmMain frm = new frmMain();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            

        }
    }
}
