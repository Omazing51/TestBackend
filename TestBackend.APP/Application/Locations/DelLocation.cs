using MediatR;
using TestBackend.CONTEXT.Context;

namespace TestBackend.APP.Application.Locations
{
    public class DelLocation
    {
        public class DeleteLocation : IRequest
        {
            public int locationId { get; set; }
        }

        public class Handler : IRequestHandler<DeleteLocation>
        {
            private readonly TestBackendContext _context;

            public Handler(TestBackendContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(DeleteLocation request, CancellationToken cancellationToken)
            {
                var location = await _context.Locations.FindAsync(request.locationId);
                if (location == null)
                {

                    throw new Exception("No se encontro la localizacion");
                }
                _context.Locations.Remove(location);

                var resultt = await _context.SaveChangesAsync();

                if (resultt > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo eliminar la localizacion");

            }
        }
    }
}
