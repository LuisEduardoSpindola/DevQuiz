using Microsoft.AspNetCore.Mvc;

namespace DevQuiz.WEB.Controllers
{
    public class EnglishQuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
