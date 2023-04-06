using MediatR;
using Microsoft.EntityFrameworkCore;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.HotelImages
{
    public class GetHotelImages
    {
        public class HotelImagesList : IRequest<List<HotelImage>> { }

        public class Handler : IRequestHandler<HotelImagesList, List<HotelImage>>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }

            public async Task<List<HotelImage>> Handle(HotelImagesList request, CancellationToken cancellationToken)
            {
                var hi = await _context.HotelImages.Include(x => x.Hotel).ToListAsync();
                return hi;
            }
        }
    }
}
