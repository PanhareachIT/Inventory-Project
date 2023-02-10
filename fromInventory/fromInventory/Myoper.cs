using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace fromInventory
{
    class Myoper
    {
        public static int empID ;
        public static string empName;
        public static string empPos;
        public static SqlConnection con;
        public static void myconnection()
        {
            try
            {
                string sql ="Data Source=(localdb)\\Local;Initial Catalog=test;Integrated Security=True";
                con = new SqlConnection(sql);
                con.Open();
           //     MessageBox.Show("seccessfull connected");
            }catch(Exception ex)
            {
                MessageBox.Show("unseccess connected");
            }
            
        }
        public static void onoff(Form frm , Boolean b)
        {
            foreach(Control ct in frm.Controls)
            {
                if(!(ct is Label))
                {
                    if(ct.Tag == null)
                    {
                        ct.Enabled = b;
                    }
                }
            }
        }
        public static void clearText(Form frm)
        {
           foreach(Control ct in frm.Controls)
           {
               if(ct is TextBox || ct is MaskedTextBox )
                   if(ct.Tag ==null)
                   {
                       ct.Text= null;
                       
                   }
           }
        }

    }
}
