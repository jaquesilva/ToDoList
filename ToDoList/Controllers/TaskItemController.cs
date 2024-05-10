using Microsoft.AspNetCore.Mvc;
using System;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class TaskItemController : Controller
    {
        // Estou utilizando uma lista para representar o BD.
        private static List<TaskItem> _tasks = new List<TaskItem>()
        {
            new TaskItem { TaskId= 1, TaskName="Estudar", Status=TaskItem.TaskStatus.ToDo, TaskCompletedDate=DateTime.Now.AddDays(1) },
            new TaskItem { TaskId= 2, TaskName="Trabalhar", Status=TaskItem.TaskStatus.ToDo, TaskCompletedDate=DateTime.Now.AddDays(2) }
        };
        public IActionResult Index()
        {
            return View(_tasks);
        }
    }
}
