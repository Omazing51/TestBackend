using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestBackend.APP.Application.HotelImages;
using TestBackend.APP.Application.Services;
using TestBackend.MODEL.Entities;

namespace TestBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelImagesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public HotelImagesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<HotelImage>>> Get()
        {
            return await _mediator.Send(new GetHotelImages.HotelImagesList());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HotelImage>> Detail(int id)
        {
            return await _mediator.Send(new GetHotelImagesById.UniqueHI{ imageId = id });
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Create(PostHotelImage.ExecuteHI data)
        {
            return await _mediator.Send(data);
        }

    }
}
