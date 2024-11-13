using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System.Data;
using System.Data.Common;

namespace ado2
{

    //public class student
    //{
    //    public int id;
    //    public string name;
    //    public string class1;
    //}

    public class studentRepo
    {
        private readonly string connectingString = "data source=SADIQUE; database=sampleDB1;integrated security=SSPI;TrustServerCertificate=True";

        public void intsertIntoTable(int id, string name, string class1)
        {

            using (SqlConnection con = new SqlConnection(connectingString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("insert into student(id,name,class1) values(@id,@name,@class1)", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@class1", class1);
                    cmd.ExecuteNonQuery();
                }

                Console.WriteLine("the row is inserted suceesfully");
            }

        }

        public void updateIntotable(int id, string name, string class1)
        {
            using (SqlConnection con = new SqlConnection(connectingString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("update student set name=@name,class1=@class1 where id=@id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@class1", class1);
                    cmd.ExecuteNonQuery();
                }

                Console.WriteLine("updation is sucessfully completed");
            }
        }


        public void deleteInTable(int id)
        {
            using (SqlConnection con = new SqlConnection(connectingString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("delete from student where id=@id", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                   int affect = cmd.ExecuteNonQuery();

                    Console.WriteLine(affect);
                }

                Console.WriteLine("deleted sucessfully");
            }
        }


        public void getAllstudents()
        {

            using (SqlConnection con = new SqlConnection(connectingString))
            {
                con.Open();

                SqlCommand cm = new SqlCommand("select * from student", con);


                SqlDataAdapter tables = new SqlDataAdapter("select * from student", con);


                DataTable datatable = new DataTable();

                tables.Fill(datatable);

               

                //foreach (DataRow row in datatable.Rows)
                //{
                //    Console.WriteLine(row["id"]+"   " + row["name"]);
                //}

               // con.ChangeDatabase("db");
               // SqlDataAdapter names = new SqlDataAdapter("select * from BOOKS b full outer join EMPLOYEE e on b.name=e.name" +
               //     "select * from  employee", con);

               // DataSet ds = new DataSet();

               //names.Fill(ds);  


                //foreach(var rows in ds.Tables)
                //{
                //    Console.WriteLine(rows);
                //}




                foreach (DataTable table in ds.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            Console.Write(item + "|| ");
                        }
                        Console.WriteLine();
                    }
                }







                //using (SqlCommand cmd = new SqlCommand("select * from student",con))
                //{
                //    SqlDataReader read = cmd.ExecuteReader();

                //    //while (read.Read())
                //    //{
                //    //    Console.WriteLine($"{read[0]} || {read[1]} || {read[2]}");
                //    //}

                //    while (read.Read())
                //    {
                //        Console.WriteLine($"{read["id"]} || {read["name"]} || {read["class1"]}");
                //    }
                //}


            }

        }


        public void NumberOfRows()
        {
            using (SqlConnection con = new SqlConnection(connectingString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select avg(cast(id as decimal)) from student", con))
                {
                    //SqlDataReader rows = cmd.ExecuteReader();

                    //while(rows.Read())
                    //{
                    //    Console.WriteLine($"{rows[0]}");
                    //}

                    decimal count = (decimal)cmd.ExecuteScalar();

                    Console.WriteLine(count);


                }

                using (SqlCommand cmd = new SqlCommand("select count(*) from student", con))
                {
                    int co = (int)cmd.ExecuteScalar();
                    Console.WriteLine(co);
                }


            }

        }





       

       

    }


        internal class Program
        {
            static void Main(string[] args)
            {
                var studentmain = new studentRepo();


                //studentmain.intsertIntoTable(15, "raju", "F1");
            //studentmain.updateIntotable(2, "sahad", "H1");
            //studentmain.deleteInTable(15);

            //studentmain.getAllstudents();
            //studentmain.NumberOfRows();



        }


        }
    }
