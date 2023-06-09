﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SO75965421.Models;

namespace SO75965421.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["Roles"] = new List<Role>
        {
            new Role { RoleTitle = "Role1" },
            new Role { RoleTitle = "Role2" },
            new Role { RoleTitle = "Admin" },
            new Role { RoleTitle = "User" }
        };

        return View(new IndexViewModel
        {
            userRole = new List<string>
            {
                "Role2",
                "Admin"
            }
        });
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

