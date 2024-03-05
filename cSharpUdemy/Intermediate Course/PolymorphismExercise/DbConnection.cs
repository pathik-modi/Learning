using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
  public abstract class DbConnection
  {
    public string ConnectionString { get; set; }
    // public TimeSpan Timeout { get; set; }
    public bool IsConnected;
    public DbConnection(string connectionString)
    {
      if (string.IsNullOrWhiteSpace(connectionString))
        throw new InvalidOperationException("Cannot send empty connection string");

      ConnectionString = connectionString;
    }
    public abstract void OpenConnection();
    public abstract void CloseConnection();
  }
}