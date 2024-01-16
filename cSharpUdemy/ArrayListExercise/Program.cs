namespace ArrayListExercise;

class Program
{
    static void Main(string[] args)
    {
        // // 1 - post counter
        // var likesList = new List<string>();
        
        // System.Console.WriteLine("Enter a name:");
        // var addName = Console.ReadLine();
        //   // while loop to keep adding names until an empty "" string
        // while (addName != "") {
        //   likesList.Add(addName);
        //   addName = Console.ReadLine();

        //   if (addName == "") {
        //     if (likesList.Count == 1) {
        //       System.Console.WriteLine($"{likesList[0]} likes your post");
        //     }
        //     if (likesList.Count == 2) {
        //       System.Console.WriteLine($"{likesList[0]} & {likesList[1]} like your post");
        //     }
        //     if (likesList.Count > 2) {
        //       System.Console.WriteLine($"{likesList[0]}, {likesList[1]} and {likesList.Count - 2} others liked your post");  
        //     } 
        //   }
        //   }
        // if (likesList.Count == 0) {
        //   System.Console.WriteLine("No one liked your post");
        // }

        // // 2 - take user input for name and display reverse of that name
        // System.Console.WriteLine("Enter your name below:");
        // string user = Console.ReadLine();
        // char[] userArray = new char[user.Length];
        // for (var i = 0; i < user.Length; i++) {
        //   userArray[i] = user[i];
        // }
        // Array.Reverse(userArray); // reversed the newly created array
        // string newUserName = new string(userArray); // converting to string
        // System.Console.WriteLine($"Reversed name is: {newUserName}");

        // // 3 - enter 5 numbers. if numbers are same then display error. sort the numbers and display on console.
        // int[] numbers = new int[5];
        // System.Console.WriteLine("Enter 5 unique numbers below");

        // for (var i = 0; i < numbers.Length; i++) {
        //   int userInput = Convert.ToInt32(Console.ReadLine());
        //   // looping through the numbers array and checking if any number matches the userInput
        //   foreach (int item in numbers){
        //     while (userInput == item) {
        //       System.Console.WriteLine("Try again");
        //       userInput = Convert.ToInt32(Console.ReadLine());  
        //     }
        //   }
        //   numbers[i] = userInput; // adding the user input tot he array if unique
        // }
        // Array.Sort(numbers);
        // System.Console.WriteLine("Sorted in ascending order below:");
        // foreach (var item in numbers){
        //   System.Console.WriteLine(item);  
        // }

        // 4 - list of numbers by user input - only display unique numbers
        var numbersList = new List<int>();
        System.Console.WriteLine("Enter numbers below & type Quit to exit");
        var userInput2 = Console.ReadLine();
        
        while (userInput2 != "Quit") {
          numbersList.Add(Convert.ToInt32(userInput2));
          userInput2 = Console.ReadLine();
        }
        
        System.Console.WriteLine("Here's the list of unique numbers");
        var uniqueList = new List<int>();
        uniqueList = numbersList.Distinct().ToList(); // .Distinct() method returns only the unique values & .ToList() method converts the numbers back to a list

        foreach (int item2 in uniqueList)
        {
          System.Console.WriteLine(item2);
        }

    }
}
