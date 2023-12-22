namespace ControlFlowExercise;

class Program
{
    static void Main(string[] args)
    {
        // 1. count how many numbers between 1 and 100 divisible by 3 and have now remainder.
        int count = 0;
        for (int i = 1; i < 100; i++) {
          if (i % 3 == 0) {
            count++;
          }
        }
        System.Console.WriteLine(count);

        // 2. user can press a number or ok - if number add to count - when pressed "ok" display the count
        int count2 = 0;
        int input2;
        System.Console.WriteLine("Input a number or 'ok' to exit");
        
        while (int.TryParse(Console.ReadLine(), out input2)) {
          count2 = input2 + count2;
          System.Console.WriteLine($"-Count: {count2}-");
          System.Console.WriteLine("Input a number or 'ok' to exit");
        }

        // 3. enter a numberm compute the factorial of the number and print on console.
        System.Console.WriteLine("Enter a number below to compute factoral");
        var input3 = Convert.ToInt32(Console.ReadLine());
        int factoral = 1;
        for (int i = input3; i > 0; i--) {
          factoral = factoral * i;
        }
        System.Console.WriteLine($"{input3}! = {factoral}");

        // 4. Randomly assign a number between 1 to 10 and let user guess - if match then display you won
        var randomNumber = new Random().Next(1,10);
        System.Console.WriteLine("Guess a number between 1 and 10 (try: 1 of 4)");
        var userGuess = Convert.ToInt32(Console.ReadLine());

            for (var i = 2; i < 6; i++) {
              if (randomNumber == userGuess) {
                System.Console.WriteLine("You Won");
                break;
              }
              if (i == 5) {
                System.Console.WriteLine("Too many tries. Game Over!");
              }
              if (randomNumber != userGuess && i < 5) {
                  System.Console.WriteLine($"Wrong guess. Try again (try: {i} of 4)");
                  userGuess = Convert.ToInt32(Console.ReadLine());
              }
        }

        // 5. get user to enter series of number seperated by a comma. display the highest number
        System.Console.WriteLine("Enter a series of numbers seperated by a comma.");
        // receives input in a string array
        var input5 = Console.ReadLine();
        string[] inputArr = input5.Split(',');
        var arrayLength = inputArr.Length;
        // converts string array to int array
        int[] intArray = new int[arrayLength];
        for (var i = 0; i < arrayLength; i++) {
          intArray[i] = Convert.ToInt32(inputArr[i]);
        }
        // records highest value in the array
        int maxValue = intArray.Max();
        System.Console.WriteLine($"Highest Number is: {maxValue}");
    }
}
