using MediatR;
using System.Net;
using TestBackend.CONTEXT.Context;

namespace TestBackend.APP.Application.Services
{
    public class DelService
    {
        public class DeleteService : IRequest
        {
            public int serviceId { get; set; }
        }

        public class Handler : IRequestHandler<DeleteService>
        {
            private readonly TestBackendContext _context;

            public Handler(TestBackendContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(DeleteService request, CancellationToken cancellationToken)
            {
                var service = await _context.Services.FindAsync(request.serviceId);
                if (service == null)
                {
       
                    throw new Exception("No se encontro el servicio");
                }
                _context.Services.Remove(service);

                var resultt = await _context.SaveChangesAsync();

                if (resultt > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo eliminar el servicio");

            }
        }
    }
}
