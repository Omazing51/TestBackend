using MediatR;
using TestBackend.CONTEXT.Context;

namespace TestBackend.APP.Application.HotelClasses
{
    public class DelHC
    {
        public class DeleteHC : IRequest
        {
            public int hotelClassId { get; set; }
        }

        public class Handler : IRequestHandler<DeleteHC>
        {
            private readonly TestBackendContext _context;

            public Handler(TestBackendContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(DeleteHC request, CancellationToken cancellationToken)
            {
                var hc = await _context.HotelClasses.FindAsync(request.hotelClassId);
                if (hc == null)
                {

                    throw new Exception("No se encontro la clase de hotel");
                }
                _context.HotelClasses.Remove(hc);

                var resultt = await _context.SaveChangesAsync();

                if (resultt > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo eliminar la clase de hotel");

            }
        }
    }
}
