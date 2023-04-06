using MediatR;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.Locations
{
    public class GetLocationById
    {
        public class UniqueLocation : IRequest<Location>
        {
            public int locationId { get; set; }
        }

        public class Handler : IRequestHandler<UniqueLocation, Location>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }

            public async Task<Location> Handle(UniqueLocation request, CancellationToken cancellationToken)
            {
                var location = await _context.Locations.FindAsync(request.locationId);
                return location;
            }
        }
    }
}
