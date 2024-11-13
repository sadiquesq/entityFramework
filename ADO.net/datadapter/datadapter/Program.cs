using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;

namespace datadapter
{
    internal class Program
    {





        //public void update()
        //{
          

        //}


        static void Main(string[] args)
        {

            using (SqlConnection con = new SqlConnection("data source=sadique;database=master;integrated security=SSPI;Trustservercertificate=true"))
            {
                con.Open();
                SqlDataAdapter datadapter = new SqlDataAdapter("select * from books", con);

                datadapter.InsertCommand = new SqlCommand("insert into books(book_name,publisherid,authorid,publish_year,price) values(@book_name,@publisberid,@anthorid,@publisher_year,@price)");
                datadapter.InsertCommand.Parameters.Add("@book_name", SqlDbType.VarChar, 30);
                datadapter.InsertCommand.Parameters.Add("@publisherid", SqlDbType.Int);
                datadapter.InsertCommand.Parameters.Add("@authorid", SqlDbType.Int);
                datadapter.InsertCommand.Parameters.Add("@publish_year", SqlDbType.Int);
                datadapter.InsertCommand.Parameters.Add("@price", SqlDbType.Decimal);


                DataSet ds = new DataSet();

                datadapter.Fill(ds);

                Console.WriteLine();

            }
        }
    }
}
