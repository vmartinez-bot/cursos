using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionStringBuilder
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
        public void BuildTimeout(int _timeout)
        {
            ///There is no timeout field in MySQL connection string, but for sample we use "Timeout"
            connection.AddConnectionPart(string.Format("Timeout={0}", _timeout));
        }

        public void BuildDatabase(string _database)
        {
            connection.AddConnectionPart(string.Format("Dbq={0}", _database+".mdb"));
        }

        public void BuildPassword(string _password)
        {
            connection.AddConnectionPart(string.Format("Pwd={0}", _password));
        }

        public void BuildServer(string _server)
        {
            //There are no server field in Access connection string
            connection.AddConnectionPart("Driver ={Microsoft Access Driver(*.mdb)}");
        }

        public void BuildTrusted(bool _trusted)
        {
            if (_trusted)
            {
                connection.AddConnectionPart(string.Format("Persist Security Info={0}", _trusted));
            }
        }

        public void BuildUserID(string _user)
        {
            connection.AddConnectionPart(string.Format("Uid ={0}", _user));
        }

        public IConnectionString GetConnectionString()
        {
            return connection;
        }

    }
}

