using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Division Calculator");

        Console.Write("Enter a number: ");
        string firstInput = Console.ReadLine();

        Console.Write("Enter another number: ");
        string secondInput = Console.ReadLine();

        PerformDivision(firstInput, secondInput);

        Console.WriteLine("\nProgram finished. Press any key to close.");
        Console.ReadKey();
    }

    static void PerformDivision(string a, string b)
    {
        try
        {
            int num1 = int.Parse(a);
            int num2 = int.Parse(b);

            int answer = num1 / num2;

            Console.WriteLine($"Result: {num1} / {num2} = {answer}");
        }
        catch (FormatException)
        {
            Console.WriteLine("You must enter valid whole numbers only.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("You cannot divide a number by zero.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Something unexpected happened.");
            Console.WriteLine("Details: " + e.Message);
        }
    }
}
