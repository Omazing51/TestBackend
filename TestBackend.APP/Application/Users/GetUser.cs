using MediatR;
using Microsoft.EntityFrameworkCore;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.Users
{
    public class GetUser
    {
        public class UsersList : IRequest<List<User>> { }

        public class Handler : IRequestHandler<UsersList, List<User>>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }

            public async Task<List<User>> Handle(UsersList request, CancellationToken cancellationToken)
            {
                var users = await _context.Users.ToListAsync();
                return users;
            }
        }
    }
}
