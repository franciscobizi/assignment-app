using System;
using System.Collections.Generic;

#nullable disable

namespace AssignmentDashboard.Shared.Models.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public List<UserLoginAttempt> userLoginAttempts { get; set; }
    }
}
