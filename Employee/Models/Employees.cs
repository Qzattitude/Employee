using Employee.Enums;
using System.ComponentModel.DataAnnotations;

namespace Employee.Models
{
    public class Employees
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Department Department { get; set; }

    }
}
