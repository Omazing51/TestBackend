using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestBackend.APP.Application.Locations;
using TestBackend.MODEL.Entities;

namespace TestBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LocationsController(IMediator mediator)
        {
            _mediator = mediator;

        }

        [HttpGet]
        public async Task<ActionResult<List<Location>>> Get()
        {
            return await _mediator.Send(new GetLocation.LocationsList());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Location>> Detail(int id)
        {
            return await _mediator.Send(new GetLocationById.UniqueLocation { locationId = id });
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Create(PostLocation.ExecuteLocation data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Unit>> Edit(int id, PutLocation.EditLocation data)
        {
            data.locationId = id;
            return await _mediator.Send(data);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(int id)
        {
            return await _mediator.Send(new DelLocation.DeleteLocation{ locationId = id });
        }

    }
}
