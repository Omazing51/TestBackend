using MediatR;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.Bookings
{
    public class GetBookingById
    {
        public class UniqueBooking : IRequest<Booking>
        {
            public int Id { get; set; }
        }

        //public class Handler : IRequestHandler<UniqueBooking, Booking>
        //{
        //    private readonly TestBackendContext _context;
        //    public Handler(TestBackendContext context)
        //    {
        //        _context = context;
        //    }

        //    //public async Task<Booking> Handle(UniqueBooking request, CancellationToken cancellationToken)
        //    //{
        //    //    var booking = await _context.Bookings.FindAsync(request.Id);
        //    //    return booking;
        //    //}
        //}
    }
}
