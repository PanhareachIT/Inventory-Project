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
using System.IO;
using Microsoft.Reporting.WinForms;
namespace fromInventory
{
    public partial class frmEmployee2 : Form
    {
        public frmEmployee2()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        SqlCommand com;
        byte[] photo;
        string fp;
        private void frmEmployee2_Load(object sender, EventArgs e)
        {
            Myoper.myconnection();
            da = new SqlDataAdapter("select * from tbemployee", Myoper.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSalary_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSalary.Text) || !string.IsNullOrEmpty(txtSalary.Text))
            {
                txtSalary.Text = string.Format("{0:c}", decimal.Parse(txtSalary.Text));
            }
        }

        private void txtSalary_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSalary.Text) || !string.IsNullOrEmpty(txtSalary.Text))
            {
                var ss =    int.Parse(txtSalary.Text, NumberStyles.Currency);
                txtSalary.Text = ss.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fl = new OpenFileDialog();
            fl.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *gif";
            if (fl.ShowDialog() == DialogResult.OK)
            {
                fp = fl.FileName;
                pictureBox1.Image = Image.FromFile(fp);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            string gen;
            DataGridViewRow row = dataGridView1.Rows[i];
            txtEmpId.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value.ToString() == "ស")
            {
                radioGirl.Checked = true;
            }
            else
            {
                radioBoy.Checked = true;
            }
            dtpDOB.Text = row.Cells[3].Value.ToString();
            txtPos.Text = row.Cells[4].Value.ToString();
            txtSalary.Text = row.Cells[5].Value.ToString();
            txtAddress.Text = row.Cells[6].Value.ToString();
            mtbPhone.Text = row.Cells[7].Value.ToString();
            dtpWord.Text = row.Cells[8].Value.ToString();
            photo = (byte[])row.Cells[9].Value;
            MemoryStream ms = new MemoryStream(photo);
            pictureBox1.Image = Image.FromStream(ms);
        }
        private void modify(string x)
        {
            string gender;
            com = new SqlCommand("insertEployee1", Myoper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@i", txtEmpId.Text);
            com.Parameters.AddWithValue("@n", txtName.Text);
            if (radioBoy.Checked)
            {
                gender = "ប";
            }
            else
            {
                gender = "ស";
            }
            com.Parameters.AddWithValue("@g", gender);
            com.Parameters.AddWithValue("@d", dtpDOB.Value);
            com.Parameters.AddWithValue("@po", txtPos.Text);
            com.Parameters.AddWithValue("@s", txtSalary.Text);
            com.Parameters.AddWithValue("@a", txtAddress.Text);
            com.Parameters.AddWithValue("@c", mtbPhone.Text);
            com.Parameters.AddWithValue("@h", dtpWord.Value);
            if (fp != null)
            {
                photo = File.ReadAllBytes(fp);
            }
            com.Parameters.AddWithValue("@pt", photo);
            com.ExecuteNonQuery();
            
            fp = null;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do uint really want to insert", "Insert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                modify("insertEployee1");
                frmEmployee2_Load(sender, e);
                MessageBox.Show("Insert successfully");
            }
        }
      
    }
}
