using MediatR;
using System.ComponentModel.DataAnnotations.Schema;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.Locations
{
    public class PostLocation
    {
        public class ExecuteLocation : IRequest
        {
            public int cityId { get; set; }
            public City City { get; set; }
            public string? postalCode { get; set; }
            public string locationDescription { get; set; }
        }

        public class Handler : IRequestHandler<ExecuteLocation>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(ExecuteLocation request, CancellationToken cancellationToken)
            {
                var location = new Location
                {
                    cityId = request.City.cityId,
                    postalCode = request.postalCode,
                    locationDescription = request.locationDescription,
                };
                _context.Locations.Add(location);
                var value = await _context.SaveChangesAsync();
                if (value > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo registrar la localizacion");
            }
        }
    }
}
