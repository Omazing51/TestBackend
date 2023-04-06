using MediatR;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.HotelClasses
{
    public class PostHC
    {
        public class ExecuteHotelClass : IRequest
        {
            public string hotelClassName { get; set; }
            public string hotelClassDescription { get; set; }
        }

        public class Handler : IRequestHandler<ExecuteHotelClass>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(ExecuteHotelClass request, CancellationToken cancellationToken)
            {
                var hc = new HotelClass
                {
                    hotelClassName = request.hotelClassName,
                    hotelClassDescription = request.hotelClassDescription,
                };
                _context.HotelClasses.Add(hc);
                var value = await _context.SaveChangesAsync();
                if (value > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo registrar la clase de hotel");
            }
        }
    }
}
