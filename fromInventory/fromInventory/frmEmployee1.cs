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
    public partial class frmEmployee1 : Form
    {
        public frmEmployee1()
        {
            InitializeComponent();
        }
        string fp;
        byte[] photo;
        SqlCommand com;
        SqlDataAdapter da;
        DataTable dt ;
        decimal salary;
        private void frmEmployee1_Load(object sender, EventArgs e)
        {
            Myoper.myconnection();
            da = new SqlDataAdapter("select * from tbEmployee", Myoper.con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
           
            //txtNum.Text = "Auto Number";
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
            if (!string.IsNullOrEmpty(txtSalary.Text) || !string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                txtSalary.Text = string.Format("{0:c}", decimal.Parse(txtSalary.Text));
            }
        }

        private void txtSalary_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSalary.Text) || !string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                var ss = int.Parse(txtSalary.Text, NumberStyles.Currency).ToString();
                salary = decimal.Parse(ss);
                txtSalary.Text = ss;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fl = new OpenFileDialog();
            fl.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (fl.ShowDialog() == DialogResult.OK)
            {
                fp = fl.FileName;
                pictureBox1.Image = Image.FromFile(fl.FileName);
            }
        }
        public void modify(string x)
        {
            com = new SqlCommand(x, Myoper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@i", txtNum.Text);
            com.Parameters.AddWithValue("@n", txtName.Text);
            if(radioBoy.Checked==true){
                com.Parameters.AddWithValue("@g","ប");
            }else{
                com.Parameters.AddWithValue("@g","ស");
            }
            
            com.Parameters.AddWithValue("@d", dtpDOB.Value);
            com.Parameters.AddWithValue("@po", txtPos.Text);
            com.Parameters.AddWithValue("@s", salary);
            com.Parameters.AddWithValue("@a", txtAddress.Text);
            com.Parameters.AddWithValue("@c", mtbPhone.Text);
            com.Parameters.AddWithValue("@h", dtpWord.Value);
            if (fp != null)
            {
                photo = File.ReadAllBytes(fp);
                com.Parameters.AddWithValue("@pt", photo);
            }
            else
            {
                com.Parameters.AddWithValue("@pt", photo);
            }
            
            com.ExecuteNonQuery();
            fp = null;
            MessageBox.Show("successfully");
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do u really 1 to insert", "Insert", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                modify("insertEployee");
                MessageBox.Show("successfully");
                frmEmployee1_Load(sender, e);
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int num = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[num];
            txtNum.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value.ToString() == "ស")
            {
                radioGirl.Checked = true;
            }
            else
            {
                radioBoy.Checked = true;
            }
            dtpDOB.CustomFormat = "dd/MM/yy";
            dtpDOB.Text = row.Cells[3].Value.ToString();
            txtPos.Text = row.Cells[4].Value.ToString();
            txtSalary.Text = row.Cells[5].Value.ToString();
            txtAddress.Text = row.Cells[6].Value.ToString();
            mtbPhone.Text = row.Cells[7].Value.ToString();
            dtpWord.CustomFormat = "dd/MM/yy";
            dtpWord.Text = row.Cells[8].Value.ToString();
            photo = (byte[])row.Cells[9].Value;
            MemoryStream ms = new MemoryStream(photo);
            pictureBox1.Image = Image.FromStream(ms);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do u really one to UPdate", "Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                modify("UpdateEmployee");
                MessageBox.Show("successfully");
                frmEmployee1_Load(sender, e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do u really one to delete", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                modify("DeleteEmployee");
                MessageBox.Show("successfully");
                frmEmployee1_Load(sender, e);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            com = new SqlCommand("searchEmpName", Myoper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@em", txtSearch.Text);
            com.ExecuteNonQuery();
            da = new SqlDataAdapter();
            da.SelectCommand = com;
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count < 1)
            {
                com = new SqlCommand("searchEmpByID", Myoper.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@eid", txtSearch.Text);
                com.ExecuteNonQuery();
                da = new SqlDataAdapter();
                da.SelectCommand = com;
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            com.Dispose();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string gen;
            if (MessageBox.Show("Do u really one to print all", "print", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable dtEmpList = new DataTable();

                dtEmpList.Columns.Add("empid", typeof(string));
                dtEmpList.Columns.Add("empName", typeof(string));
                dtEmpList.Columns.Add("empGender", typeof(string));
                dtEmpList.Columns.Add("empDob", typeof(string));
                dtEmpList.Columns.Add("empPos", typeof(string));
                dtEmpList.Columns.Add("empSal", typeof(string));
                dtEmpList.Columns.Add("empAdd", typeof(string));
                dtEmpList.Columns.Add("empCon", typeof(string));
                dtEmpList.Columns.Add("empDire", typeof(string));
                dtEmpList.Columns.Add("empPhoto", typeof(byte[]));

                foreach(DataGridViewRow row in dataGridView1.Rows){
                    dtEmpList.Rows.Add(row.Cells[0].Value.ToString(),
                                        row.Cells[1].Value.ToString(),
                                        row.Cells[2].Value.ToString(),
                                        row.Cells[3].Value.ToString(),
                                        row.Cells[4].Value.ToString(),
                                        row.Cells[5].Value.ToString(),
                                        row.Cells[6].Value.ToString(),
                                        row.Cells[7].Value.ToString(),
                                        row.Cells[8].Value.ToString(),
                                        row.Cells[9].Value
                        );
                }
                frmRptEmpList frm = new frmRptEmpList();
                frm.rptViewerEmpList.ProcessingMode = ProcessingMode.Local;

                LocalReport lcrp = frm.rptViewerEmpList.LocalReport;
                lcrp.DisplayName = "rptEmpList.rdlc";

                ReportDataSource rpds = new ReportDataSource("dsEmpList", dtEmpList);

                lcrp.DataSources.Clear();
                lcrp.DataSources.Add(rpds);

                frm.Show();
                frm.rptViewerEmpList.Refresh();

                

            }
            else
            {
                frmRptEmp frm = new frmRptEmp();
                frm.rptViewerEmp.ProcessingMode = ProcessingMode.Local;

                LocalReport lcrp = frm.rptViewerEmp.LocalReport;
                lcrp.DisplayName = "rptEmp.rdlc";

                ReportParameter p1 = new ReportParameter("eid", txtNum.Text);
                lcrp.SetParameters(p1);

                ReportParameter p2 = new ReportParameter("edob", dtpDOB.Value.ToString());
                lcrp.SetParameters(p2);

                ReportParameter p3 = new ReportParameter("ehire", dtpWord.Value.ToString());
                lcrp.SetParameters(p3);

                ReportParameter p4 = new ReportParameter("esal", salary.ToString());
                lcrp.SetParameters(p4);

                ReportParameter p5 = new ReportParameter("ename", txtName.Text);
                lcrp.SetParameters(p5);

                ReportParameter p6 = new ReportParameter("epos", txtPos.Text);
                lcrp.SetParameters(p6);
                if (radioBoy.Checked == true)
                {
                    gen = "ប្រុស";
                }
                else
                {
                    gen = "ស្រី";
                }
                ReportParameter p7 = new ReportParameter("egen", gen);
                lcrp.SetParameters(p7);

                frm.Show();
                frm.rptViewerEmp.Refresh();
            }
        }

    }
}
