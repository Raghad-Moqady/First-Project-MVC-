using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    { 
        ApplicationDbcontext context =new ApplicationDbcontext();
        public IActionResult Index()
        {
            var employee = context.Employees.ToList();
            return View("Index",employee);
        }
    }
}
