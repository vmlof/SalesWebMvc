﻿using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers;

public class DepartmentsController : Controller
{
    // GET
    public IActionResult Index()
    {
        List<Department> departments = new List<Department>();
        
        departments.Add(new Department{ Id = 1, Name = "Electronics" });
        departments.Add(new Department{ Id = 2, Name = "Fashion" });
        
        return View(departments);
    }
}