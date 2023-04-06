using MediatR;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.Hotels
{
    public class PutHotel
    {
        public class EditHotel : IRequest
        {
            public int hotelId { get; set; }
            public string hotelName { get; set; }
            public string hotelDescription { get; set; }
            public int locationId { get; set; }
            public Location Location { get; set; }
            public int hotelClassId { get; set; }
            public HotelClass HotelClass { get; set; }
            public int hotelStatusId { get; set; }
            public HotelStatus HotelStatus { get; set; }
        }

        public class Handler : IRequestHandler<EditHotel>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(EditHotel request, CancellationToken cancellationToken)
            {
                var hotel = await _context.Hotels.FindAsync(request.hotelId);
                if (hotel == null)
                {
                    //Si no encuentra el usuario el HttpStatusCode es tipo NotFound y el msj seria un objeto de tipo error
                    throw new Exception("No se pudo encontrar el hotel");
                }


                hotel.hotelName = request.hotelName ?? request.hotelName;
                hotel.hotelDescription = request.hotelDescription ?? request.hotelDescription;
                hotel.locationId = request.Location.locationId;
                hotel.hotelClassId = request.HotelClass.hotelClassId;
                hotel.hotelStatusId = request.HotelStatus.statusId;

                var valor = await _context.SaveChangesAsync();

                if (valor > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se guardaron los cambios");

            }
        }
    }
}
