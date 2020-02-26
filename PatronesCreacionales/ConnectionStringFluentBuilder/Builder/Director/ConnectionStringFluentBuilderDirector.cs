using System;
using System.Collections.Generic;
using System.Text;
using ConnectionStringBuilder.Fluent.Interfaces;

namespace ConnectionStringBuilder.Fluent
{
    class ConnectionStringFluentBuilderDirector
    {
        private IConnectionStringBuilderFluent builder;
        public ConnectionStringFluentBuilderDirector(IConnectionStringBuilderFluent _builder)
        {
            builder = _builder;
        }

        public void ChangeBuilder(IConnectionStringBuilderFluent _builder)
        {
            builder = _builder;
        }

        public void MakeConnectionStringWithFluent(bool _trusted)
        {
            if (_trusted)
            {
                builder.BuildServer("localhost")
                             .BuildDatabase("BOT-Analisis")
                             .BuildTrusted();
            }
            else
            {
                builder.BuildServer("localhost")
                             .BuildDatabase("BOT-Analisis")
                             .BuildNoTrusted()
                             .BuildUserID("usuario")
                             .BuildPassword("********");
            }
        }
    }
}
