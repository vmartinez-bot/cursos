using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionStringBuilder.Fluent.Interfaces
{
   public interface IConnectionStringBuilderFluent: IConnectionStringBuildServer
    {
     public   void Reset();
    }
}
