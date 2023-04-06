using MediatR;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.Hotels
{
    public class GetHotelById
    {
        public class UniqueHotel : IRequest<Hotel>
        {
            public int hotelId { get; set; }
        }

        public class Handler : IRequestHandler<UniqueHotel, Hotel>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }

            public async Task<Hotel> Handle(UniqueHotel request, CancellationToken cancellationToken)
            {
                var hotel = await _context.Hotels.FindAsync(request.hotelId);
                return hotel;
            }
        }
    }
}
