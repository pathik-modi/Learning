namespace ConditionalExercise;

class Program
{
    static void Main(string[] args)
    {
      // Exc 1. Take user input for a number and check if its between 1 & 10
        Console.WriteLine("1. Enter a number");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0 && number < 11) {
          System.Console.WriteLine("Result: Valid");
        }
        else {
          System.Console.WriteLine("Result: Invalid");
        }

        // Exc 2. enter two numbers and display the higer number
        System.Console.WriteLine("\n2. Compare two numbers here\nEnter first number below:");
        int number1 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter second number below:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine((number1 > number2) ? $"Result: {number1} is higher." : $"Result: {number2} is higher.");
    }
}
