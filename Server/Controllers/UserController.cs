using AssignmentDashboard.Server.CommandHandlers.Users;
using AssignmentDashboard.Server.Models.Users;
using AssignmentDashboard.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentDashboard.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;
        private readonly IMediator _mediator;

        public UserController(ILogger<UserController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost]
        [Route("seed")]
        public async Task<List<User>> SeedUsers([FromBody] User model)
        {
            return await _mediator.Send(new CreateUsersCommand());
        } 
        
    }
}
