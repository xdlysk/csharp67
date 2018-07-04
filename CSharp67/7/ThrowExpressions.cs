using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp67
{
    class ThrowExpressions
    {
        public bool Assert(int mustLargeThanZero)
        {
            return mustLargeThanZero > 0 ? true :throw new ArgumentOutOfRangeException(nameof(mustLargeThanZero));
        }
    }
}
