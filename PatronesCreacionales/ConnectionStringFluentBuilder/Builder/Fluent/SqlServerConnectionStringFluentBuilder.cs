using ConnectionStringBuilder.Fluent.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionStringBuilder.Fluent.Builder
{
    class SqlServerConnectionStringFluentBuilder : IConnectionStringBuilderFluent, IConnectionStringBuildServer, IConnectionStringBuildDatabase, IConnectionStringBuildUser, IConnectionStringBuildPassword, IConnectionStringBuildTrusted
    {
        private SqlServerConnection connection;

        public SqlServerConnectionStringFluentBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            connection = new SqlServerConnection();
        }

        public IConnectionStringBuildDatabase BuildServer(string _server)
        {
            connection.AddConnectionPart(string.Format("Server={0}", _server));
            return this;
        }
        public IConnectionStringBuildTrusted BuildDatabase(string _database)
        {
            connection.AddConnectionPart(string.Format("Database={0}", _database));
            return this;
        }
        public void BuildTrusted()
        {            
            connection.AddConnectionPart(string.Format("Trusted_Connection={0}", "True"));   
        }
        public IConnectionStringBuildUser BuildNoTrusted() 
        {
            return this;
        }
        public IConnectionStringBuildPassword BuildUserID(string _user)
        {
            connection.AddConnectionPart(string.Format("User Id ={0}", _user));
            return this;
        }

        public void BuildPassword(string _password)
        {
            connection.AddConnectionPart(string.Format("Password={0}", _password));
        }
        
        public IConnectionString GetConnectionString()
        {
            return connection;
        }
    }
}
