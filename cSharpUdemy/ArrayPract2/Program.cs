namespace ArrayPract2;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new[] {3, 7, 9, 2, 14, 6};

        // Length
        System.Console.WriteLine($"Length: {numbers.Length}");
        
        // Array.IndexOf
        var index = Array.IndexOf(numbers, 14);
        System.Console.WriteLine($"Index of 14: {index}");

        // Array.Clear()
        Array.Clear(numbers, 0, 2);
        System.Console.WriteLine("Effect of Clear()");
        
        foreach (var item in numbers)
        {
          System.Console.WriteLine(item);
        }

        // Array.Copy()
        int [] another = new int[3];
        Array.Copy(numbers, another, 3);
        System.Console.WriteLine("Effect of Copy()");
        foreach (var n in another)
        {
          System.Console.WriteLine(n);
        }

        // Array.Sort()
        Array.Sort(numbers);
        System.Console.WriteLine("Effect of Array.Sort()");
        foreach (var i in numbers)
        {
          System.Console.WriteLine(i);
        }

        // Array.Reverse()
        Array.Reverse(numbers);
        System.Console.WriteLine("Effect of Array.Reverse()");
        foreach (var i in numbers)
        {
          System.Console.WriteLine(i);
        }
    }
}
