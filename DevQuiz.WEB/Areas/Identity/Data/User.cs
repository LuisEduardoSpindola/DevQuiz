using Microsoft.AspNetCore.Identity;

namespace DevQuiz.WEB.Areas.Identity.Data
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string UserImage { get; set; }
        public int Score { get; set; }
    }
}
