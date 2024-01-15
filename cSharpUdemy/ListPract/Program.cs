namespace ListPract;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>() {1, 2, 3, 4, 5};
        numbers.Add(1);
        numbers.AddRange(new int[3] {11, 12, 14});
        
        foreach (var item in numbers)
        {
          System.Console.WriteLine(item);
        }
        
        System.Console.WriteLine($"Index of 1: {numbers.IndexOf(1)}");
        System.Console.WriteLine($"Index of 1: {numbers.LastIndexOf(1)}"); // LastIndexOf() methd helps to get index of a number fromt he abck fo the list

        System.Console.WriteLine($"Count: {numbers.Count}");
        
        numbers.Remove(2);
        System.Console.WriteLine("Effect of removing 1");
        foreach (var item in numbers)
        {
          System.Console.WriteLine(item);
        }

        // removing by a condition
        for (var i = 0; i < numbers.Count; i++) {
          if (numbers[i] == 1) {
            numbers.Remove(numbers[i]);
          }
        }
        
        System.Console.WriteLine("Effect of removing upon condition");
        foreach (var item in numbers)
        {
          System.Console.WriteLine(item);
        }

        numbers.Clear();
        System.Console.WriteLine($"Count: {numbers.Count}");
    }
}
