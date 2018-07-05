using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp67._7
{
    class IsExpression
    {
        public static int DiceSum2(IEnumerable<object> values)
        {
            var sum = 0;
            foreach (var item in values)
            {
                if (item is int val)
                    sum += val;
                else if (item is IEnumerable<object> subList)
                    sum += DiceSum2(subList);
            }
            return sum;
        }
    }
}
