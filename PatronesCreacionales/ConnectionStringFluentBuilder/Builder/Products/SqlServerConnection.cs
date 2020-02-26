using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionStringBuilder
{
   public class SqlServerConnection : IConnectionString
    {
        private ConnectionType connectionType;
        private string connectionString;
        private string separator;

        public SqlServerConnection() 
        {
            connectionType = ConnectionType.SQL_SERVER;
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
