using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "TaskItem");
        }
    }
}
