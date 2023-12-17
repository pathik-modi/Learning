namespace CoursePract;

class Program
{
    static void Main(string[] args)
    {
      try
      {
     var number = "1234";
     byte b = Convert.ToByte(number);
     System.Console.WriteLine(b);   
      }
      catch (System.Exception)
      {
        System.Console.WriteLine("The number couldn t be converted to a byte");
      }
     
    }
}
