namespace PolymorphismExercise;

class Program
{
  static void Main(string[] args)
  {
    // if selected sql then do the following

    var sql = new DbCommand(new SqlConnection("SQLConnectionString"), "SQLdbInstruction");
    sql.Execute();

    var oracle = new DbCommand(new OracleConnection("OracleConnectionString"), "OracledbInstruction");
    oracle.Execute();
  }
}
