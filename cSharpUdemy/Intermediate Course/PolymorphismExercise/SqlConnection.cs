using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
  public class SqlConnection : DbConnection
  {
    public SqlConnection(string connectionString) : base(connectionString)
    {
      Console.WriteLine("Now using SQL connection...");
    }
    public override void OpenConnection()
    {
      if (IsConnected)
      {
        throw new InvalidOperationException("Already connected");
      }
      else
      {
        System.Console.WriteLine($"Sql Connection open using {ConnectionString}");
        IsConnected = true;
      }
    }
    public override void CloseConnection()
    {
      if (!IsConnected)
      {
        throw new InvalidOperationException("Already disconnected");
      }
      else
      {
        System.Console.WriteLine("Sql Connection close");
        IsConnected = false;
      }
    }
  }
}