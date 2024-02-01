using Microsoft.EntityFrameworkCore;

using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class UserService : SqlManager<User>
    {
        public UserService(ApplicationDbContext context) : base(context)
        {

        }

        public async Task UpdateUser(User user) => await Update(user);

        public async Task DeleteUser(int id) => await Delete(id);
        
        public async Task<User> GetUser(int id) => await Get(id);
        
        public async Task<IEnumerable<User>> GetUsers() => await GetAll();
    }
}