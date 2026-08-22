using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class StateController : Controller
    {
       public IActionResult SetSession(string Name)
        {
            //login
            HttpContext.Session.SetString("Name", Name);

            HttpContext.Session.SetInt32("Age", 21);

            return Content("Data session Save Success");
        }
        public IActionResult GetSession() {
          string a=  HttpContext.Session.GetString("Name");
            int? age = HttpContext.Session.GetInt32("Age");

            return Content($"name={a} \t age={age}");


        }
    }
}
