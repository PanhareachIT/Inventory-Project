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
using System.IO;
namespace fromInventory
{
    public partial class Photo : Form
    {
        public Photo()
        {
            InitializeComponent();
        }
        SqlCommand com;
        SqlDataAdapter da;
        DataTable dt;
        byte[] photo;
        string fp;
        private void loadd()
        {
            da = new SqlDataAdapter("select * from tbPhoto", Myoper.con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Photo_Load(object sender, EventArgs e)
        {
            Myoper.myconnection();
            loadd();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fl = new OpenFileDialog();
            fl.Filter = "Choose image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (fl.ShowDialog() == DialogResult.OK)
            {
                fp = fl.FileName;
                pictureBox1.Image = Image.FromFile(fl.FileName);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("insertPhoto", Myoper.con);
            com.CommandType = CommandType.StoredProcedure;
            if (fp != null)
            {
                photo = File.ReadAllBytes(fp);
            }
            com.Parameters.AddWithValue("@p", photo);
            com.ExecuteNonQuery();
            MessageBox.Show("successfully");
            Photo_Load(sender, e);
        }
    }
}
