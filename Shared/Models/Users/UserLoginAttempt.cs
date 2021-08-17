using System;
using System.Collections.Generic;

#nullable disable

namespace AssignmentDashboard.Shared.Models.Users
{
    public partial class UserLoginAttempt
    {
        public Guid Id { get; set; }
        public DateTime AttemptTime { get; set; }
        public bool IsSuccess { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
