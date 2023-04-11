using Microsoft.AspNetCore.Http.HttpResults;

namespace Budget_CoolBooks.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }

        //Nested
        public Book Book { get; set; }

        public Genre(string name, string description, DateTime created)
        {
            Name = name;
            Description = description;
            Created = created;
        }
    }
}
