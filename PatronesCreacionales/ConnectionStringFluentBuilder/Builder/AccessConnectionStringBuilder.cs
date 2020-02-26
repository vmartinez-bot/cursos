using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionStringBuilder.Fluent
{
    class AccessConnectionStringBuilder : IConnectionStringBuilder
    {
        private AccessConnection connection;

        public AccessConnectionStringBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            connection = new AccessConnection();
        }
        public IConnectionStringBuilder BuildTimeout(int _timeout)
        {
            ///There is no timeout field in MySQL connection string, but for sample we use "Timeout"
            connection.AddConnectionPart(string.Format("Timeout={0}", _timeout));
            return this;
        }

        public IConnectionStringBuilder BuildDatabase(string _database)
        {
            connection.AddConnectionPart(string.Format("Dbq={0}", _database+".mdb"));
            return this;
        }

        public IConnectionStringBuilder BuildPassword(string _password)
        {
            connection.AddConnectionPart(string.Format("Pwd={0}", _password));
            return this;
        }

        public IConnectionStringBuilder BuildServer(string _server)
        {
            //There are no server field in Access connection string
            connection.AddConnectionPart("Driver ={Microsoft Access Driver(*.mdb)}");
            return this;
        }

        public IConnectionStringBuilder BuildTrusted(bool _trusted)
        {
            if (_trusted)
            {
                connection.AddConnectionPart(string.Format("Persist Security Info={0}", _trusted));
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

