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
using System.Globalization;
namespace fromInventory
{
    public partial class testanddeelete : Form
    {
        public testanddeelete()
        {
            InitializeComponent();
        }

        private void testanddeelete_Load(object sender, EventArgs e)
        {
            Myoper.myconnection();
           // DataGridViewColumn.
           // com = new SqlCommand("select photo from tbPhoto", Myoper.con);
            SqlDataAdapter da = new SqlDataAdapter("select photo from tbPhoto", Myoper.con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }
        string filename;
        byte[] photo;
        SqlCommand com;
        DataTable dt;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Choose image(*.jpg; *.png)|*.jpg; *.png";
            if (file.ShowDialog() == DialogResult.OK)
            {
                filename = file.FileName;
                pictureBox1.Image = Image.FromFile(file.FileName);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(filename!=null){
                photo = File.ReadAllBytes(filename);
              //  MessageBox.Show(photo);
            }
            int a = 1;
            com = new SqlCommand("testt", Myoper.con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@pt", photo);
            com.ExecuteNonQuery();
            MessageBox.Show("hello");
            testanddeelete_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.RowIndex;
            photo = (byte[])(dataGridView1.Rows[a].Cells[0].Value);
            MemoryStream ms = new MemoryStream(photo);
            pictureBox1.Image = Image.FromStream(ms);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)){
                e.Handled = true;
            
                
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = string.Format("{0:c}", decimal.Parse(textBox1.Text));
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                var ss = int.Parse(textBox1.Text, NumberStyles.Currency).ToString();
                textBox1.Text = ss;
            }
        }
    }
}
