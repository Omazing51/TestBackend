using MediatR;
using Microsoft.EntityFrameworkCore;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.Bookings
{
    public class GetBooking
    {
        public class BookingsList : IRequest<List<Booking>> { }

        public class Handler : IRequestHandler<BookingsList, List<Booking>>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context) 
            { 
                _context = context;
            }
            public async Task<List<Booking>> Handle(BookingsList request, CancellationToken cancellationToken)
            {
                var bookings = await _context.Bookings.ToListAsync();
                return bookings;
            }
        }
    }
}
