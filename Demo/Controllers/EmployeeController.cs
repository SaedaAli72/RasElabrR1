using Demo.Models;
using Demo.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo.Controllers
{
    public class EmployeeController : Controller
    {
        ITIContext context = new ITIContext();
       

        public IActionResult index()
        {
            List<Employee> employees = context.Employees.Include(e=>e.Department).ToList();
            return View("index", employees);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewData["DeptList"] = context.departments.ToList();
            return View("Add");

        }

        [HttpPost]
        public IActionResult SaveAdd(Employee EmpFromRequest)
        {
            if(ModelState.IsValid)
            {
                context.Employees.Add(EmpFromRequest);
                context.SaveChanges();
                return RedirectToAction("index");
            }
            ViewData["DeptList"] = context.departments.ToList();
            return View("Add", EmpFromRequest);

        }
       












        string Msg = "Hello from Action";
        int Temp = 30;
        //employee/details?id=1

        public IActionResult Details(int id)
        {
           
            Employee employeeFromModel = context.Employees.FirstOrDefault(e => e.Id == id);

           
            List<string> Branches = new List<string> { "New Village", "Ras Elbar", "Mansoura", "Alex" };

            //additional data send from action to view
            ViewData["Msg"] = Msg;
            ViewData["Temp"] = Temp;
            ViewData["Branches"] = Branches;
            ViewData["Color"] = "Red";
            ViewBag.Color= "Blue";



            return View("Details", employeeFromModel);
        }

        //employee/detailsvm?id=2
        public IActionResult DetailsVM(int id)
        {
            Employee employeeFromModel = context.Employees.Include(e=>e.Department).FirstOrDefault(e => e.Id == id);

            List<string> Branches = new List<string> { "New Village", "Ras Elbar", "Mansoura", "Alex" };

            //declar vm
            EmpWithMsgTempBranches empWithMsgTemp = new EmpWithMsgTempBranches();

            //maping
            empWithMsgTemp.EmpName = employeeFromModel.Name;
            empWithMsgTemp.DeptName = employeeFromModel.Department.Name;
            empWithMsgTemp.Msg = Msg;
            empWithMsgTemp.Temp = Temp;
            empWithMsgTemp.Branches = Branches;

            return View("DetailsVm", empWithMsgTemp);



            //1-more than model
            //2-security
            //3-extra info

        }







       
    }
}
