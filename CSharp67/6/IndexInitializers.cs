using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp67
{
    class IndexInitializers
    {
        private Dictionary<int, string> dictionary;

        public IndexInitializers()
        {
            dictionary = new Dictionary<int, string>
            {
                {1,"1" },
                {2,"2" }
            };

            dictionary = new Dictionary<int, string>
            {
                [1] = "1",
                [10] = "10"
            };
        }
    }
}
