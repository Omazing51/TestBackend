using MediatR;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.Bookings
{
    public class PostBooking
    {
        public class Execute : IRequest
        {
            public int hotelId { get; set; }
            public Hotel Hotel { get; set; }
            public int statusId { get; set; }
            public BookingStatus BookingStatus { get; set; }
        }

        public class Handler : IRequestHandler<Execute>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(Execute request, CancellationToken cancellationToken)
            {
                var booking = new Booking
                {
                    hotelId = request.hotelId,
                    //Hotel = request.Hotel,
                    statusId = request.statusId,
                    //BookingStatus = request.BookingStatus,
                };
                _context.Bookings.Add(booking);
                var value = await _context.SaveChangesAsync();
                if (value > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo realizar la reserva");
            }
        }
    }
}
