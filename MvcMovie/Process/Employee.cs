using System.ComponentModel.DataAnnotations;

namespace NetMVC.Models
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        public string? EmpName { get; set; }
    }
}
