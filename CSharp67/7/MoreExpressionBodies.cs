using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp67
{
    class MoreExpressionBodies
    {
        // Expression-bodied constructor
        public MoreExpressionBodies(string label) => this.Label = label;

        // Expression-bodied finalizer
        ~MoreExpressionBodies() => Console.Error.WriteLine("Finalized!");

        private string label;

        // Expression-bodied get / set accessors.
        public string Label
        {
            get => label;
            set => this.label = value ?? "Default label";
        }
    }
}
