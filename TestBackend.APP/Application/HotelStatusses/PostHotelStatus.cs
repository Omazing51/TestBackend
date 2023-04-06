using MediatR;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.HotelStatusses
{
    public class PostHotelStatus
    {
        public class ExecuteStatus : IRequest
        {
            public string statusDescription { get; set; }
        }

        public class Handler : IRequestHandler<ExecuteStatus>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(ExecuteStatus request, CancellationToken cancellationToken)
            {
                var hotelstatus = new HotelStatus
                {
                    statusDescription = request.statusDescription,
                };
                _context.HotelStatuses.Add(hotelstatus);
                var value = await _context.SaveChangesAsync();
                if (value > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo registrar el servicio");
            }
        }
    }
}
