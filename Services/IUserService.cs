using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLibrary;

namespace Services
{
    public interface IUserService
    {
        Task CreateUserAsync(string name, string email, string phoneNumber);
        Task<Guid> GetUserIdByPhoneNumberAsync(string phoneNumber);
        Task<bool> CheckUserTask(string phoneNumber);
    }
}
