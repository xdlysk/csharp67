using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp67._7._3
{
    class AttachAttributesToTheBackingFields
    {
        [field: Required]
        public string SomeProperty { get; set; }

        private class RequiredAttribute : Attribute
        {
        }
    }
}
