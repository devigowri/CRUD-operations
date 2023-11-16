using Microsoft.AspNetCore.Mvc;
using CRUD_operations.Models;
namespace CRUD_operations.Controllers
{
    public class EmployeeController : Controller
    {
        List<Employees> employees = new List<Employees> ();

        [HttpGet]
        public IActionResult EmployeeIndex()
        {
            return View();  
        }
        [HttpPost]
        public IActionResult AddEmployee(Employees emp)
        {
           this.employees = new List<Employees> { emp };
            return RedirectToAction("ViewAllEmployees",this.employees);
        }

        //[HttpGet]
        //public IActionResult ViewAllEmployees()
        //{
        //    return View();
        //}

    
        public IActionResult ViewAllEmployees()
        {
            
            employees.Add(new Employees { Id=1,Name="ggg",Designtation="xxxxx",CreatedDate=DateTime.Now });
            employees.Add(new Employees { Id = 2, Name = "xxx", Designtation = "12211", CreatedDate = DateTime.Now });
            employees.Add(new Employees { Id = 3, Name = "xxx", Designtation = "12211", CreatedDate = DateTime.Now });
            employees.Add(new Employees { Id = 4, Name = "xxx", Designtation = "12211", CreatedDate = DateTime.Now });
            return View(employees);
        }
    }
}
