
namespace RelationShip.models
{
    public class EmployeeAddress
    {

        public int EmployeeAddressId { get; set; }
        public string AddressLine { get; set; }
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
 
    }
}
