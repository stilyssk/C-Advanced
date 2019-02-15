
namespace IteratorsAndComparators
{
    using System.Collections.Generic;
    public class Book
    {
        public Book(string title, int years, params string[] authors)
        {
            this.Title = title;
            this.Year = years;
            this.Authors = authors;
        }
        public IReadOnlyList<string> Authors { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

    }
}
