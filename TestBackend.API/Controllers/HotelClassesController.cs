using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestBackend.APP.Application.HotelClasses;
using TestBackend.MODEL.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
        public async Task<ActionResult<Unit>> Create(PostHC.ExecuteHotelClass data)
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
