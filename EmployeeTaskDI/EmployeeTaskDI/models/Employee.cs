using System.ComponentModel.DataAnnotations;

namespace EmployeeTaskDI.models
{
    public class Employee
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Employe name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "employee position is required")]
        public string Position { get; set; }

        [Range(1, 100, ErrorMessage = "Age must be between 1 and 100")]
        public int Age { get; set; }

        [Required]
        public string Department { get; set; }
    }
}
