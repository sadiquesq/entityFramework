using System.ComponentModel.DataAnnotations;

namespace items.models
{
    public class Items
    {

        [Range(1,50,ErrorMessage ="the id is not valid")]
        public int Id { get; set; }

        [StringLength(20,MinimumLength =5,ErrorMessage ="the string is overflow")]
        public string? Name { get; set; }
        public int prices {  get; set; }
    }
}
