using DevQuiz.WEB.Constants;
using DevQuiz.WEB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevQuiz.WEB.Controllers
{
    public class QuizController : Controller
    {

        [Authorize(Roles = Roles.UserMain)]
        public IActionResult QuizBoard()
        {
            return View();
        }
    }
}