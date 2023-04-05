using MediatR;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.Services
{
    public class GetServiceById
    {
        public class UniqueService : IRequest<Service>
        {
            public int Id { get; set; }
        }

        public class Handler : IRequestHandler<UniqueService, Service>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }

            public async Task<Service> Handle(UniqueService request, CancellationToken cancellationToken)
            {
                var service = await _context.Services.FindAsync(request.Id);
                return service;
            }
        }
    }
}
