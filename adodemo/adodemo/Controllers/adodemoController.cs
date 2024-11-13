using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace adodemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class adodemoController : ControllerBase
    {


        string ConnectionString = "data source=sadique;database=sampleDB1; integrated security=SSPI;Trusted_Connection=True;TrustServerCertificate=True";

        [HttpGet]
        public IActionResult getItems()
        {
            var students = new List<Student>(); 

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cm = new SqlCommand("select * from student", con);
                SqlDataReader read = cm.ExecuteReader();
                while (read.Read())
                {
                    var student = new Student
                    {
                        Id = read.GetInt32(0),     
                        Name = read.GetString(1),  
                        class1 = read.GetString(2)
                    };
                    students.Add(student); 
                }
                con.Close();
            }
            return Ok(students); 
        }




        [HttpGet("{id}")]


        public IActionResult getById(int id) 
        {

            var students1 = new List<Student>();

            using (SqlConnection con = new SqlConnection())
            {
                con.Open();

                SqlCommand cm = new SqlCommand("getById", con);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@id", id).Direction = ParameterDirection.Input;

                SqlDataReader reader = cm.ExecuteReader();

                while (reader.Read())
                {
                    //Console.WriteLine($"{reader[0]} || {reader[1]} || {reader[2]}");
                    var student = new Student
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        class1 = reader.GetString(2)
                    };
                    students1.Add(student);
                }
            }
            return Ok(students1);
        }





        [HttpDelete("{id}")]

        public IActionResult deleteItems(int id)
        {
            //using (SqlConnection con = new SqlConnection("data source=.;database=sampleDB1; integrated security=SSPI;Trusted_Connection=True;TrustServerCertificate=True"))
            //{

            //    con.Open();
            //    using (SqlCommand cm = new SqlCommand("delete from student where id=@id", con))
            //    {
            //        cm.Parameters.AddWithValue("@id", id);

            //        int affect = cm.ExecuteNonQuery();

            //        if (affect > 0)
            //        {
            //            return Ok(new { message = "Student deleted successfully." });
            //        }
            //        else
            //        {
            //            return NotFound(new { message = "Student not found." });
            //        }
            //    }
            //}



            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from student where id=@id", con);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@id", id);

                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "student");

                if (ds.Tables["student"].Rows.Count > 0)
                {
                    DataRow row = ds.Tables["student"].Rows[0];
                    row.Delete();

                    dataAdapter.DeleteCommand=new SqlCommand("delete from student where id=@id",con);
                    dataAdapter.DeleteCommand.Parameters.Add("@id", SqlDbType.Int).SourceColumn = "id";

                    dataAdapter.Update(ds, "student");

                    return Ok("Student successfully deleted.");

                }
                else
                {
                    return BadRequest();
                }
            }
        }






            [HttpPost]

            public IActionResult InsertStudent([FromBody] Student student)
            {

                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    //using(SqlCommand cmd = new SqlCommand("insert into student(id,name,class1) values(@id,@name,@class1)", con))
                    //{
                    //    cmd.Parameters.AddWithValue("@id", student.Id);
                    //    cmd.Parameters.AddWithValue("@name", student.Name);
                    //    cmd.Parameters.AddWithValue("class1", student.class1);
                    //    int affect = cmd.ExecuteNonQuery();
                    //    if(affect > 0)
                    //    {
                    //        return Ok("sucessfullt inserted");
                    //    }
                    //    else
                    //    {
                    //        return BadRequest();
                    //    }
                    //}



                    SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from student", con);

                    DataSet dataSet = new DataSet();

                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);


                //dataAdapter.InsertCommand = new SqlCommand("insert into student(id,name,class1) values(@id,@name,@class1)", con);
                    //dataAdapter.InsertCommand.Parameters.Add("@id", SqlDbType.Int, 0, "id");
                //dataAdapter.InsertCommand.Parameters.Add("@name", SqlDbType.VarChar, 50, "name");
                //dataAdapter.InsertCommand.Parameters.Add("@class1", SqlDbType.VarChar, 20, "class1");



                    dataAdapter.Fill(dataSet, "student");

                    DataRow newrow = dataSet.Tables["student"].NewRow();
                    newrow["id"] = student.Id;
                    newrow["name"] = student.Name;
                    newrow["class1"] = student.class1;
                    dataSet.Tables["student"].Rows.Add(newrow);


                    dataAdapter.Update(dataSet, "student");

                    return Ok(new { message = "successfully inserted" });




                }

            }





            [HttpPut]


            public IActionResult updateTable(int id, [FromBody] Student student)
            {


                //using (SqlConnection con = new SqlConnection("data source=.;database=sampleDB1; integrated security=SSPI;Trusted_Connection=True;TrustServerCertificate=True"))
                //{
                //    con.Open();

                //    using (SqlCommand cmd = new SqlCommand("UPDATE student SET name = @name, class1 = @class1 WHERE id = @id", con))
                //    {
                //        cmd.Parameters.AddWithValue("@id", student.Id);
                //        cmd.Parameters.AddWithValue("@name", student.Name);
                //        cmd.Parameters.AddWithValue("@class1", student.class1);

                //        int rowsAffected = cmd.ExecuteNonQuery();
                //        if (rowsAffected > 0)
                //        {
                //            return Ok("Student updated successfully.");
                //        }
                //        else
                //        {
                //            return NotFound("Student not found.");
                //        }
                //    }
                //}
                //}



                using (SqlConnection con = new SqlConnection(ConnectionString))
                {


                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM student WHERE id = @id", con);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@id", id);

                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "student");


                    if (dataSet.Tables["student"].Rows.Count > 0)
                    {


                        DataRow row = dataSet.Tables["student"].Rows[0];
                        row["name"] = student.Name;
                        row["class1"] = student.class1;

                        dataAdapter.UpdateCommand = new SqlCommand("UPDATE student SET name = @name, class1 = @class1 WHERE id = @id", con);
                    dataAdapter.UpdateCommand.Parameters.Add("@name", SqlDbType.VarChar, 30, "name");
                    dataAdapter.UpdateCommand.Parameters.Add("@class1", SqlDbType.VarChar, 50, "class1");
                    dataAdapter.UpdateCommand.Parameters.Add("@id", SqlDbType.Int).SourceColumn = "id";


                    dataAdapter.Update(dataSet, "student");

                        return Ok("successfully updated");

                    }
                    else
                    {
                        return NotFound("id not found");
                    }









                }

            }

        }


        








        // Define the Student model with properties matching the table columns
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string class1 { get; set; }
        }
    }

