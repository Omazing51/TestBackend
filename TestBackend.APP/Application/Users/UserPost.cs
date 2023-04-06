using MediatR;
using Microsoft.AspNetCore.Identity;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.Users
{
    public class UserPost
    {
        public class ExecuteU : IRequest
        {
            public string UserName { get; set; }
            public string userPassword { get; set; }
        }

        public class Handler : IRequestHandler<ExecuteU>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(ExecuteU request, CancellationToken cancellationToken)
            {
                var user = new User
                {
                    UserName = request.UserName,
                    userPassword = request.userPassword,
                };
                _context.Users.Add(user);
                var value = await _context.SaveChangesAsync();
                if (value > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo registrar el usuario");
            }
        }
    }
}
