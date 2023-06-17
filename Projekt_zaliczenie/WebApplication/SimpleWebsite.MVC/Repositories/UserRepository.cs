using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleWebsite.MVC.Data;
using SimpleWebsite.MVC.Models;

namespace SimpleWebsite.MVC.Repositories
{
    public class UserRepository
    {
        private readonly SimpleWebsiteMVCContext _context;

        public UserRepository(SimpleWebsiteMVCContext context)
        {
            _context = context;
        }

        public async Task<bool> UserExists(string username)
        {
            return await _context.Users.AnyAsync(u => u.Username == username);
        }

        public async Task AddUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> GetUserByUsername(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }
    }
}