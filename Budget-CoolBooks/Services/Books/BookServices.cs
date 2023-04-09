using Budget_CoolBooks.Data;
using Budget_CoolBooks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.Security.Cryptography;

namespace Budget_CoolBooks.Services.Books
{
    public class BookServices
    {
        private readonly ApplicationDbContext _context;

        public BookServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateBook(Book book, string userId, int authorId, int genreId)
        {
            var user = await _context.Users.FindAsync(userId); // This must be the admin who is responsible for creating book.
            if (user == null)
            {
                return false;
            }
            var author = await _context.Authors.FindAsync(authorId);
            if (author == null)
            {
                return false;
            }
            var genre = await _context.Genres.FindAsync(genreId);
            if (genre == null)
            {
                return false;
            }

            book.user = user;
            book.Author = author;
            book.Genre = genre;

            _context.Books.Add(book);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
