using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(25)]
        [Required]

        [Display(Name ="Full Name")]
        [Unique]
        public string Name { get; set; }

        [Range(6000,25000)]

        public decimal Salary { get; set; }

        [RegularExpression(@"\w+\.(jpg|png)",ErrorMessage ="Image Must be jpg or png")]
        public string ImageUrl { get; set; }
        public string Address { get; set; }

        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
