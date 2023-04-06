using MediatR;
using Microsoft.EntityFrameworkCore;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.HotelClasses
{
    public class GetHC
    {
        public class HCList : IRequest<List<HotelClass>> { }

        public class Handler : IRequestHandler<HCList, List<HotelClass>>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }

            public async Task<List<HotelClass>> Handle(HCList request, CancellationToken cancellationToken)
            {
                var hc = await _context.HotelClasses.ToListAsync();
                return hc;
            }
        }
    }
}
