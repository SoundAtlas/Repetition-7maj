namespace Repetition_7_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 13;
            int b = 4;
            double c = 13;

            Console.WriteLine(a / b);
            Console.WriteLine(c / b);
            Console.WriteLine(a % b);

            string text = "C#";
            int year = 2026;

            Console.WriteLine($"Vi lærer {text} i {year}!");

            bool isReady = a > 10 && b < 5;
            bool isMaybe = a < 10 || b == 4;

            Console.WriteLine($"{isReady}, {isMaybe}");
        }
    }
}
