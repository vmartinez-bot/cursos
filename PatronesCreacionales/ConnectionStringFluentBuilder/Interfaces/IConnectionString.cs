using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionStringBuilder
{
   public interface IConnectionString
    {
        public string GetString();

        public void AddConnectionPart(string _part);

        public ConnectionType GetConnectionType();
    }
}
