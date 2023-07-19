using Microsoft.AspNetCore.Mvc;

namespace DevQuiz.WEB.Controllers
{
    public class UiUxQuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
