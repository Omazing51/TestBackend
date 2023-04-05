using MediatR;
using System.Net;
using TestBackend.CONTEXT.Context;

namespace TestBackend.APP.Application.Services
{
    public class PutService
    {
        public class EditService : IRequest
        {
            public int serviceId { get; set; }
            public string serviceName { get; set; }
            public string serviceDescription { get; set; }
        }

        public class Handler : IRequestHandler<EditService>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(EditService request, CancellationToken cancellationToken)
            {
                var service = await _context.Services.FindAsync(request.serviceId);
                if (service == null)
                {
                    //Si no encuentra el usuario el HttpStatusCode es tipo NotFound y el msj seria un objeto de tipo error
                    throw new Exception("No se pudo encontrar el servicio");
                }

                service.serviceName = request.serviceName?? request.serviceName;
                service.serviceDescription = request.serviceDescription?? request.serviceDescription;

                var valor = await _context.SaveChangesAsync();

                if (valor > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se guardaron los cambios");

            }
        }
    }
}
