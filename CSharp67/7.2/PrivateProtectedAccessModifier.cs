using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp67._7._2
{
    class PrivateProtectedAccessModifier
    {
        /// <summary>
        /// private protected indicates that a member may be accessed by containing class or derived classes that are declared in the same assembly
        /// </summary>
        private protected void CanAccessByInnerClassOrDerivedClassInSameAssembly()
        {

        }


        /// <summary>
        /// protected internal allows access by derived classes or classes that are in the same assembly
        /// </summary>
        protected internal void CanAccessByDerivedClassOrSameAssemblyClass()
        {

        }

        /// <summary>
        /// private protected limits access to derived types declared in the same assembly.
        /// </summary>
        private protected void CanAccessByDerivedTypesInSameAssembly()
        {

        }
    }
}
