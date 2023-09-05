using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers;

public class DepartmentsController : Controller
{
    public IActionResult Index()
    {
        List<Department> departments = new()
        {
            new Department { Id = 1, Name = "IT" },
            new Department { Id = 2, Name = "Marketing" }
        };

        return View(departments);
    }
}