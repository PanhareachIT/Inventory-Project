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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        SqlCommand com;
        //SqlDataAdapter da;
        DataTable dt;
        int count = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string us = txtUsername.Text.Trim();
            string ps = txtPassword.Text.Trim();
            com = new SqlCommand("Userlogin", Myoper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@uid", us);
            com.Parameters.AddWithValue("@pwd", ps);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Myoper.empID = int.Parse(row[0].ToString());
                Myoper.empName = row[1].ToString();
                Myoper.empPos = row[2].ToString();

                // MessageBox.Show(Myoper.empID + " " + Myoper.empName + " " + Myoper.empPos);
                this.Hide();
                //formSalse fs = new formSalse();
                frmMain frm = new frmMain();
                frm.ShowDialog();
               // fs.ShowDialog();

                this.Close();

            }
            else {
                MessageBox.Show("Username and Password is incorect", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ++count;
            }

            if (count >= 3)
            {
                Application.Exit();
            }
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Myoper.myconnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCreateAccount frm = new frmCreateAccount();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
