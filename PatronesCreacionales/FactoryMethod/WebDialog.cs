using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Conceptual
{
    class WebDialog : Dialog
    {
        public override IButton createButton()
        {
            return new HtmlButton();
        }
    }
}
