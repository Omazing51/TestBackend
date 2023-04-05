using MediatR;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.Services
{
    public class PostService
    {
        public class Execute : IRequest
        {
            public string serviceName { get; set; }
            public string serviceDescription { get; set; }
        }

        public class Handler : IRequestHandler<Execute>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(Execute request, CancellationToken cancellationToken)
            {
                var service = new Service
                {
                    serviceName = request.serviceName,
                    serviceDescription = request.serviceDescription,
                };
                _context.Services.Add(service);
                var value = await _context.SaveChangesAsync();
                if (value > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo registrar el servicio");
            }
        }
    }
}
