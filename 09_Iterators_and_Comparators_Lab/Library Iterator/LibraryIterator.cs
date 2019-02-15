

namespace IteratorsAndComparators
{
    using System.Collections;
    using System.Collections.Generic;
    public class LibraryIterator : IEnumerator<Book>
    {
        private readonly List<Book> books;
        private int index;
        public LibraryIterator(List<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }
        public Book Current
        {
            get
            {
                return this.books[this.index];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return this.Current;
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            this.index++;
            if (this.index < this.books.Count)
            {
                return true;
            }
            return false;
        }

        public void Reset()
        {
            this.index = -1;
        }
    }
    //public class Library : IEnumerable<Book>
    //{

    //    private List<Book> books;

    //    public Library(params Book[] books)
    //    {
    //        this.books = new List<Book>(books);
    //    }

    //    public IEnumerator<Book> GetEnumerator()
    //    {
    //        return new LibraryIterator(books);
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return this.GetEnumerator();
    //    }
    //}
}
