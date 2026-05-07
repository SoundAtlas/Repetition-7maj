namespace Repetition_7_5
{
    public class Program
    {
        static void Main(string[] args)
        {








            Account a = new Account("Anna", 1000);
            try
            {
                a.Withdraw(2000);
            }

            catch (InsufficientFundsException e)
            {
                Console.WriteLine($"You attempted to withdraw {e.RequestedAmount:C2} but only have {a.Balance:C2} available");
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);


            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Specifikt: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }








            /*List<IDescribable> items = new List<IDescribable>();
            items.Add(new Car("Tesla", 250, 4));
            items.Add(new Motorcycle("Yamaha", 280));


            foreach (IDescribable item in items)
            {
                Console.WriteLine(item.Describe());
            }*/



            /*Dictionary<string, List<Book>> booksByAuthor = new Dictionary<string, List<Book>>
            {
                {
                    "J.R.R. Tolkien",
                    new List<Book>
                    {
                        new Book("The Hobbit", "J.R.R. Tolkien", 1937),
                        new Book("The Fellowship of the Ring", "J.R.R. Tolkien", 1954)
                    }
                },
                {
                    "H.P. Lovecraft",
                    new List<Book>
                    {
                        new Book("The Call of Cthulhu", "H.P. Lovecraft", 1928),
                        new Book("At the Mountains of Madness", "H.P. Lovecraft", 1936)
                    }
                }
            };

            foreach (KeyValuePair<string, List<Book>> entry in booksByAuthor)
            {
                Console.WriteLine($"Author: {entry.Key} ({entry.Value.Count} books)");
            }*/
        }


        static int CountPositive(int[] numbers)
        {
            int count = 0;

            foreach (int n in numbers)
            {
                if (n > 0)
                    count = count + 1;
            }

            return count;
        }

        static string BuildSummary(List<double> prices)
        {
            double totalPrice = 0;
            foreach (double price in prices)
            {
                totalPrice += price;
            }

            return $"{prices.Count} prices, Total: {totalPrice}, Average: {totalPrice / prices.Count:F2}";
        }
    }
}
