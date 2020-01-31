using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionStringBuilder
{

    public class ConnectionStringBuilderDirector
    {
        private IConnectionStringBuilder builder;
       public ConnectionStringBuilderDirector(IConnectionStringBuilder _builder) 
        {
            builder = _builder;
        }

        public void ChangeBuilder(IConnectionStringBuilder _builder) 
        {
            builder = _builder;    
        }

        public void MakeConnectionString(bool _trusted) 
        {
            //Construction steps
            builder.BuildServer("localhost:1433");
            builder.BuildDatabase("BOT-Analisis");

            builder.BuildTrusted(_trusted);

            if (!_trusted)           
            {
                builder.BuildUserID("usuario");
                builder.BuildPassword("********");
            }

            builder.BuildTimeout(60);
        }
    }
}
