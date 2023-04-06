using MediatR;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.HotelClasses
{
    public class GetHCById
    {

        public class UniqueHC : IRequest<HotelClass>
        {
            public int hotelClassId { get; set; }
        }

        public class Handler : IRequestHandler<UniqueHC, HotelClass>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }

            public async Task<HotelClass> Handle(UniqueHC request, CancellationToken cancellationToken)
            {
                var hc = await _context.HotelClasses.FindAsync(request.hotelClassId);
                return hc;
            }
        }
    }
}

