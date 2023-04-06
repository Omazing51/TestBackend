using MediatR;
using TestBackend.CONTEXT.Context;

namespace TestBackend.APP.Application.Hotels
{
    public class DelHotel
    {
        public class DeleteHotel : IRequest
        {
            public int hotelId { get; set; }
        }

        public class Handler : IRequestHandler<DeleteHotel>
        {
            private readonly TestBackendContext _context;

            public Handler(TestBackendContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(DeleteHotel request, CancellationToken cancellationToken)
            {
                var hotel = await _context.Hotels.FindAsync(request.hotelId);
                if (hotel == null)
                {

                    throw new Exception("No se encontro el hotel");
                }
                _context.Hotels.Remove(hotel);

                var resultt = await _context.SaveChangesAsync();

                if (resultt > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo eliminar el hotel");

            }
        }
    }
}
