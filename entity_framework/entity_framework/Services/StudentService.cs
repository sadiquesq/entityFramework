using entity_framework.Controllers;
using entity_framework.models;
using Microsoft.EntityFrameworkCore;

namespace entity_framework.Services
{

    public interface IStudentService
    {
        Task<List<student>> GetStudent();        
        //Task<student> GetBookByIdAsync(int id);
        Task<student> AddStudent(student student);

        Task<student?> UpdateStudent(int id,student updatestudent);
        Task<bool> DeleteStudent(int studentId);
    }


    public class StudentService: IStudentService
    {

        private readonly ApplicationDbcontext _context;


        public StudentService(ApplicationDbcontext context)
        {
            _context = context;
        }




        public async Task<List<student>> GetStudent()
        {
            return await _context.students.ToListAsync();
        }

        public async Task<student> AddStudent(student student)
        {
            _context.students.Add(student);
            await _context.SaveChangesAsync();
            return student;
        }


        public async Task<bool> DeleteStudent(int studentId)
        {
            var delete = await _context.students.FindAsync(studentId);

            if (delete == null)
            {
                return false;
            }

            _context.students.Remove(delete);
             await _context.SaveChangesAsync();
            return true;
        }






        public async Task<student?> UpdateStudent(int Id, student updatestudent)
        {
            var n = await _context.students.FindAsync(Id);
            if (n == null)
            {
                return null;
            }

            n.Name = updatestudent.Name;
            n.age = updatestudent.age;


            _context.students.Update(updatestudent);
            await _context.SaveChangesAsync();
            return n;


        }




    }
}
