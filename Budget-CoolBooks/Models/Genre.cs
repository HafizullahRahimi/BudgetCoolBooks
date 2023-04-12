using Microsoft.AspNetCore.Http.HttpResults;

namespace Budget_CoolBooks.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }

        //Nested
        public ICollection<Book> Books { get; set; }

        public Genre(string name, DateTime created)
        {
            Name = name;
            Created = created;
        }
    }
}
