using DevQuiz.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevQuiz.WEB.Controllers
{
    public class CSharpQuizController : Controller
    {
        public IActionResult CSharpQuiz()
        {
            return View();
        }
    }
}
