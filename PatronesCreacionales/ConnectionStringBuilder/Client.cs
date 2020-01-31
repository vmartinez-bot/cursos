using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionStringBuilder
{
   public class Client
    {
        public void Main()
        {
            SqlServerConnectionStringBuilder builder1 = new SqlServerConnectionStringBuilder();
            
            ConnectionStringBuilderDirector director = new ConnectionStringBuilderDirector(builder1);

            director.MakeConnectionString(true);
            PrintConnString(builder1.GetConnectionString());

            ///------------------------------------------
            MySqlConnectionStringBuilder builder2 = new MySqlConnectionStringBuilder();
            director.ChangeBuilder(builder2);
            director.MakeConnectionString(true);
            PrintConnString(builder2.GetConnectionString());

            ///--------------------------------------------

            AccessConnectionStringBuilder builder3 = new AccessConnectionStringBuilder();
            director.ChangeBuilder(builder3);
            director.MakeConnectionString(true);
            PrintConnString(builder3.GetConnectionString());

            Console.ReadLine();            
        }

        private void PrintConnString(IConnectionString _connString) 
        {
            Console.WriteLine("{0}: {1}", _connString.GetConnectionType().ToString() , _connString.GetString());
        }
    }

    
}
