using DemoDI.Models;

namespace DemoDI.Services
{

    //public interface Iservices
    //{
    //    public List<Students> GetStudents();

    //    public Students GetStudentById(int id);


    //}
    public class StudentServices 
{

        static public List<Students> students = new List<Students>
        {
            new Students {Id=1,User="sanu",Password="s123",Role="captain"}
        };


        public List<Students> GetStudents()
        {
            return students;
        }


        public Students GetStudentById(int id)
        {
            return students.FirstOrDefault(x => x.Id == id);
           
        }

        public void DeleteStudent(int id)
        {
            var del =GetStudentById(id);

            if (del != null)
            {
                 students.Remove(del);
            }
            

        }
    }
}
