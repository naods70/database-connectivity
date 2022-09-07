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

namespace assignment_4
{
    public partial class databaseconnectivity : Form
    {
        public databaseconnectivity()
        {
            InitializeComponent();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            try
            {
                string costring = @"Data source=ASUS\SQLEXPRESS;Initial Catalog=try;Integrated Security=true";
                SqlConnection con = new SqlConnection(costring);
                con.Open();
                MessageBox.Show("connected");

               // string query ="insert into studentt values(1,"abebe")"
               /* product_managment p = new product_managment();
                    p.Show();
               */
            }

            catch
            {
                MessageBox.Show("can`t connect");
            }
        }
    }
}
