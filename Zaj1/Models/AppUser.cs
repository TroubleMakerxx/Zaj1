
using Microsoft.AspNetCore.Identity;
namespace Zaj1.Models
{
    public class AppUser: IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }



    }
}
