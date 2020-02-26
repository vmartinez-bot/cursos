using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionStringBuilder.Fluent.Interfaces
{
   public interface IConnectionStringBuildTrusted
    {
        public void BuildTrusted();

        public IConnectionStringBuildUser BuildNoTrusted();
    }
}
