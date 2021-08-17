using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssignmentDashboard.Server.Models.Users;
using AssignmentDashboard.Server.Services.Interfaces;

namespace AssignmentDashboard.Server.Services.Users
{
    public class UserServices : IUserSevices
    {

        private readonly AssignmentsContext _context;
        private const string UserName = "user_";

        public UserServices(AssignmentsContext context)
        {
            _context = context;
        }
        public async Task<User> GetUserByEmailAsync(string email)
        {
            var user = _context.Users.Where(u => u.Email == email).FirstOrDefault();
            return await Task.FromResult(user);
        }

        public async Task<List<User>> GetUsersAsync(string param)
        {
            var users = _context.Users.ToList();
            return await Task.FromResult(users);
        }

        public async Task<List<User>> SeedUsersAsync()
        {
            _context.Users.RemoveRange(_context.Users.ToList());
            _context.SaveChanges();
            for (int i = 0; i < 10; i++)
            {
                var userId = Guid.NewGuid(); 
                var user = new User
                {
                    Id = userId,
                    Email = $"{UserName}{i}@test.com",
                    Name = UserName + i,
                    Surname = $"surname{i}",
                    userLoginAttempts = new List<UserLoginAttempt>
                    {
                        new UserLoginAttempt {Id = Guid.NewGuid(), AttemptTime = DateTime.Now, IsSuccess = true, UserId = userId },
                    }
                };

                _context.Users.Add(user);
                _context.SaveChanges();
            }

            var users = _context.Users.ToList();
            return await Task.FromResult(users);
        }
    }
}
