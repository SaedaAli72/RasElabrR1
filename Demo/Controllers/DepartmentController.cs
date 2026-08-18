using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo.Controllers
{
    public class DepartmentController : Controller
    {
        ITIContext Context = new ITIContext();
        public IActionResult Index()
        {
            List<Department> departmentFromModel = Context.departments.ToList();
            return View("Index",departmentFromModel);
        }
    }
}
