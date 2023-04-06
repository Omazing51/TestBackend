using MediatR;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.Locations
{
    public class PutLocation
    {
        public class EditLocation : IRequest
        {
            public int locationId { get; set; }
            public int cityId { get; set; }
            public string? postalCode { get; set; }
            public string locationDescription { get; set; }
        }

        public class Handler : IRequestHandler<EditLocation>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(EditLocation request, CancellationToken cancellationToken)
            {
                var location = await _context.Locations.FindAsync(request.locationId);
                if (location == null)
                {
                    //Si no encuentra el usuario el HttpStatusCode es tipo NotFound y el msj seria un objeto de tipo error
                    throw new Exception("No se pudo encontrar la localizacion");
                }

                location.cityId = request.cityId;
                location.postalCode = request.postalCode ?? request.postalCode;
                location.locationDescription = request.locationDescription ?? location.locationDescription;

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
