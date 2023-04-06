using MediatR;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.Users
{
    public class GetUserById
    {
        public class UniqueUser : IRequest<User>
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<UniqueUser, User>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }

            public async Task<User> Handle(UniqueUser request, CancellationToken cancellationToken)
            {
                var user = await _context.Users.FindAsync(request.Id);
                return user;
            }
        }
    }
}
