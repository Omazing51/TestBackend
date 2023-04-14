using MediatR;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.HotelImages
{
    public class PostHotelImage
    {
        public class ExecuteHI : IRequest
        {
            public int hotelId { get; set; }
            public string imageTittle { get; set; }
            public string extensionI { get; set; }
            public string imageUrl { get; set; }
        }

        public class Handler : IRequestHandler<ExecuteHI>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(ExecuteHI request, CancellationToken cancellationToken)
            {
                var hi = new HotelImage
                {
                    hotelId = request.hotelId,
                    imageTittle = request.imageTittle,
                    extensionI = request.extensionI,
                    imageUrl = System.Convert.FromBase64String(request.imageUrl),
                };
                _context.HotelImages.Add(hi);
                var value = await _context.SaveChangesAsync();
                if (value > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo registrar la imagen");
            }
        }
    }
}
