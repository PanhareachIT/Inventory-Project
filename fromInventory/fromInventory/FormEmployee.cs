using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using System.IO;
using Microsoft.Reporting.WinForms;
namespace fromInventory
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }
        string fp;
        Boolean b;
        SqlCommand com;
        byte[] photo;
        
        SqlDataAdapter da;
        DataTable dt;
        private void loadDate()
        {
            da = new SqlDataAdapter("select * from dbo.GetEmployee()", Myoper.con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }
        private void FormEmployee_Load(object sender, EventArgs e)
        {
            Myoper.myconnection();
            //Myoper.onoff(this, false);
            txtSearch.Text = "Search Name or ID ........";
            txtSearch.ForeColor = Color.Gray;
            loadDate();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "New")
            {
                btnNew.Text = "Canel";
                Myoper.onoff(this, true);
                txtNum.Focus();
            }
            else
            {
                if (MessageBox.Show("Do u want to canel ?", "cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnNew.Text = "New";
                    Myoper.clearText(this);
                    Myoper.onoff(this, false);
                }

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmMain fmain = new frmMain();
                this.Hide();
                fmain.ShowDialog();
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fl = new OpenFileDialog();
            fl.Filter = "ChooseImage(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            
            if (fl.ShowDialog() == DialogResult.OK)
            {
                fp = fl.FileName;
                pictureBox1.Image = Image.FromFile(fl.FileName);
            }
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
                txtSalary.Text = string.Format("{0:C}", decimal.Parse((txtSalary.Text)));
            }
        }

        private void txtSalary_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSalary.Text) || !string.IsNullOrEmpty(txtSalary.Text))
            {
                var s = (int.Parse(txtSalary.Text, NumberStyles.Currency).ToString());
                txtSalary.Text = s;
            }

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = null;
            txtSearch.ForeColor = Color.Black;

        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Text = "Seatch Name or ID......";
            txtSearch.ForeColor = Color.Black;
        }
        private void modify(string x)
        {
            var salary = decimal.Parse(txtSalary.Text, NumberStyles.Currency);
            com = new SqlCommand(x, Myoper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@i", txtNum.Text);
            com.Parameters.AddWithValue("@n", txtName.Text);
            
            if (radioBoy.Checked == true)
            {
                com.Parameters.AddWithValue("@g", "ប");
                
            }
            else
            {
                com.Parameters.AddWithValue("@g", "ស");
                
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
            }
            com.Parameters.AddWithValue("@pt", photo);
            com.ExecuteNonQuery();
            fp = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do u really want to insert ? ", "Inserr", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                modify("insertEmployee");
                MessageBox.Show("successfully");
                FormEmployee_Load(sender, e);
            }
            else
            {
                return;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];



            txtNum.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value.ToString() == "ស")
            {
                radioBoy.Checked = true;
            }
            else
            {
                radioGirl.Checked = true;
            }
            dtpDOB.CustomFormat = "dd//MM//yy";
            dtpDOB.Text = row.Cells[3].Value.ToString();
            txtPos.Text = row.Cells[4].Value.ToString();
            txtSalary.Text = row.Cells[5].Value.ToString();
            txtAddress.Text = row.Cells[6].Value.ToString();
            dtpWord.CustomFormat = row.Cells[8].Value.ToString();
            mtbPhone.Text = row.Cells[7].Value.ToString();
            photo = (byte[])row.Cells[9].Value;
            MemoryStream ms = new MemoryStream(photo);
            pictureBox1.Image = Image.FromStream(ms);

        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do u really want to update ? ", "Inserr", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                modify("UpdateEmployee");
                FormEmployee_Load(sender, e);
                MessageBox.Show("Updated successfully");
            }
            else
            {
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do u really want to delete ? ", "Inserr", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                modify("DeleteEmployee");
                MessageBox.Show("Delete successfully");
                FormEmployee_Load(sender, e);
            }
            else
            {
                return;
            }

        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            //com = new SqlCommand("searchEmpName", Myoper.con);
            //com.CommandType = CommandType.StoredProcedure;
            //com.Parameters.AddWithValue("@em", txtSearch.Text);

            //da = new SqlDataAdapter();
            //da.SelectCommand = com;
            //dt = new DataTable();
            //da.Fill(dt);

            //dataGridView1.DataSource = dt;
            //if (dt.Rows.Count < 0)
            //{
            //    com = new SqlCommand("searchEmpID", Myoper.con);
            //    com.CommandType = CommandType.StoredProcedure;
            //    com.Parameters.AddWithValue("@eid", txtSearch.Text);

            //    da = new SqlDataAdapter();
            //    da.SelectCommand = com;
            //    dt = new DataTable();
            //    da.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //}


            //dt.Dispose();
            com = new SqlCommand("searchEmpName", Myoper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@em", txtSearch.Text);

            da = new SqlDataAdapter();
            da.SelectCommand = com;
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count < 1)
            {
                com = new SqlCommand("searchEmpID", Myoper.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@eid", txtSearch.Text);
                da = new SqlDataAdapter();
                da.SelectCommand = com;
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            da.Dispose();
            com.Dispose();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            DialogResult re;
            re = MessageBox.Show("Do u want to print list all staff", "Print", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                DataTable dtEmpList = new DataTable();
                dtEmpList.Columns.Add("EmpID", typeof(string));
                dtEmpList.Columns.Add("EmpName", typeof(string));
                dtEmpList.Columns.Add("empGen", typeof(string));
                dtEmpList.Columns.Add("empDob", typeof(string));
                dtEmpList.Columns.Add("empPos", typeof(string));
                dtEmpList.Columns.Add("empSal", typeof(string));
                dtEmpList.Columns.Add("empADD", typeof(string));
                dtEmpList.Columns.Add("empCon", typeof(string));
                dtEmpList.Columns.Add("empHire", typeof(string));
                dtEmpList.Columns.Add("empPhoto", typeof(byte[]));
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dtEmpList.Rows.Add(row.Cells[0].Value,
                                        row.Cells[1].Value,
                                        row.Cells[2].Value,
                                        row.Cells[3].Value,
                                        row.Cells[4].Value,
                                        row.Cells[5].Value,
                                        row.Cells[6].Value,
                                        row.Cells[7].Value,
                                        row.Cells[8].Value,
                                        row.Cells[9].Value);
                }
                frmRptEmpList frmEmplist = new frmRptEmpList();
                frmEmplist.rptViewerEmpList.ProcessingMode = ProcessingMode.Local;
                
                LocalReport lcr = frmEmplist.rptViewerEmpList.LocalReport;
                lcr.DisplayName = "rptEmpList.rdlc";

                ReportDataSource rds = new ReportDataSource("dsEmpList", dtEmpList);
               
                lcr.DataSources.Clear();
                lcr.DataSources.Add(rds);

                frmEmplist.ShowDialog();
                frmEmplist.rptViewerEmpList.Refresh();


                //DataTable dtEmpList = new DataTable();
                //dtEmpList.Columns.Add("empID", typeof(string));
                //dtEmpList.Columns.Add("empName", typeof(string));
                //dtEmpList.Columns.Add("empGen", typeof(char));
                //dtEmpList.Columns.Add("empDob", typeof(string));
                //dtEmpList.Columns.Add("empPos", typeof(string));
                //dtEmpList.Columns.Add("empSal", typeof(decimal));
                //dtEmpList.Columns.Add("empADD", typeof(string));
                //dtEmpList.Columns.Add("empCon", typeof(string));
                //dtEmpList.Columns.Add("empHire", typeof(string));
                //dtEmpList.Columns.Add("empPhoto", typeof(byte[]));

                //foreach (DataGridViewRow row in dataGridView1.Rows)
                //{
                   
                //    dtEmpList.Rows.Add(row.Cells[0].Value,
                //                        row.Cells[1].Value,
                //                        row.Cells[2].Value,
                //                        row.Cells[3].Value,
                //                        row.Cells[4].Value,
                //                        row.Cells[5].Value,
                //                        row.Cells[6].Value,
                //                        row.Cells[7].Value,
                //                        row.Cells[8].Value,
                //                        row.Cells[9].Value);
                                            
                //}
                

                //frmRptEmpList RptEmpList = new frmRptEmpList();
                //RptEmpList.rptViewerEmpList.ProcessingMode = ProcessingMode.Local;
                //LocalReport lrptEmp = RptEmpList.rptViewerEmpList.LocalReport;
                //lrptEmp.DisplayName = "rptEmp.rdlc";

                //ReportDataSource rds = new ReportDataSource("dsEmpList", dtEmpList);
                //lrptEmp.DataSources.Clear();
                //lrptEmp.DataSources.Add(rds);
                
                //RptEmpList.Show();
                //RptEmpList.rptViewerEmpList.Refresh();
            }
            else if (re == DialogResult.No)
            {
                frmRptEmp frm = new frmRptEmp();
                frm.rptViewerEmp.ProcessingMode = ProcessingMode.Local;

                LocalReport lcr = frm.rptViewerEmp.LocalReport;
                lcr.DisplayName = "rptEmp";

                ReportParameter p1 = new ReportParameter("eid",txtNum.Text);
                frm.rptViewerEmp.LocalReport.SetParameters(p1);

                ReportParameter p2 = new ReportParameter("ename", txtName.Text);
                frm.rptViewerEmp.LocalReport.SetParameters(p2);

                ReportParameter p3 = new ReportParameter("edob", dtpDOB.Value.ToString());
                frm.rptViewerEmp.LocalReport.SetParameters(p3);

                ReportParameter p4 = new ReportParameter("epos",txtPos.Text);
                frm.rptViewerEmp.LocalReport.SetParameters(p4);

                ReportParameter p5 = new ReportParameter("ehire", dtpWord.Value.ToString());
                frm.rptViewerEmp.LocalReport.SetParameters(p5);
                string gen;
                if (radioBoy.Checked == true)
                {
                    gen = "ប្រុស";
                }
                else
                {
                    gen = "ស្រី";
                }
                ReportParameter p6 = new ReportParameter("egen", gen);
                frm.rptViewerEmp.LocalReport.SetParameters(p6);

                ReportParameter p7 = new ReportParameter("esal", txtSalary.Text);
                frm.rptViewerEmp.LocalReport.SetParameters(p7);

                frm.ShowDialog();
                frm.rptViewerEmp.Refresh();
                //frmRptEmp rptEmp = new frmRptEmp();
                //rptEmp.rptViewerEmp.ProcessingMode = ProcessingMode.Local;
                //LocalReport lrpt = rptEmp.rptViewerEmp.LocalReport;
                //lrpt.DisplayName = "rptEmp.rdlc";

                //ReportParameter p1 = new ReportParameter("eid", txtNum.Text);
                //rptEmp.rptViewerEmp.LocalReport.SetParameters(p1);
                //ReportParameter p2 = new ReportParameter("ename", txtName.Text);
                //rptEmp.rptViewerEmp.LocalReport.SetParameters(p2);
                //string gen;
                //if (radioBoy.Checked == true)
                //{
                //    gen = "ប";
                //}
                //else
                //{
                //    gen = "ស";
                //}

                //ReportParameter p3 = new ReportParameter("egen", gen);
                //rptEmp.rptViewerEmp.LocalReport.SetParameters(p3);

                //ReportParameter p4 = new ReportParameter("edob", dtpDOB.Value.ToString());
                //rptEmp.rptViewerEmp.LocalReport.SetParameters(p4);

                //ReportParameter p5 = new ReportParameter("epos", txtPos.Text);
                //rptEmp.rptViewerEmp.LocalReport.SetParameters(p5);

                //ReportParameter p6 = new ReportParameter("esal", txtSalary.Text);
                //rptEmp.rptViewerEmp.LocalReport.SetParameters(p6);

                //ReportParameter p7 = new ReportParameter("ehire", dtpWord.Value.ToString());
                //rptEmp.rptViewerEmp.LocalReport.SetParameters(p7);

                //rptEmp.ShowDialog();
                //rptEmp.rptViewerEmp.Refresh();
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioBoy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPos_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioGirl_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void តួរនាទី_Click(object sender, EventArgs e)
        {

        }

        private void dtpWord_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mtbPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

    
            

        

    






 
    

