using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestBackend.APP.Application.HotelStatusses;
using TestBackend.MODEL.Entities;

namespace TestBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelStatusesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public HotelStatusesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<HotelStatus>>> Get()
        {
            return await _mediator.Send(new GetHotelStatus.HotelStatussesList());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HotelStatus>> Detail(int id)
        {
            return await _mediator.Send(new GetHotelStatusById.UniqueHotelStatus { statusId = id });
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Create(PostHotelStatus.ExecuteStatus data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Unit>> Edit(int id, PutHotelStatus.EditHotelStatus data)
        {
            data.statusId = id;
            return await _mediator.Send(data);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(int id)
        {
            return await _mediator.Send(new DelHotelStatus.DeleteHotelStatus { statusId = id });
        }
    }
}
