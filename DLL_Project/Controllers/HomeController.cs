using DLL_Project.Models;
using EmpModelDLL.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DLL_Project.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly EmpDbContext _context;

        public HomeController( EmpDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetEmployees()
        {
            var empList = _context.Emp.ToList();
            return View("GetEmployees", empList);
        }
    }
}