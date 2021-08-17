using System;
using System.Collections.Generic;

#nullable disable

namespace AssignmentDashboard.Shared.Dto.UsersDto
{
    public class UserLoginAttemptDto
    {
        public Guid Id { get; set; }
        public DateTime AttemptTime { get; set; }
        public bool IsSuccess { get; set; }
        public Guid UserId { get; set; }
        public UserDto UserDto { get; set; }
    }
}
