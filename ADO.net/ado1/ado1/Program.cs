using Microsoft.Data.SqlClient;
using System.Data;

namespace ado1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con=null;
            int outputvalue;

            con = new SqlConnection("data source=sadique; database=sampleDB1; integrated security=SSPI; TrustServerCertificate=True");


            //SqlCommand cm = new SqlCommand("select * from student", con);
            //con.Open();
            //SqlDataReader read = cm.ExecuteReader();
            //while (read.Read())
            //{
            //    Console.WriteLine($"{read[1]} || {read[2]}");
            //}




            //con.Open();
            //var cmd = new SqlCommand("exec Isprocedure", con);
            //var proce = cmd.ExecuteReader();
            //Console.WriteLine(proce.Read());
            //while(proce.Read())
            //{
            //    Console.WriteLine($"{proce[0]}");
            //}

            con.Open();
           //using (SqlCommand cmd = new SqlCommand("Isprocedure", con))
           // {
           //     cmd.CommandType = CommandType.StoredProcedure;
           //     cmd.Parameters.AddWithValue("@name", "sadique");

           //     SqlParameter outputparamer=new SqlParameter("@num",SqlDbType.Int)
           //     {

           //          Direction = ParameterDirection.Output

           //     };
           //     cmd.Parameters.Add(outputparamer);


           //     cmd.ExecuteNonQuery();

           //     outputvalue=(int)outputparamer.Value;

           //     Console.WriteLine(outputvalue);








            //DataTable dt = new DataTable();
            //dt.Columns.Add("studentId",typeof(int));
            //dt.Columns.Add("name", typeof(string));
            //dt.Columns.Add("age", typeof(int));


            //dt.Rows.Add(4,"aadique",22);
            //dt.Rows.Add(10, "ajfar", 20);
            //dt.Rows.Add(7, "hinan", 21);

            //DataView dataView=new DataView(dt);

            //dataView.Sort = "age DESC";


            //dataView.RowFilter = "age >= 21";
            //foreach (DataRowView dv in dataView)
            //{
            //    Console.WriteLine($"{dv["studentId"]}, {dv["name"]}");
            //}




            SqlDataAdapter dataAdapter=new SqlDataAdapter("select * from student",con);

            DataTable dt = new DataTable();

            dataAdapter.Fill(dt);

            DataView dataView = new DataView(dt);

            dataView.RowFilter = "id>=3";

            foreach(DataRowView row in dataView)
            {
                Console.WriteLine($"{row["id"]} || {row["name"]}");
            }
            con.Close();

        }
    }
}
