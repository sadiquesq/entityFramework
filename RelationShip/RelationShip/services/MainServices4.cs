using RelationShip.DTO;
using RelationShip.models;

namespace RelationShip.services
{

    public interface IMainServices
    {
        Task<Employee> insertIntoEmployee(Employee employee);
    };


    public class MainServices4 : IMainServices
    {
        private readonly MainDbContext _context;
        public MainServices4(MainDbContext context)
        {
            _context = context;
        }

        public async Task<Employee> insertIntoEmployee(Employee employee)
        {
            //{
            //    var employee2 = new Employee()
            //    {
            //        EmployeeId = employee.EmployeeId,
            //        Name = employee.Name,
            //        AddressId = employee.AddressId
            //    };


                _context.Employees.Add(employee);
                await _context.SaveChangesAsync();
                return employee;

            }


        }
    }
