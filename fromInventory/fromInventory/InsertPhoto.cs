using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace fromInventory
{
    public partial class InsertPhoto : Form
    {
        public InsertPhoto()
        {
            InitializeComponent();
            
        }
        string fl;
        byte[] photo;
        SqlCommand com;
        SqlDataAdapter da;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "choose Image(*.JPEJ; *.JPG)|*.JPEJ; *.JPG";
            if (file.ShowDialog() == DialogResult.OK)
            {
                fl = file.FileName;
                pictureBox1.Image = Image.FromFile(fl);
            }
        }

        private void InsertPhoto_Load(object sender, EventArgs e)
        {
            Myoper.myconnection();
            SqlDataAdapter da = new SqlDataAdapter("select photo from tbPhoto", Myoper.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            photo = File.ReadAllBytes(fl);
            SqlCommand com = new SqlCommand("insertPhoto", Myoper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@p", photo);
            com.ExecuteNonQuery();
            MessageBox.Show("successfully");
            InsertPhoto_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int num = e.RowIndex;
            DataGridViewRow item = dataGridView1.Rows[num];
            photo = (byte[])item.Cells[0].Value;
            MemoryStream ms = new MemoryStream(photo);
            pictureBox1.Image = Image.FromStream(ms);
        }
    }
}
