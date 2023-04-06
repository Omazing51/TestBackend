using MediatR;
using Microsoft.EntityFrameworkCore;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.Hotels
{
    public class GetHotel
    {
        public class HotelsList : IRequest<List<Hotel>> { }

        public class Handler : IRequestHandler<HotelsList, List<Hotel>>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }

            public async Task<List<Hotel>> Handle(HotelsList request, CancellationToken cancellationToken)
            {
                var hotels = await _context.Hotels.Include(x => x.Location).ThenInclude(x => x.City).Include(x => x.HotelClass).Include(x => x.HotelStatus).ToListAsync();
                return hotels;
            }
        }
    }
}
