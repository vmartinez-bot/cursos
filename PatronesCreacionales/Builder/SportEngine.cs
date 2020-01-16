using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Conceptual
{
    class SportEngine : IEngine
    {
        string IEngine.TestEngine()
        {
            return  "Sport Engine";
        }
    }
}
