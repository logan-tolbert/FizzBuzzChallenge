internal class Program
{
    public static void Main(string[] args)
    {
        FizzBuzz(2);
        FizzBuzz(3);
        FizzBuzz(5);
        FizzBuzz(15);

    }
    public static void FizzBuzz(int num)
    {
        if (num % 15 == 0)
        {
            Console.WriteLine("Fizzbuzz");
        }
        else if (num % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else if (num % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else
        {
            Console.WriteLine(num);
        }
    }
}

