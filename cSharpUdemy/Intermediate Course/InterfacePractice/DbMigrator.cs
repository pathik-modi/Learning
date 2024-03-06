using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfacePractice
{
  public class DbMigrator
  {
    public readonly ILogger _logger;
    public DbMigrator(ILogger logger)
    {
      _logger = logger;
    }
    public void Migrate()
    {
      _logger.LogInfo("Migration started at {0}" + DateTime.Now);
      // Details of the migrating the database
      _logger.LogInfo("Migration finished at {0}" + DateTime.Now);
    }
  }
}