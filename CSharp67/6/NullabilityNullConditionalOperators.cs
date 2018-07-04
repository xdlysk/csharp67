using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp67
{
    class NullabilityNullConditionalOperators
    {
        public static string ToString(NullabilityNullConditionalOperators operators)
        {
            return operators?.ToString()?.ToUpper() ?? "OOOO";
        }
    }
}
