using MediatR;
using Microsoft.EntityFrameworkCore;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.HotelStatusses
{
    public class GetHotelStatus
    {
        public class HotelStatussesList : IRequest<List<HotelStatus>> { }

        public class Handler : IRequestHandler<HotelStatussesList, List<HotelStatus>>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }

            public async Task<List<HotelStatus>> Handle(HotelStatussesList request, CancellationToken cancellationToken)
            {
                var hotelstatusses = await _context.HotelStatuses.ToListAsync();
                return hotelstatusses;
            }
        }
    }
}
