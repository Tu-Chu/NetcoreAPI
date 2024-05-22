using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetMVC.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        [Required(ErrorMessage = "PersonId khong duoc de trong")]
        public required string PersonID { get; set; }
        [Required(ErrorMessage ="Full name is required")]
        [MaxLength(150)]
        [MinLength(3)]
        public required string FullName { get; set; }
        [DataType(DataType.EmailAddress)]
        public required string Address { get; set; }
    }
}