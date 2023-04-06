using MediatR;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.HotelStatusses
{
    public class GetHotelStatusById
    {
        public class UniqueHotelStatus : IRequest<HotelStatus>
        {
            public int HotelStatusId { get; set; }
        }

        public class Handler : IRequestHandler<UniqueHotelStatus, HotelStatus>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }

            public async Task<HotelStatus> Handle(UniqueHotelStatus request, CancellationToken cancellationToken)
            {
                var hotelstatus = await _context.HotelStatuses.FindAsync(request.HotelStatusId);
                return hotelstatus;
            }
        }
    }
}
