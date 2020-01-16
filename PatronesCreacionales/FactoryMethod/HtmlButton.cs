using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Conceptual
{

    class HtmlButton : IButton
    {
        public string Operation()
        {
            return "{Result of HTML button}";
        }
    }
}
