using MediatR;
using Microsoft.AspNetCore.Identity;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.Users
{
    public class LoginUser
    {
        public class ExecuteUserr : IRequest<User> 
        {
            public string UserName { get; set; }    
            public string userPassword { get; set; }
        }

       
        public class Handler : IRequestHandler<ExecuteUserr, User>
        {
            private readonly UserManager<User> _userManager;    
            private readonly SignInManager<User> _signInManager;
            public Handler(UserManager<User> userManager, SignInManager<User> signInManager)
            {
                _userManager= userManager;
                _signInManager= signInManager;
            }
            public async Task<User> Handle(ExecuteUserr request, CancellationToken cancellationToken)
            {
                var user = await _userManager.FindByNameAsync(request.UserName);
             
                if (user == null)
                {
                    throw new Exception("No se encuentra el usuario");
                }

               var result = await _signInManager.CheckPasswordSignInAsync(user, request.userPassword, false);
                if (result.Succeeded)
                {
                    return user;
                }

                throw new Exception("El inicio de sesion no fue exitoso");
            }
        }
    
    }
}
