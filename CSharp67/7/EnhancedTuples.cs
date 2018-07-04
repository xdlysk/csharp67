using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp67
{
    class EnhancedTuples
    {
        public static (string a, string b) AnotherTuple = (b: "bbb", a: "aaa");

        public static (string,string) ReturnARealTuple()
        {
            return ("tuple?","yes");
        }
    }
}
