using DbContextLibrary;
using Microsoft.EntityFrameworkCore;
using ModelsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> CheckUserTask(string phoneNumber)
        {
            string standardizedPhoneNumber = Regex.Replace(phoneNumber, @"[^\d]", "");
            standardizedPhoneNumber = "+7" + standardizedPhoneNumber.Substring(1);
            var user = await _context.User.FirstOrDefaultAsync(u => u.PhoneNumber == standardizedPhoneNumber);
            if (user == null)
            {
                return false;
            }
            return true;

        }
        public async Task<Guid> GetUserIdByPhoneNumberAsync(string phoneNumber)
        {
            string standardizedPhoneNumber = Regex.Replace(phoneNumber, @"[^\d]", "");
            standardizedPhoneNumber = "+7" + standardizedPhoneNumber.Substring(1);

            var user = await _context.User.FirstOrDefaultAsync(u => u.PhoneNumber == standardizedPhoneNumber);

            return user.Id;

        }

        public async Task CreateUserAsync(string name, string email, string phoneNumber)
        {


            string standardizedPhoneNumber = Regex.Replace(phoneNumber, @"[^\d]", "");
            standardizedPhoneNumber = "+7" + standardizedPhoneNumber.Substring(1);
                
            
            var newUser = new User
            {
                Id = Guid.NewGuid(),
                Name = name,
                Email = email,
                PhoneNumber = standardizedPhoneNumber
            };

            _context.User.Add(newUser);
            await _context.SaveChangesAsync();

        }
    }

}
