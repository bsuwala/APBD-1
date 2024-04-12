namespace ConsoleApp1;

public class zad3
{
    public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Tablica nie może byćaaaaaaaaaaaaaaa pusta lub null");
            }

            return numbers.Average();
        }
    }

