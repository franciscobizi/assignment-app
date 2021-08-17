using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssignmentDashboard.Server.Models.Users;

namespace AssignmentDashboard.Server.Services.Interfaces
{
    public interface IUserSevices
    {
        Task<List<User>> GetUsersAsync(string param);
        Task<User> GetUserByEmailAsync(string email);
        Task<List<User>> SeedUsersAsync();
    }
}
