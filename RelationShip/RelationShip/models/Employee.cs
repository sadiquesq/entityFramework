using Microsoft.Owin.BuilderProperties;
using System.Text.Json.Serialization;

namespace RelationShip.models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public int AddressId { get; set; }

        [JsonIgnore]
        public EmployeeAddress Address { get; set; }

        
    }
}
