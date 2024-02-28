namespace Methods;

class Program
{
  static void Main(string[] args)
  {
    private string _birthdate;

  public string Birthdate
  {
    get { return _birthdate; }
    set { _birthdate = value; }
  }
}

static void UseParams()
{
  var calculator = new Calculator();
  System.Console.WriteLine(calculator.Add(1, 2));
  System.Console.WriteLine(calculator.Add(1, 2, 3));
}

static void UsePoints()
{
  try
  {
    var point = new Point(10, 20);
    point.Move(null);
    System.Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

    point.Move(100, 200);
    System.Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
  }
  catch (System.Exception)
  {
    System.Console.WriteLine("An unexpected error occured");
  }
}
}
