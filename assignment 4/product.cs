using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace assignment_4
{
    internal class product
    {

        static List<product> products = new List<product>();

        static string name { get; set; }

        public string product_name { get; set; }
        public string batch_no { get; set; }

        public string prod_date { get; set; }

        public string exp_date { get; set; }
        public bool avalable { get; set; }







        /*public bool packed { get; set; }
        public bool unpacked { get; set; }   */
        public string type { get; set; }
        public int price { get; set; }
        public static product findone(string product_name)
        {
            return products.Find(p => p.product_name == product_name);
        }
        public static List<product> findall(int price)
        {
            return products.FindAll(p => p.price == price);
        }
        public void save()
        {
            product p = new product();

            string s = @"data source=;initial catalog=productmanagments;integrated security=true";
            SqlConnection sql = new SqlConnection(s);
            string query = "insert into product values('" + p.product_name + "','" + p.prod_date + "','" + p.exp_date + "','" + p.batch_no + "','" + p.price + "')";


            products.Add(this);
            



        }


        public static List<product> getallproducts()
        {

            string s = @"data source=ASUS\SQLEXPRESS  ;initial catalog=productmanagments;integrated security=true";
            SqlConnection connect = new SqlConnection(s);

            connect.Open();
          //  Console.Write("connected");



            string query = "select* from product";
            SqlCommand cmd = new SqlCommand(query, connect);
           
            var result = cmd.ExecuteReader();

            List<product> temp = new List<product>();

            while (result.Read())
            {

                product p =new product();
                p.product_name = result["productname"].ToString();
                p.prod_date = result["productiondate"].ToString();
                p.exp_date = result["expirydate"].ToString();
                p.price = (int)result["price"];
                p.batch_no = result["batchno"].ToString();
            


            }

            return temp;
        }



    }
}

