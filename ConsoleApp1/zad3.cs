namespace ConsoleApp1;

public class zad3
{
    public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("........aaa...");
            }

            return numbers.Average();
        }
    }

