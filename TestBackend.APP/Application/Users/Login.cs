using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TestBackend.APP.Application.Agreements;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.Users
{
    public class Login
    {
        public class ExecuteUserr : IRequest<UserData>
        {
            [Required(ErrorMessage = "Debe ingresar su email")]
            public string email { get; set; }
            [Required(ErrorMessage =  "Debe ingresar su contraseña")]
            public string userPassword { get; set; }

        }


        public class Handler : IRequestHandler<ExecuteUserr, UserData>
        {
            private readonly UserManager<User> _userManager;
            private readonly SignInManager<User> _signInManager;
            private readonly TestBackendContext _context;
            private readonly IJwtGenerator _jwtGenerator;
            public Handler(UserManager<User> userManager, SignInManager<User> signInManager, TestBackendContext context, IJwtGenerator jwtGenerator)
            {
                _userManager = userManager;
                _signInManager = signInManager;
                _context = context;
                _jwtGenerator = jwtGenerator;
            }
            public async Task<UserData> Handle(ExecuteUserr request, CancellationToken cancellationToken)
            {
                var user = await _context.Users.Where(x => x.Email == request.email).FirstOrDefaultAsync();

                if (user == null)
                {
                    throw new Exception("No se encuentra el usuario");
                }

                var result = await _context.Users.Where(x => x.Email == request.email && x.userPassword == request.userPassword).FirstOrDefaultAsync();
                if (result != null)
                {
                    return new UserData
                    {
                        Email = user.Email,
                        Token = _jwtGenerator.CreateToken(user),
                    };
                }

                throw new Exception("Usuario o contraseña incorrectos");
            }
        }
    }
}
