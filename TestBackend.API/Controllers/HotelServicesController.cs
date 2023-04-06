using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestBackend.APP.Application.HotelServices;
using TestBackend.APP.Application.Services;
using TestBackend.MODEL.Entities;

namespace TestBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelServicesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public HotelServicesController(IMediator mediator)
        {
            _mediator = mediator;   
        }
        [HttpGet]
        public async Task<ActionResult<List<HotelService>>> Get()
        {
            return await _mediator.Send(new GetHotelService.HotelServicesList());
        }

        
        [HttpPost]
        public async Task<ActionResult<Unit>> Create(PostHotelService.ExecuteHS data)
        {
            return await _mediator.Send(data);
        }

    }
}
