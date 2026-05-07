namespace Repetition_7_5
{
    public class Bookshelf
    {
        public List<Book> Books { get; private set; }

        public Bookshelf()
        {
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public Book FindByAuthor(string author)
        {
            foreach (Book b in Books)
            {
                if (b.Author == author)
                    return b;
            }

            return null;
        }
    }
}
