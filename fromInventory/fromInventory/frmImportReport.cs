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
    public partial class frmImportReport : Form
    {
        public frmImportReport()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        SqlCommand com;
        DataTable dt;
        string eid;
        string supID = "0";
        DateTime dStart;
        DateTime dStop;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmImportReport_Load(object sender, EventArgs e)
        {
            Myoper.myconnection();
            da = new SqlDataAdapter("select empID, empName from tbemployee where pos = 'stockman'", Myoper.con);
            dt = new DataTable();
            da.Fill(dt);
            cmbEmp.Items.Clear();
            cmbEmp.DataSource = dt;
            cmbEmp.DisplayMember = "empName";
            cmbEmp.ValueMember = "empID";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMain fmain = new frmMain();
            this.Hide();
            fmain.ShowDialog();
            this.Close();
        }

        private void cmbEmp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            eid= cmbEmp.SelectedValue.ToString();
         //   MessageBox.Show(typeof(eid));
            da = new SqlDataAdapter("select distinct supID, supName from tbImport where empID = '"+eid+"'"	,Myoper.con);
            dt = new DataTable();
            da.Fill(dt);
            cmpSup.DataSource = null;
            cmpSup.Items.Clear();
            cmpSup.DataSource = dt;
            cmpSup.DisplayMember = "supName";
            cmpSup.ValueMember = "supID";
    
           
        }


        private void cmpSup_SelectedIndexChanged(object sender, EventArgs e)
        {
            supID = cmbEmp.SelectedValue.ToString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dtpstart.CustomFormat = "yyyy-MM-dd";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dStart = dtpstart.Value;
            dStop = dtpStop.Value;
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("ImpID", 200);
            listView1.Columns.Add("ImpDate", 200);
            listView1.Columns.Add("SupName", 200);
            listView1.Columns.Add("ProID", 200);
            listView1.Columns.Add("ProName", 200);
            listView1.Columns.Add("ImpQty", 200);
            listView1.Columns.Add("ImpPrice", 200);
            listView1.Columns.Add("Amount", 200);
            if (dtpStop.CustomFormat!= " ")
            {
                dStop = dtpStop.Value;
                if (dStart > dStop)
                {
                    MessageBox.Show("invalid");

                    return;
                }
                else
                {

                   
                    
                    string bb = "10";
                   
                    string ee = cmbEmp.SelectedValue.ToString();
                    MessageBox.Show(eid);
                    com = new SqlCommand("importReport", Myoper.con);
                    com.CommandType = CommandType.StoredProcedure;
                  //  @EI char(5), @SI int, @SA datetime, @SO dateTime)
                 //   com.Parameters.AddWithValue("@EI","10");
                    
                    com.Parameters.AddWithValue("@SI",supID);
                    com.Parameters.AddWithValue("@EI", eid);
                    com.Parameters.AddWithValue("@SA",dStart);
                    com.Parameters.AddWithValue("@SO",dStop);
                    com.ExecuteNonQuery();

                    da = new SqlDataAdapter();
                    da.SelectCommand = com;
                    dt = new DataTable();
                    da.Fill(dt);
                    MessageBox.Show(eid);
                    string[] arr = new string[8];
                    for (int i = 0; i <dt.Rows.Count; ++i)
                    {
                        DataRow row = dt.Rows[i];
                        MessageBox.Show("HI");
                       arr[0] = string.Format("{0:0000000}",row[0].ToString());
                       // arr[0] = row[0].ToString();
                        arr[1] = row[1].ToString();
                        arr[2] = row[2].ToString();
                        arr[3] = row[3].ToString();
                        arr[4] = row[4].ToString();
                        arr[5] = row[5].ToString();
                        arr[6] = string.Format("{0:c}",decimal.Parse(row[5].ToString()));
                        arr[7] = string.Format("{0:c}",decimal.Parse(row[5].ToString()));
                        ListViewItem item = new ListViewItem(arr);
                        listView1.Items.Add(item);

                    }
                  
                }
            }
        }

        private void dtpStop_ValueChanged(object sender, EventArgs e)
        {
            dtpStop.CustomFormat = "yyyy-MM-dd";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
