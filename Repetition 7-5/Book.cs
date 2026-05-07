namespace Repetition_7_5
{
    public class Book
    {


        public string Title { get; private set; }
        public string Author { get; private set; }
        public int Year { get; private set; }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public string GetCitation()
        {
            return $"{Author} ({Year}): {Title}";
        }

        public bool IsOlderThan(int year)
        {
            return Year < year;
        }
    }
}
