using MediatR;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.Hotels
{
    public class PostHotel
    {
        public class ExecuteHotel : IRequest
        {
            public string hotelName { get; set; }
            public string hotelDescription { get; set; }
            public int locationId { get; set; }
            public Location Location { get; set; }
            public int hotelClassId { get; set; }
            public HotelClass HotelClass { get; set; }
            public int hotelStatusId { get; set; }
            public HotelStatus HotelStatus { get; set; }
        }

        public class Handler : IRequestHandler<ExecuteHotel>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(ExecuteHotel request, CancellationToken cancellationToken)
            {
                var hotel = new Hotel
                {
                    hotelName = request.hotelName,
                    hotelDescription = request.hotelDescription,
                    locationId = request.Location.locationId,
                    hotelClassId = request.HotelClass.hotelClassId,
                    hotelStatusId = request.HotelStatus.statusId,
                };
                _context.Hotels.Add(hotel);
                var value = await _context.SaveChangesAsync();
                if (value > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo registrar el hotel");
            }
        }
    }
}
