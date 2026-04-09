using Microsoft.AspNetCore.Mvc;

namespace IssueTracker.Api.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
