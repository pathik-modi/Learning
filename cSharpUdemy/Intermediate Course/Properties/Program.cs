namespace Properties;

class Program
{
  static void Main(string[] args)
  {
    var person = new Person(new DateTime(1995, 7, 6));
    System.Console.WriteLine(person.Age);
  }
}
