using Microsoft.AspNetCore.Mvc;

namespace DevQuiz.WEB.Controllers
{
    public class PythonQuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
