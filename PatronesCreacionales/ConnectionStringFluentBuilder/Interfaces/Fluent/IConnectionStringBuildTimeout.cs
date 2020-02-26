using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionStringBuilder.Fluent.Interfaces
{
    interface IConnectionStringBuildTimeout
    {
        IConnectionString BuildTimeout(int _timeout);
    }
}
