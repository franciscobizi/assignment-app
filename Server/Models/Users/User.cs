using System;
using System.Collections.Generic;

#nullable disable

namespace AssignmentDashboard.Server.Models.Users
{
    public partial class User
    {
        public User(){
            UserLoginAttempts = new HashSet<UserLoginAttempt>();
        }
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ListAttempt { get; set; }
        public virtual ICollection<UserLoginAttempt> UserLoginAttempts { get; set; }
    }
}
