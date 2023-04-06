using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestBackend.APP.Application.HotelClasses;
using TestBackend.MODEL.Entities;

namespace TestBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelClassesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public HotelClassesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<HotelClass>>> Get()
        {
            return await _mediator.Send(new GetHC.HCList());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HotelClass>> Detail(int id)
        {
            return await _mediator.Send(new GetHCById.UniqueHC { hotelClassId = id });
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Create(PostHC.Execute data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Unit>> Edit(int id, PutHC.EditHC data)
        {
            data.hotelClassId = id;
            return await _mediator.Send(data);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(int id)
        {
            return await _mediator.Send(new DelHC.DeleteHC { hotelClassId = id });
        }
    }
}
