using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace MainEntityFramework.Models
{
    public class Employee
    {

        public string Id { get; set; }
        public string Name { get; set; }

        public int AddressId { get; set; }
        public employeeAddress employeeAddress { get; set; }
    }
}
