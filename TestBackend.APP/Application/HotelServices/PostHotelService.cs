using MediatR;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.HotelServices
{
    public class PostHotelService
    {
        public class ExecuteHS : IRequest
        {
            public int hotelId { get; set; }
            public int serviceId { get; set; }
        }

        public class Handler : IRequestHandler<ExecuteHS>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(ExecuteHS request, CancellationToken cancellationToken)
            {
                var hs = new HotelService
                {
                    hotelId = request.hotelId,
                    serviceId = request.serviceId,
                };
                _context.HotelServices.Add(hs);
                var value = await _context.SaveChangesAsync();
                if (value > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo registrar el hotelservicio");
            }
        }
    }
}
