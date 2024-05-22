using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetMVC.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public required string StudentID { get; set; }
        public required string Fullname { get; set; }
        public required string Address { get; set; }
        public required int Age { get; set; }
        public required string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public bool IsActive { get; set; }
    }
}