using Demo.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.ViewModel
{
    public class EmpWithListDepartmentVM
    {
        [Display(Name = "Full Name")]
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string ImageUrl { get; set; }
        public string Address { get; set; }

        public int DepartmentId { get; set; }

        public List<Department> Departments { get; set; }
    }
}
