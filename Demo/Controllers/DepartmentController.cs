using Demo.Models;
using Demo.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository DeptRepo;

        //DepartmentRepository DeptRepo = new DepartmentRepository();

        public DepartmentController(IDepartmentRepository department)
        {
            this.DeptRepo = department;
        }
        public IActionResult Index()
        {
            List<Department> departmentFromModel =DeptRepo.GetAll();
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
                DeptRepo.Add(DeptObjFromReq);
                DeptRepo.Save();

                return RedirectToAction("index");
            }
            return View("add",DeptObjFromReq);

        }
    }
}
