using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionStringBuilder.Fluent
{
    class MySqlConnectionStringBuilder : IConnectionStringBuilder
    {
        private MySqlConnection connection;

        public MySqlConnectionStringBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            connection = new MySqlConnection();
        }
        public IConnectionStringBuilder BuildTimeout(int _timeout)
        {
            ///There is no timeout in MySQL connection string but for sample we add "Timeout"
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
            connection.AddConnectionPart(string.Format("Pwd={0}", _password));
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
                connection.AddConnectionPart(string.Format("IntegratedSecurity={0};Uid={1};", "yes", "auth_windows"));
            }
            return this;
        }

        public IConnectionStringBuilder BuildUserID(string _user)
        {
            connection.AddConnectionPart(string.Format("Uid ={0}", _user));
            return this;
        }

        public IConnectionString GetConnectionString()
        {
            return connection;
        }

    }
}
