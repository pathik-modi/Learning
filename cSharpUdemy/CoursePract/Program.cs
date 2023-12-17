namespace CoursePract;

class Program
{
    static void Main(string[] args)
    {
      try
      {
    var str = "true";
     bool b = Convert.ToBoolean(str);
     System.Console.WriteLine(b);   
      }
      catch (System.Exception)
      {
        System.Console.WriteLine("The number couldn t be converted to a byte");
      }
     
    }
}
