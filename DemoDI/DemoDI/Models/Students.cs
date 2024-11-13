using System.ComponentModel.DataAnnotations;

namespace DemoDI.Models
{
    public class Students
    {

        [Required(ErrorMessage ="id must be there")]
        public int Id { get; set; }


        [Required(ErrorMessage ="name must be there")]
        public string? User { get; set; }


        [Required(ErrorMessage = "Password must be there")]
        public string? Password { get; set; }


        [Required(ErrorMessage ="Role must be there")]
        public String? Role { get; set; }



    }
}
