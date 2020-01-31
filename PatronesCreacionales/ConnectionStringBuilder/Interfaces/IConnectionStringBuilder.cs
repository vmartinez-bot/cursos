using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionStringBuilder
{
    public  interface IConnectionStringBuilder
    {
        void Reset();

        void BuildServer(string _server);

        void BuildDatabase(string _database);

        void BuildUserID(string _user);

        void BuildPassword(string _password);

        void BuildTimeout(int _timeout);

        void BuildTrusted(bool _trusted);

    }
}
