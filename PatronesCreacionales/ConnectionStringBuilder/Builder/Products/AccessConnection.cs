using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionStringBuilder
{
    class AccessConnection : IConnectionString
    {
        private ConnectionType connectionType;
        private string connectionString;
        private string separator;

        public AccessConnection()
        {
            connectionType = ConnectionType.ACCESS;
            separator = ";";
            connectionString = "";

        }
        public void AddConnectionPart(string _part)
        {
            connectionString = connectionString + _part + separator;
        }

        public string GetString()
        {
            return connectionString;
        }

        public ConnectionType GetConnectionType()
        {
            return connectionType;
        }
    }
}