using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestBackend.APP.Application.Rooms;
using TestBackend.MODEL.Entities;

namespace TestBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public RoomsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        //[Authorize]
        public async Task<ActionResult<List<Room>>> Get()
        {
            return await _mediator.Send(new GetRoom.RoomsList());
        }

        [HttpPost]
        //[Authorize]
        public async Task<ActionResult<Unit>> Create(PostRoom.ExecuteRoom data)
        {
            return await _mediator.Send(data);
        }

    }
}
