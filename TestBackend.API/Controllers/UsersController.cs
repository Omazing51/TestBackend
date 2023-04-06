using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestBackend.APP.Application.Services;
using TestBackend.APP.Application.Users;
using TestBackend.MODEL.Entities;

namespace TestBackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> Get()
        {
            return await _mediator.Send(new GetUser.UsersList());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Detail(int id)
        {
            return await _mediator.Send(new GetUserById.UniqueUser { Id = id });
        }


        [HttpPost]
        public async Task<ActionResult<Unit>> Create(UserPost.ExecuteU data)
        {
            return await _mediator.Send(data);
        }
    }
}
