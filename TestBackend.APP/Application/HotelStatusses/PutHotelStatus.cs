using MediatR;
using TestBackend.CONTEXT.Context;

namespace TestBackend.APP.Application.HotelStatusses
{
    public class PutHotelStatus
    {
        public class EditHotelStatus : IRequest
        {
            public int statusId { get; set; }
            public string statusDescription { get; set; }
        }

        public class Handler : IRequestHandler<EditHotelStatus>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(EditHotelStatus request, CancellationToken cancellationToken)
            {
                var HotelStatus = await _context.HotelStatuses.FindAsync(request.statusId);
                if (HotelStatus == null)
                {
                    //Si no encuentra el usuario el HttpStatusCode es tipo NotFound y el msj seria un objeto de tipo error
                    throw new Exception("No se pudo encontrar el servicio");
                }

              
                HotelStatus.statusDescription = request.statusDescription ?? request.statusDescription;

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
