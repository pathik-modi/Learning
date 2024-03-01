namespace Inheritance;
// this one is actually an example of composition
public class Logger
{
  public void Log(string message)
  {
    System.Console.WriteLine(message);
  }
}

public class DbMigrator
{
  private readonly Logger _logger;
  public DbMigrator(Logger logger)
  {
    _logger = logger;
  }
  public void Migrate()
  {
    _logger.Log("We are migrating bla bla");
  }
}

public class Installer
{
  private readonly Logger _logger;
  public Installer(Logger logger)
  {
    _logger = logger;
  }
  public void Install()
  {
    _logger.Log("We are installing the application");
  }
}

class Program
{
  static void Main(string[] args)
  {
    var dbMigrator = new DbMigrator(new Logger());

    var logger = new Logger();
    var installer = new Installer(logger);

    dbMigrator.Migrate();
    installer.Install();
  }
}
