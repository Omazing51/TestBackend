using MediatR;
using TestBackend.CONTEXT.Context;

namespace TestBackend.APP.Application.HotelStatusses
{
    public class DelHotelStatus
    {
        public class DeleteHotelStatus : IRequest
        {
            public int statusId { get; set; }
        
        }

        public class Handler : IRequestHandler<DeleteHotelStatus>
        {
            private readonly TestBackendContext _context;

            public Handler(TestBackendContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(DeleteHotelStatus request, CancellationToken cancellationToken)
            {
                var hotelstatus = await _context.HotelStatuses.FindAsync(request.statusId);
                if (hotelstatus == null)
                {

                    throw new Exception("No se encontro el estado");
                }
                _context.HotelStatuses.Remove(hotelstatus);

                var resultt = await _context.SaveChangesAsync();

                if (resultt > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo eliminar el estado");

            }
        }
    }
}
