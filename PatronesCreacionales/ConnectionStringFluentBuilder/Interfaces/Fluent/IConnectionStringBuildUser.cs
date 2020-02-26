using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionStringBuilder.Fluent.Interfaces
{
   public interface IConnectionStringBuildUser
    {
        public IConnectionStringBuildPassword BuildUserID(string _user);
    }
}
