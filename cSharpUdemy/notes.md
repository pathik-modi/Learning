# C# - language
.Net - framework

# CLR - it's a Common language runtime
  Its when you write code in C# - computer needs to work off of the native language like the 0s and 1s. it uses IL (Intermediate Language) to convert the c# to somethign in the middle that translates to the native language. this intermediate to native is called JIT (Just in time compilation).

# .Net Arcitecture
  - .net apps are made up of classes. classes include data and method (functions).
  - Namespace is a group of related classes.
  - Assembly is a container of related namespaces - DLL or EXE
  - Application is made up of one or more Assembly

# .Net Setup
 - .Net is tricky to setup on mac with visual studio code.
 - Downloaded a bunch of extensions including C#, C# dev env, .Net 8 SDK Arm64
 - to setup a .Net project make a folder with the "Namespace" you want for the project.
 - open the folder on terminal and add the below code for using a console app template
 command line:  dotnet new console --framework net8.0 --use-program-main

 # Explicit conversion for c#
 - if you have a string s = "1"; and want to convert that to an integer (int) then you ahve to convert it with the explicit conversion method
 - for example: int i = Convert.ToInt32(s); or you can use 
 int i = int.Parse(s)