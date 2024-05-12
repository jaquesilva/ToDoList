using Microsoft.AspNetCore.Mvc;
using System;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ToDoTasks() 
        {
            return View();
        }

        public IActionResult DoneTasks()
        {
            return View();
        }
    }
}
