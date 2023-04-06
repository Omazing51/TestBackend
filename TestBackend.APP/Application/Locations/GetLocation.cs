using MediatR;
using Microsoft.EntityFrameworkCore;
using TestBackend.CONTEXT.Context;
using TestBackend.CONTEXT.Migrations;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.Locations
{
    public class GetLocation
    {
        public class LocationsList : IRequest<List<Location>> { }

        public class Handler : IRequestHandler<LocationsList, List<Location>>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }

            public async Task<List<Location>> Handle(LocationsList request, CancellationToken cancellationToken)
            {
                var location = await _context.Locations.ToListAsync();
                return location;
            }
        }
    }
}
