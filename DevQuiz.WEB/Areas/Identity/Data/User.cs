using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DevQuiz.WEB.Areas.Identity.Data;

// Add profile data for application users by adding properties to the Library class
public class User : IdentityUser
{
    public string Name { get; set; }
    public string UserImage { get; set; }
    public int Score { get; set; }

}

