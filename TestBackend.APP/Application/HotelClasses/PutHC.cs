using MediatR;
using TestBackend.CONTEXT.Context;

namespace TestBackend.APP.Application.HotelClasses
{
    public class PutHC
    {
        public class EditHC : IRequest
        {
            public int hotelClassId { get; set; }
            public string hotelClassName { get; set; }
            public string hotelClassDescription { get; set; }
        }

        public class Handler : IRequestHandler<EditHC>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(EditHC request, CancellationToken cancellationToken)
            {
                var hc = await _context.HotelClasses.FindAsync(request.hotelClassId);
                if (hc == null)
                {
                    //Si no encuentra el usuario el HttpStatusCode es tipo NotFound y el msj seria un objeto de tipo error
                    throw new Exception("No se pudo encontrar la clase de hotel");
                }

                hc.hotelClassName = request.hotelClassName?? request.hotelClassName;
                hc.hotelClassDescription = request.hotelClassDescription?? request.hotelClassDescription;

                var valor = await _context.SaveChangesAsync();

                if (valor > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se guardaron los cambios");

            }
        }
    }
}
