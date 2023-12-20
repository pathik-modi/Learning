namespace ControlFlowExercise;

class Program
{
    static void Main(string[] args)
    {
        // // 1. count how many numbers between 1 and 100 divisible by 3 and have now remainder.
        // int count = 0;
        // for (int i = 1; i < 100; i++) {
        //   if (i % 3 == 0) {
        //     count++;
        //   }
        // }
        // System.Console.WriteLine(count);

        // // 2. user can press a number or ok - if number add to count - when pressed "ok" display the count
        // int count2 = 0;
        // int input2;
        // System.Console.WriteLine("Input a number or 'ok' to exit");
        
        // while (int.TryParse(Console.ReadLine(), out input2)) {
        //   count2 = input2 + count2;
        //   System.Console.WriteLine($"-Count: {count2}-");
        //   System.Console.WriteLine("Input a number or 'ok' to exit");
        // }

        // 3. enter a numberm compute the factorial of the number and print on console.
        System.Console.WriteLine("Enter a number below to compute factoral");
        var input3 = Convert.ToInt32(Console.ReadLine());
        int factoral = 1;
        for (int i = input3; i > 0; i--) {
          factoral = factoral * i;
        }
        System.Console.WriteLine($"{input3}! = {factoral}");
    }
}
