using MediatR;
using Microsoft.EntityFrameworkCore;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.Services
{
    public class GetService
    {
        public class ServicesList : IRequest<List<Service>> { }

        public class Handler : IRequestHandler<ServicesList, List<Service>>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }

            public async Task<List<Service>> Handle(ServicesList request, CancellationToken cancellationToken)
            {
                var services = await _context.Services.ToListAsync();
                return services;
            }
        }
    }
}
