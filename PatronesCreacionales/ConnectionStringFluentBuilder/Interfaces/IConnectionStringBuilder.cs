using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionStringBuilder.Fluent
{
    /// <summary>
    /// Implementation of Fluent Builder Pattern 
    /// </summary>
    public  interface IConnectionStringBuilder
    {
       
        void Reset();

        IConnectionStringBuilder BuildServer(string _server);

        IConnectionStringBuilder BuildDatabase(string _database);

        IConnectionStringBuilder BuildUserID(string _user);

        IConnectionStringBuilder BuildPassword(string _password);

        IConnectionStringBuilder BuildTimeout(int _timeout);

        IConnectionStringBuilder BuildTrusted(bool _trusted);

    }
}
