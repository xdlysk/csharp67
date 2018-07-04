using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp67._7._1
{
    class InferredTupleElementNames
    {
        void before()
        {
            int count = 5;
            string label = "Colors used in the map";
            var pair = (count: count, label: label);
        }

        void now()
        {
            int count = 5;
            string label = "Colors used in the map";
            var pair = (count, label); // element names are "count" and "label"
        }
    }
}
