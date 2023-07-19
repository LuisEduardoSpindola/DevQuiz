using Microsoft.AspNetCore.Mvc;

namespace DevQuiz.WEB.Controllers
{
    public class ReactQuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
