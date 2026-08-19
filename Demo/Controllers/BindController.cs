using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class BindController : Controller
    {
        //1-primitive biinding
        //<form action ="bind/testprimitive" method="get">
        //<input type="text" name="name">
        //input type="number name="age">
        //primitive=>int-string
        public IActionResult  TestPremitive(string name , int age)
        {
            return Content($"{name}\t{age}");
        }

        //bind collection
        //bind/TestDic?phones[Ahmed]=123
        public IActionResult TestDic(Dictionary<string,string> phones)
        {
            return Content("ok");
        }

        //bind obj

        //bind/testobj?id=1&name=It&managername=ali&color=red

        public IActionResult testobj(Department deptObj,int id)
        {
            return Content("obj");
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
