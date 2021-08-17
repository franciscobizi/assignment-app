using System;
using System.Collections.Generic;

#nullable disable

namespace AssignmentDashboard.Shared.Dto.UsersDto
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public List<UserLoginAttemptDto> userLoginAttempts { get; set; }
    }
}
