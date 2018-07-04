using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp67._7._1
{
    class DefaultLiteralExpressions
    {
        //before
        Func<string, bool> whereClause = default(Func<string, bool>);

        //now
        Func<string, bool> whereClause1 = default;
    }
}
