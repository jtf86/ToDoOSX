using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Objects;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("view_all_tasks")]
        public ActionResult ViewAll()
        {
            List<string> allTasks = Task.GetAll();
            return View(allTasks);
        }

        [HttpPost("/tasks_cleared")]
        public ActionResult ClearAll()
        {
            Task.ClearAll();
            return View();
        }

        [HttpPost("/task_added")]
        public ActionResult AddTask()
        {
            Task newTask = new Task (Request.Form["new-task"]);
            newTask.Save();
            return View(newTask);
        }

    }
}
