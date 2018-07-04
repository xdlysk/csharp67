using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp67._7._2
{
    class PrivateProtectedAccessModifier
    {
        private protected void CanAccessByInnerClassOrDerivedClass()
        {

        }
        //Finally, a new compound access modifier: private protected indicates that a member may be accessed by containing class or derived classes that are declared in the same assembly. While protected internal allows access by derived classes or classes that are in the same assembly, private protected limits access to derived types declared in the same assembly.
    }
}
