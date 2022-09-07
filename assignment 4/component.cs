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
    public partial class component : UserControl
    {
        public component()
        {
            InitializeComponent();
        }

        private string _ptitle = "      ";

        private string _pdesc = "         ";


        private string _pprice = "            ";
        public string ptitle
        {
            get { return _ptitle; }
            set { lbl_title.Text = value; }
        }

        public string pdesc
        {
            get { return _pdesc; }
            set { lbl_desc.Text = value; }
        }

        public string pprice
        {
            get { return _pprice; }
            set { lbl_price.Text = value; }
        }


        //  public string price { get { return _price; } set { _price = value; label2.Text = value; } }





        public string product_name1 { get; set; }
        public string batch_no1 { get; set; }

        public string prod_date1 { get; set; }

        public string exp_date1 { get; set; }
        public bool avalable1 { get; set; }


        public string type1 { get; set; }
        public int price1 { get; set; }
        private void component_Load(object sender, EventArgs e)

        {






          



        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void lbl_price_Click(object sender, EventArgs e)
        {

        }

        private void lbl_desc_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
    

