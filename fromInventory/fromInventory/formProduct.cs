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
    public partial class formProduct : Form
    {
        public formProduct()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        SqlCommand com;
        DataTable dt;
        private void fillList()
        {
            da = new SqlDataAdapter("select proID, proName from tbProduct", Myoper.con);
            dt = new DataTable();
            da.Fill(dt);
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "proName";
            listBox1.ValueMember = "proID";
        }
        private void show_cate()
        {
            da = new SqlDataAdapter("select catID, category from tb_Category", Myoper.con);
            dt = new DataTable();
            da.Fill(dt);
           // cmbCate.Items.Clear();
            cmbCate.DataSource = dt;         
            cmbCate.DisplayMember = "category";
            cmbCate.ValueMember = "catID";
            
        }
        private void modify(string x)
        {
            com = new SqlCommand(x, Myoper.con);
            com.CommandType = CommandType.StoredProcedure;
            //(@i varchar(5), @pn nvarchar(30), @q int, @u money, @s money, @c int)
            com.Parameters.AddWithValue("@i",txtProID.Text);
            com.Parameters.AddWithValue("@pn",txtProName.Text);
            com.Parameters.AddWithValue("@q",txtqty.Text);
            com.Parameters.AddWithValue("@u",txtupisPrice.Text);
            com.Parameters.AddWithValue("@s",txtSalePrice.Text);
            string a = cmbCate.SelectedValue.ToString();
            com.Parameters.AddWithValue("@c",a);
            com.ExecuteNonQuery();
            com.Dispose();

        }
        private void deletee()
        {
            com = new SqlCommand("deleteProduct", Myoper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@i", txtProID.Text);
            com.ExecuteNonQuery();
            com.Dispose();
            
        }

        private void formProduct_Load(object sender, EventArgs e)
        {
           
            Myoper.myconnection();
            fillList();
            show_cate();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do u really want to delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                deletee();
                formProduct_Load(sender, e);
            }
            else
            {
                MessageBox.Show("HI");
            }
            
            
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            
            txtProID.Text = listBox1.SelectedValue.ToString();
            txtProName.Text = listBox1.Text;
            com = new SqlCommand("select * from tbProduct where proID = '"+txtProID.Text+"'", Myoper.con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtqty.Text = dr[2].ToString();
                txtupisPrice.Text = dr[3].ToString();
                txtSalePrice.Text = dr[4].ToString();
            }
            dr.Dispose();
            com.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("do u really want to add", "add", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                modify("addProduct");
                formProduct_Load(sender, e);
            }
            
            
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("do u really want to edit", "edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                modify("updateProduct");
                formProduct_Load(sender, e);
            }
        }

        private void textBox7_KeyUp(object sender, KeyEventArgs e)
        {
            com = new SqlCommand("seatchProduct", Myoper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@pn", textBox7.Text);
            dt = new DataTable();
            da = new SqlDataAdapter();
            da.SelectCommand = com;
            da.Fill(dt);
            //listBox1.Items.Clear();
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "proName";
            listBox1.ValueMember = "proID";
           
            da.Dispose();
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
    }
}
