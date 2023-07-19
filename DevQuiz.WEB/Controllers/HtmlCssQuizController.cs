using Microsoft.AspNetCore.Mvc;

namespace DevQuiz.WEB.Controllers
{
    public class HtmlCssQuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
