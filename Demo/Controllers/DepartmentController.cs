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
        [HttpGet]
        public IActionResult add()
        {
            return View("Add");
        }
        [HttpPost]
        public IActionResult SaveAdd(Department DeptObjFromReq)
        {
            if(DeptObjFromReq.Name != null)
            {
                Context.departments.Add(DeptObjFromReq);
                Context.SaveChanges();

                return RedirectToAction("index");
            }
            return View("add",DeptObjFromReq);

        }
    }
}
