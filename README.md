# C# - language
.Net - framework

## CLR - it's a Common language runtime
  It's when you write code in C# - computer needs to work off of the native language like the 0s and 1s. it uses IL (Intermediate Language) to convert the c# to somethign in the middle that translates to the native language. this intermediate to native is called JIT (Just in time compilation).

## .Net Architecture
  - .net apps are made up of classes. classes include data and method (functions).
  - Namespace is a group of related classes.
  - Assembly is a container of related namespaces - DLL or EXE
  - Application is made up of one or more Assembly

## .Net Setup
 - .Net is tricky to setup on mac with visual studio code.
 - Downloaded a bunch of extensions including C#, C# dev env, .Net 8 SDK Arm64
 - to setup a .Net project make a folder with the "Namespace" you want for the project.
 - open the folder on terminal and add the below code for using a console app template
  ### Command line: dotnet new console --framework net8.0 --use-program-main
  ### Command Line: dotnet run

 ## Explicit conversion for c#
 - if you have a string s = "1"; and want to convert that to an integer (int) then you have to convert it with the explicit conversion method
 - for example: int i = Convert.ToInt32(s); or you can use 
 int i = int.Parse(s)

 ## Three types of array in C#
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

## Array vs List
  - An array for when we know the numbers of items/objects we will store - cannot be changed after creating them.
  - A List is when we don't know how many items/objects we will store
    var numbers = new List<int>() {1, 2, 3, 4, 5};
  - methods for the list - Add(), AddRange(), Remove(), RemoveAll(), IndexOf(), Contains(), Count.

## File, FileInfo
- FileInfo: provides instance methods
- File: provides static methods

## Directory, DirectoryInfo
- Directory: provides static methods
- DirectoryInfo: provides instance methods

## Creating a new project
create a new folder and add the below in terminal: 
dotnet new console --framework net8.0 --use-program-main

## Shortcuts
cw - Console.WriteLine()

# C# Intermediate Course

## Classes
- Made up of data (represented by fields) and Behaviour (represented by method or functions)
- Objects are instances of a class
- Constructors
  - assigns variables at class initiation
- Object initializers
  - avoid multiple constructors when you have multiple parameters
  - assign values to the object when they are intialized
- Method
  - signature of methods, method overloading, params method
- 3 pillars of OOP
  - encapsulation/Information hiding - think of a restaurant - made up of chef, waitor, server etc. each member has specific role and responsible for their function. chef, waitor, server are classes.
  - Inheritance and Composition
    - Inheritance can be thought as (Is-a) - tight coupling
    - Composition can be through as (Has-a) - flexible/loose coupling
  - Polymorphism
  - Access modifiers
    - public - methods implemented with public can be accessible from anywhere
    - private - these methods are only accessible in that class
    - protected - these methods are only from the class and its derived classes
    - internal - these classes are only accessible in the same domain/assembly/class library
    - protected internal - accessible from the same assembly or any derived classes (not used very often)
  - Boxing and Unboxing
    - Value types (string, int, bool) and Reference types(object, class, DbMigrator)
    - these two have a performance penalty to create a new object
  - Method overriding
    - modifying the implementation of an inherited method
    - can use virtual on the default implementation and override in the use class for custom implementation
  - Abstract Classes & members
    - abstract modifier - indicates that a class or member is missing implementation
  - Interface
    - similar to class but fundamentally different
    - declare interface with I in the beginning "public interface ITaxCalculator"
    - they are used to build loosely coupled applications
    - A class cannot derive from an Inheritance it can implement an interface
    - interface is a contract to say this is the methods included in classes that implement the Inheritance
  - 

