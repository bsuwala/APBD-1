namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = { 1, 2, 3, 4, 5 };
                double average = zad3.CalculateAverage(numbers);
                Console.WriteLine("Średnia wynosi: " + average);
                
                int max = zad4.FindMax(numbers);
                Console.WriteLine("Maksymalna wartość to: " + max);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
