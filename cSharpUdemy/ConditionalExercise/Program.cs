﻿namespace ConditionalExercise;

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

        System.Console.WriteLine((number1 > number2) ? $"Result: {number1} is higher.\n" : $"Result: {number2} is higher.\n");

        // Exc 3. get user to write width and weight of an image and check which is higher to display if image is portrait or landscape
        System.Console.WriteLine("3. Here we will check if image is portrait or landscape\nEnter image width:");
        int width = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter image height:");
        int height = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine((width > height) ? $"Result: Image is landscape.\n" : $"Result: Image is portrait.\n");

        // Exc 4: speed limit challellenge
        System.Console.WriteLine("3. Here we will work out the speed limit challenge\nEnter speed limit (km/hr):");
        int speedLimit = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter speed of the car (km/hr):");
        int carSpeed = Convert.ToInt32(Console.ReadLine());

        if (carSpeed <= speedLimit) {
          System.Console.WriteLine("Ok");
        }
        else if (carSpeed - speedLimit > 12) {
          System.Console.WriteLine($"You were overspeeding by {carSpeed - speedLimit} km/hr\nLicense Suspended");
        }
        else if (carSpeed - speedLimit > 5) {
          System.Console.WriteLine($"You were overspeeding by {carSpeed - speedLimit} km/hr\nDemerit Points: 2");
        }
        else if (carSpeed - speedLimit > 0) {
          System.Console.WriteLine($"You were overspeeding by {carSpeed - speedLimit} km/hr\nDemerit Points: 1");
        }
    }
}
