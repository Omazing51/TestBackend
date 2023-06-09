﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestBackend.APP.Application.Hotels;
using TestBackend.MODEL.Entities;

namespace TestBackend.API.Controllers
{
    [Route("api/[controller]")]
   
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public HotelsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        //[Authorize]
        public async Task<ActionResult<List<Hotel>>> Get()
        {
            return await _mediator.Send(new GetHotel.HotelsList());
        }

        [HttpGet("{id}")]
        //[Authorize]
        public async Task<ActionResult<Hotel>> Detail(int id)
        {
            return await _mediator.Send(new GetHotelById.UniqueHotel { hotelId = id });
        }

        [HttpPost]
        //[Authorize]
        public async Task<ActionResult<Unit>> Create(PostHotel.ExecuteHotel data)
        {
            return await _mediator.Send(data);
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<ActionResult<Unit>> Edit(int id, PutHotel.EditHotel data)
        {
            data.hotelId = id;
            return await _mediator.Send(data);
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<ActionResult<Unit>> Delete(int id)
        {
            return await _mediator.Send(new DelHotel.DeleteHotel { hotelId = id });
        }
    }
}
