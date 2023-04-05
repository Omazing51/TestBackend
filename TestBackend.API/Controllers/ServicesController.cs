using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestBackend.APP.Application.Services;
using TestBackend.MODEL.Entities;

namespace TestBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ServicesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Service>>> Get()
        {
            return await _mediator.Send(new GetService.ServicesList());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Service>> Detail(int id)
        {
            return await _mediator.Send(new GetServiceById.UniqueService { serviceId = id});
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Create(PostService.Execute data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Unit>> Edit(int id, PutService.EditService data)
        {
            return await _mediator.Send(data);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(int id)
        {
            return await _mediator.Send(new DelService.DeleteService { serviceId = id});
        }

    }
}
