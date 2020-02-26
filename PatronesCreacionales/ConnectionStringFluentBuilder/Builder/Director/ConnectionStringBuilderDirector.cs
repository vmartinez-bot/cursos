using ConnectionStringBuilder.Fluent.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionStringBuilder.Fluent
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
            if (_trusted)
            {
                builder.BuildServer("localhost")
                       .BuildDatabase("BOT-Analisis")
                       .BuildTrusted(true)                       
                       .BuildTimeout(60);
            }
            else 
            {
                builder.BuildServer("localhost")
                       .BuildDatabase("BOT-Analisis")
                       .BuildUserID("usuario")
                       .BuildDatabase("********")
                       .BuildTimeout(60);
            }
        }      
    }
}
