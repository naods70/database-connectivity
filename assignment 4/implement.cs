using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_4
{
    public partial class implement : Form
    {
        public implement()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            component c = new component();
            c.ptitle = txt_title.Text;
            c.pprice = txt_price.Text;
            c.pdesc = txt_desc.Text;
            c.Show();
            flowLayoutPanel1.Controls.Add(c);
            c.Click += card_clicked;
            /* or we can do c.click += (object o,eventargs e)
            {
             product_managment p = new product_managment();
            p.Show();
            }
            */
        }



        private void card_clicked (object o, EventArgs e)
        {

            product_managment p = new product_managment();
            p.Show();
        MessageBox.Show("card clicked");
        }




      
}
}
