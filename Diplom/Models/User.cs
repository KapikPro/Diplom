using Microsoft.AspNetCore.Identity;

namespace Diplom.Models
{
    public class User:IdentityUser
    {
        public DateTime DateOfCreation {  get; set; }
    }
}
