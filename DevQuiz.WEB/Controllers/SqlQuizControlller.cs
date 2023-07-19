using Microsoft.AspNetCore.Mvc;

namespace DevQuiz.WEB.Controllers
{
    public class SqlQuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
