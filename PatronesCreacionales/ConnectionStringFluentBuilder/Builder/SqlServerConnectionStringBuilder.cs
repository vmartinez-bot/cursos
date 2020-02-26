using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionStringBuilder.Fluent
{
    public class SqlServerConnectionStringBuilder : IConnectionStringBuilder
    {
        private SqlServerConnection connection;

       public SqlServerConnectionStringBuilder() 
        {
            Reset();
        }

        public void Reset()
        {
            connection = new SqlServerConnection();
        }
        public IConnectionStringBuilder BuildTimeout(int _timeout)
        {
            ///There is no timeout in SqlServer connection string, but for sample we use "Timeout"
            connection.AddConnectionPart(string.Format("Timeout={0}", _timeout));
            return this;
        }

        public IConnectionStringBuilder BuildDatabase(string _database)
        {
            connection.AddConnectionPart(string.Format("Database={0}", _database));
            return this;
        }

        public IConnectionStringBuilder BuildPassword(string _password)
        {
            connection.AddConnectionPart(string.Format("Password={0}", _password));
            return this;
        }

        public IConnectionStringBuilder BuildServer(string _server)
        {
            connection.AddConnectionPart(string.Format("Server={0}", _server));
            return this;
        }

        public IConnectionStringBuilder BuildTrusted(bool _trusted)
        {
            if (_trusted)
            {
                connection.AddConnectionPart(string.Format("Trusted_Connection={0}", _trusted));
            }
            return this;
        }

        public IConnectionStringBuilder BuildUserID(string _user)
        {
            connection.AddConnectionPart(string.Format("User Id ={0}", _user));
            return this;
        }

        public IConnectionString GetConnectionString() 
        {
            return connection;
        }

    }
}

