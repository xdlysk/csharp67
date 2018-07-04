using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp67
{
    class ExpressionBodiedMembers
    {
        public override string ToString() => base.ToString();

        public string ReadonlyProperty => "haha";
    }
}
