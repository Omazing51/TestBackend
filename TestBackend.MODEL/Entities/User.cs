using Microsoft.AspNetCore.Identity;

namespace TestBackend.MODEL.Entities
{
    public class User : IdentityUser
    {
        public string userPassword { get; set; }
    }
}
