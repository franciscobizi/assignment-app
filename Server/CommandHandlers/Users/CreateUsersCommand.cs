using AssignmentDashboard.Server.Models.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AssignmentDashboard.Server.Services.Interfaces;

namespace AssignmentDashboard.Server.CommandHandlers.Users
{
    public class CreateUsersCommand : IRequest<List<User>>
    {
        /*public User Model { get; set; }*/
    }

    public class CreateUsersCommandHandler : IRequestHandler<CreateUsersCommand, List<User>>
    {
        private readonly IUserSevices _userSevices;

        public CreateUsersCommandHandler(IUserSevices userSevices)
        {
            _userSevices = userSevices;
        }


        public async Task<List<User>> Handle(CreateUsersCommand request, CancellationToken cancellationToken)
        {
            return await _userSevices.SeedUsersAsync();
        }
    }
}
