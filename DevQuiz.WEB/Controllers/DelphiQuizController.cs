using Microsoft.AspNetCore.Mvc;

namespace DevQuiz.WEB.Controllers
{
    public class DelphiQuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
