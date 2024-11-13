namespace MainEntityFramework.Models
{
    public class employeeAddress
    {

        public int AddressId { get; set; }

        public string AddressLine {  get; set; }

        public string City { get; set; }

        public Employee employee { get; set; }

    }
}
