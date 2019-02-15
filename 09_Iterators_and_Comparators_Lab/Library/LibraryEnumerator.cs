

namespace IteratorsAndComparators
{
    using System.Collections;
    using System.Collections.Generic;

    class LibraryEnumerator : IEnumerator<Book>
    {
        private List<Book> books { get; set; }
        private int index = -1;
        public LibraryEnumerator(List<Book> books)
        {
            this.books = books;
        }
        public Book Current
        {
            get
            {
                return this.books[this.index];
            }
        }

        object IEnumerator.Current { get; }

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
            throw new System.NotImplementedException();
        }
    }
}
