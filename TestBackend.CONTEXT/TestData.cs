using Microsoft.AspNetCore.Identity;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.CONTEXT
{
    public class TestData
    {
        public static async Task InsertData(TestBackendContext context, UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new User { UserName= "test", Email="test@gmail.com" };   
               await userManager.CreateAsync(user, "pass12345");   
            }
        }
    }
}
