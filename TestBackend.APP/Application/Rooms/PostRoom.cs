using MediatR;
using System.ComponentModel.DataAnnotations.Schema;
using TestBackend.CONTEXT.Context;
using TestBackend.MODEL.Entities;

namespace TestBackend.APP.Application.Rooms
{
    public class PostRoom
    {
        public class ExecuteRoom : IRequest
        {
            public string roomName { get; set; }
            public string roomDescription { get; set; }
            public string location { get; set; }
            public int hotelId { get; set; }
            public int roomTypeId { get; set; }
            public int roomStatusId { get; set; }
        }

        public class Handler : IRequestHandler<ExecuteRoom>
        {
            private readonly TestBackendContext _context;
            public Handler(TestBackendContext context)
            {
                _context = context;
            }
            public async Task<Unit> Handle(ExecuteRoom request, CancellationToken cancellationToken)
            {
                var room = new Room
                {
                    roomName = request.roomName,
                    roomDescription = request.roomDescription,
                    location = request.location,
                    hotelId = request.hotelId,
                    roomTypeId = request.roomTypeId,
                    roomStatusId = request.roomStatusId,
                };
                _context.Rooms.Add(room);
                var value = await _context.SaveChangesAsync();
                if (value > 0)
                {
                    return Unit.Value;
                }

                throw new Exception("No se pudo registrar la habitacion");
            }
        }
    }
}
