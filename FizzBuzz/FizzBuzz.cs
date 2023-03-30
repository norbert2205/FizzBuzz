namespace FizzBuzz;

public class FizzBuzz
{
    public static void PrintNumbers(int count)
    {
        for (var i = 1; i <= count; i++)
        {
            Console.WriteLine(GetResult(i));
        }
    }

    public static string GetResult(int number)
    {
        return number % 15 == 0 ? "FizzBuzz"
                : number % 5 == 0 ? "Buzz"
                    : number % 3 == 0 ? "Fizz"
                        : number.ToString();
    }
}