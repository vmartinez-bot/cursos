using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionStringBuilder.Fluent.Interfaces
{
    public  interface IConnectionStringBuildServer
    {
       public IConnectionStringBuildDatabase BuildServer(string _server);
    }
}
