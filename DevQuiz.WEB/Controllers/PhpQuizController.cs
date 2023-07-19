using Microsoft.AspNetCore.Mvc;

namespace DevQuiz.WEB.Controllers
{
    public class PhpQuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
