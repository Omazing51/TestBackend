using MediatR;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.HotelImages
{
    public class GetHotelImagesById
    {
        public class UniqueHI : IRequest<HotelImage>
        {
            public int imageId { get; set; }
        }

        public class Handler : IRequestHandler<UniqueHI, HotelImage>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }

            public async Task<HotelImage> Handle(UniqueHI request, CancellationToken cancellationToken)
            {
                var hi = await _context.HotelImages.FindAsync(request.imageId);
                return hi;
            }
        }
    }
}
