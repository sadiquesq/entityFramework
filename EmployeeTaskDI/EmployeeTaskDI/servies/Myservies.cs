using EmployeeTaskDI.models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace EmployeeTaskDI.servies
{
    public interface IMyservies
    {
        public List<Employee> Getemployee();
        public  void AddEmployee([FromBody] Employee newemployee);
        public  void UpdateEmployee( Employee newemployees);
        public Employee GetEmployeeById(int id);

        public  void DeleteEmployee(int id);

    }
    public class Myservies : IMyservies
    {
         public List<Employee> employees = new List<Employee>();
        //{
        //    new Employee{Id=2,Name="ramu",Position="tester",Age=21,Department="test"}
        //};

        public List<Employee> Getemployee()
        {   
            return employees;
        }


        public void AddEmployee(Employee newemployee)
        {
            employees.Add(newemployee);
        }
        public Employee GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(value=>value.Id==id);
        }
            

        public void UpdateEmployee(Employee newemployees)
        {
            var emp = GetEmployeeById(newemployees.Id);
            if (emp != null)
            {
                emp.Name = newemployees.Name;
                emp.Age = newemployees.Age;
                emp.Department = newemployees.Department;
                emp.Position = newemployees.Position;
            }
        }
        public void DeleteEmployee(int id)
        {
            var emp = GetEmployeeById(id);
            if (emp != null)
            {
                employees.Remove(emp);
            }

        }
    }
}
