namespace FizzBuzz;

public class FizzBuzz
{
    public static string GetResult(int number)
    {
        return number % 15 == 0 ? "FizzBuzz"
                : number % 5 == 0 ? "Buzz"
                    : number % 3 == 0 ? "Fizz"
                        : number.ToString();
    }
}