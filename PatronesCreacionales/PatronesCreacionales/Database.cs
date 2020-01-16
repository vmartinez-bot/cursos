using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Database
    {
        private Database() { }

        private static Database instance;
        
        public static Database getInstance()
        {
            if (instance == null)
                instance = new Database();
            return instance;
        }

        public void query(string sql) {
             ///Realize the query
        }
    }
}
