using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp67._7._3
{
    class InMethodOverloadResolutionTiebreaker
    {
        static void M(in string arg)
        {
            arg = "123";
        }
    }
}
