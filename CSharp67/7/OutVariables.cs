using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp67
{
    class OutVariables
    {
        private readonly Dictionary<int, string> dictionary = new Dictionary<int, string>
        {
            {1,"1" },
            {2,"2" }
        };

        public bool Contains(int i)
        {
            return dictionary.TryGetValue(i, out string value);
        }
    }
}
