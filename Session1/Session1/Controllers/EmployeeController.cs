using Microsoft.AspNetCore.Mvc;
using Session1.Data;


namespace Session1.Controllers
{
    public class EmployeeController : Controller
    {
        // ApplicationDbContext context = new ApplicationDbContext();
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var employees = context.employees.ToList();
            return View("Index",employees);
        }
    }
}
