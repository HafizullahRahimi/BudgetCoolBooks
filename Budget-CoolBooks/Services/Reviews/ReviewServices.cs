using Budget_CoolBooks.Data;
using Budget_CoolBooks.Models;

namespace Budget_CoolBooks.Services.Reviews
{
    public class ReviewServices
    {
        private readonly ApplicationDbContext _context;

        public ReviewServices(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<List<Review>> GetReviewByUsername(string userName) 
        {
            return _context.Reviews.
                OrderBy(r => r.User.UserName).
                Where(r => r.User.UserName == userName).
                ToList();
        }

        
    }
}
