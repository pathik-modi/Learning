

namespace ConditionalStatements;

class Program
{
    static void Main(string[] args)
    {
      var season = Season2.Autumn;

      switch (season)
      {
        case Season2.Autumn: 
        case Season2.Summer:
          System.Console.WriteLine("We've got a promotion.");
          break;
        
        default:
          System.Console.WriteLine("I dont understand that season.");
          break;
      }
    }
}
