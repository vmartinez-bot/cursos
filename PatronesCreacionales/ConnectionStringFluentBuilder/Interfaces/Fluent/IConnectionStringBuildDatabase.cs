using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionStringBuilder.Fluent.Interfaces
{
   public interface IConnectionStringBuildDatabase
    {

      public IConnectionStringBuildTrusted BuildDatabase(string _database);
    }
}
