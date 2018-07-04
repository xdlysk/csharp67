using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp67
{
    class NameOf
    {
        public NameOf(int mustLargeThanZero)
        {
            if (mustLargeThanZero <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(mustLargeThanZero),
                    "argument " + nameof(mustLargeThanZero) + " must large than zero");
            }
        }
    }
}
