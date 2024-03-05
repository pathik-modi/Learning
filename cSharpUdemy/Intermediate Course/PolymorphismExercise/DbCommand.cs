using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
  public class DbCommand
  {
    private readonly DbConnection _dbConnection;
    private readonly string _dbInstruction;
    public DbCommand(DbConnection dbConnection, string dbInstruction)
    {
      // add check if dbconnection is null or if dbinstruction is null
      _dbConnection = dbConnection;
      _dbInstruction = dbInstruction;
    }
    public void Execute()
    {
      _dbConnection.OpenConnection();
      System.Console.WriteLine($"Executing the instruction: {_dbInstruction}");
      _dbConnection.CloseConnection();
    }
  }
}