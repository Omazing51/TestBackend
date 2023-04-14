using MediatR;
using Microsoft.EntityFrameworkCore;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.Rooms
{
    public class GetRoom
    {
        public class RoomsList : IRequest<List<Room>> { }

        public class Handler : IRequestHandler<RoomsList, List<Room>>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }

            public async Task<List<Room>> Handle(RoomsList request, CancellationToken cancellationToken)
            {
                var rooms = await _context.Rooms.Include(x => x.Hotel).Include(x => x.RoomType).Include(x => x.RoomStatus).ToListAsync();
                return rooms;
            }
        }
    }
}
