using DevQuiz.WEB.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevQuiz.WEB.Controllers.API
{
    [ApiController]
    [Route("Controllers/API/[controller]")]
    public class ScoreController : ControllerBase
    {
        private readonly IdentityDbContext _dbContext;

        public ScoreController(IdentityDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult SaveScore([FromBody] int score)
        {
            try
            {
                // Salvar a pontuação no banco de dados ou realizar outras ações necessárias
                var user = new User
                {
                    Score = score
                    // Adicionar quaisquer outras propriedades relacionadas ao usuário, se necessário
                };

                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();

                // Retornar uma resposta indicando sucesso ou outros dados que você deseja retornar
                return Ok();
            }
            catch (Exception ex)
            {
                // Retornar uma resposta de erro com a mensagem detalhada da exceção
                return StatusCode(500, $"Erro ao salvar a pontuação: {ex.Message}");
            }
        }
    }
}
