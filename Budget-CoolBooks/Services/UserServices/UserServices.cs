using Budget_CoolBooks.Data;
using Budget_CoolBooks.Models;
using System.Security.Claims;

namespace Budget_CoolBooks.Services.UserServices
{
    public class UserServices
    {
        private readonly ApplicationDbContext _context;

        public UserServices(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
        }


    }
}
