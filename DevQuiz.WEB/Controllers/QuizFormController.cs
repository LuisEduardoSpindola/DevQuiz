using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DevQuiz.WEB.Areas.Identity.Data;

namespace DevQuiz.WEB.Controllers
{
    public class QuizFormController : Controller
    {
        private readonly IdentityDbContext _dbContext;

        public QuizFormController(IdentityDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public ActionResult ProcessQuizForm(FormCollection form)
        {
            // Recupera o nome de usuário do usuário logado (supondo que você esteja usando o Identity)
            string Name = User.Identity.Name;

            int score = int.Parse(form["score"]);

            // Atualiza o score no banco de dados para o usuário atual
            var user = _dbContext.Users.FirstOrDefault(u => u.Name == Name);
            if (user != null)
            {
                user.Score = score;
                _dbContext.SaveChanges();
            }
            else 
            {
                Console.WriteLine("Erro..............");
            }

            return RedirectToAction("Resultado");
        }
    }
}
