// See https://aka.ms/new-console-template for more information

// //Exercise 1 - user input to check if numbers are consecutive or not
// System.Console.WriteLine("Enter numbers seperated by hyphen");
// string input1 = Console.ReadLine();
// int[] input1Arr = input1.Split('-').Select(int.Parse).ToArray();
// bool result = true;
//
// for (int i = 0; i < input1Arr.Length - 1; i++)
// {
//     if (Math.Abs(input1Arr[i] - input1Arr[i + 1]) != 1) //Math.Abs method converts the difference to absolute positive numbers regardless if they are positive or negative
//     {
//         result = false;
//         break;
//     }
// }
//
// if (result)
// {
//     Console.WriteLine("Consecutive");
// }
// else
// {
//     Console.WriteLine("Not Consecutive");
// }
//
// // Exercise 2
// System.Console.WriteLine("Enter numbers seperated by hyphen");
// string input2 = Console.ReadLine();
// if (input2 == "")
// {
//     Environment.Exit(0); // exit the application if no input received
// }
// int[] input2Arr = input2.Split('-').Select(int.Parse).ToArray();
// Array.Sort(input2Arr);
//
// for (int i = 0; i < input2Arr.Length; i++)
// {
//     if (input2Arr[i] - input2Arr[i + 1] == 0)
//     {
//         Console.WriteLine($"Duplicate Number: {input2Arr[i]}");
//         break;
//     }
// }

// Exercise 3
// System.Console.WriteLine("Enter a timein 24hr format eg.14:11");
// string input3 = Console.ReadLine();
// if (input3 == "")
// {
//     Console.WriteLine("Invalid Time");
//     Environment.Exit(0);
// }
// int[] input3Arr = input3.Split(':').Select(int.Parse).ToArray();
// bool isValid = true;
//
// if (input3Arr[0] > 23 || input3Arr[1] > 59 || input3Arr[0] < 0 || input3Arr[1] < 0)
// {
//     isValid = false;
// }
//
// if (isValid)
// {
//     Console.WriteLine("Valid time");
// }
// else
// {
//     Console.WriteLine("Invalid");
// }

// Exercise 4
System.Console.WriteLine("Enter a word to convert to PascalCase");
var input4 = Console.ReadLine();
if (input4 == "")
{
    Environment.Exit(0); // exit the application if no input received
}

string[] input4Arr = input4.Split(' ').ToArray();
var newList = new List<string>();
foreach (var word in input4Arr)
{
    newList.Add(word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower());
}

string toPascalCase = string.Join("", newList);
Console.WriteLine(toPascalCase);