using DevQuiz.WEB.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; // Certifique-se de importar o namespace necessário.

namespace DevQuiz.WEB.Controllers.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScoreController : ControllerBase
    {
        private readonly DbContextOptions<DbContextIdentity> _dbContextOptions;

        public ScoreController(DbContextOptions<DbContextIdentity> dbContextOptions)
        {
            _dbContextOptions = dbContextOptions;
        }

        [HttpPost]
        public IActionResult SaveScore(int score)
        {
            // Save the score to the database or perform any other necessary actions
            using (var context = new DbContextIdentity(_dbContextOptions))
            {
                var user = new User
                {
                    Score = score
                    // Add any other user-related properties as needed
                };

                context.Users.Add(user);
                context.SaveChanges();
            }

            // Return a response indicating success or any other data you want to return.
            return Ok();
        }
    }
}
