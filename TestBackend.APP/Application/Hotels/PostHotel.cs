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
            public int hotelClassId { get; set; }
            public int hotelStatusId { get; set; }
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
                    locationId = request.locationId,
                    hotelClassId = request.hotelClassId,
                    hotelStatusId = request.hotelStatusId,
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
