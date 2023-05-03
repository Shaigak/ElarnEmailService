using Microsoft.AspNetCore.Identity;

namespace ClassPractic.Models
{
    public class AppUser:IdentityUser
    {

        public string FullName { get; set; }
    }
}
