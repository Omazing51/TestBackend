using MediatR;
using Microsoft.EntityFrameworkCore;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.HotelServices
{
    public class GetHotelService
    {
        public class HotelServicesList : IRequest<List<HotelService>> { }

        public class Handler : IRequestHandler<HotelServicesList, List<HotelService>>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }

            public async Task<List<HotelService>> Handle(HotelServicesList request, CancellationToken cancellationToken)
            {
                var hs = await _context.HotelServices.Include(x => x.Hotel).Include(x => x.Service).ToListAsync();
                return hs;
            }
        }
    }
}
