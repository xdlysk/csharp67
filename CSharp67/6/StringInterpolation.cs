using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp67
{
    class StringInterpolation
    {

        static string template = "hello {0} , my name is {1} , i'm from {2}";

        public override string ToString()
        {
            return $"{nameof(StringInterpolation)}'s ToString(){{sss}}{template}";
        }
    }
}
