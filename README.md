# C# - language
.Net - framework

# CLR - it's a Common language runtime
  It's when you write code in C# - computer needs to work off of the native language like the 0s and 1s. it uses IL (Intermediate Language) to convert the c# to somethign in the middle that translates to the native language. this intermediate to native is called JIT (Just in time compilation).

# .Net Architecture
  - .net apps are made up of classes. classes include data and method (functions).
  - Namespace is a group of related classes.
  - Assembly is a container of related namespaces - DLL or EXE
  - Application is made up of one or more Assembly

# .Net Setup
 - .Net is tricky to setup on mac with visual studio code.
 - Downloaded a bunch of extensions including C#, C# dev env, .Net 8 SDK Arm64
 - to setup a .Net project make a folder with the "Namespace" you want for the project.
 - open the folder on terminal and add the below code for using a console app template
  ### Command line: dotnet new console --framework net8.0 --use-program-main
  ### Command Line: dotnet run

 # Explicit conversion for c#
 - if you have a string s = "1"; and want to convert that to an integer (int) then you have to convert it with the explicit conversion method
 - for example: int i = Convert.ToInt32(s); or you can use 
 int i = int.Parse(s)

 # Three types of array in C#
 - Single dimension array - eg. var numbers = new int[5] {1, 2, 3, 4, 5};
 - Rectangular array - 
    eg. var matrix = new int[3,4] {
      {1, 2, 3, 4},
      {5, 6, 7, 8},
      {9, 10, 11, 12}
    };
    access any number in the array by - var element = matrix[0,1] = 2 (answer)
 
 - Jagged Array - this is when each of the individual array has different number of values - see example below
    var array = new int[3][];
    array[0] = new int[4] {1, 2, 3, 4};
    array[1] = new int[5] {1, 2, 3, 4, 5};
    array[2] = new int[3] {1, 2, 3};
    access them by - array[1][2] = 3

# Array vs List
  - An array for when we know the numbers of items/objects we will store - cannot be changed after creating them.
  - A List is when we don't know how many items/objects we will store
    var numbers = new List<int>() {1, 2, 3, 4, 5};
  - methods for the list - Add(), AddRange(), Remove(), RemoveAll(), IndexOf(), Contains(), Count.

# Procedural Programming
    - 

# Creating a new project
create a new folder and add the below in terminal: 
dotnet new console --framework net8.0 --use-program-main

# Shortcuts
cw - Console.WriteLine()

