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
            new TaskItem { TaskId= 1, TaskName="Estudar", Status=TaskItem.TaskStatus.Done, TaskCompletedDate=DateTime.Now.AddDays(1) },
            new TaskItem { TaskId= 2, TaskName="Trabalhar", Status=TaskItem.TaskStatus.Done, TaskCompletedDate=DateTime.Now.AddDays(2) }
        };
        public IActionResult Index()
        {
            return View(_tasks);
        }

        [HttpGet] //anotação de PEGAR
        public IActionResult Create()
        {  //chama o form de cadastro
            return View();
        }

        [HttpPost] //Anotação de ENVIAR
        public IActionResult Create(TaskItem task)
        { //recebe os dados do form    

            if (ModelState.IsValid)
            {
                task.TaskId = _tasks.Count > 0 ? _tasks.Max(c => c.TaskId) + 1 : 1;
                _tasks.Add(task);
            }
            return RedirectToAction("Index");
        }
    }
}
