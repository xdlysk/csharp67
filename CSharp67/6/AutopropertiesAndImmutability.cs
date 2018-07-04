using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp67
{
    class AutopropertiesAndImmutability
    {
        #region Autoproperties

        public AutopropertiesAndImmutability()
        {
            MyProperty = 2;
        }

        public int MyProperty { get; set; } = 1;

        #endregion


        #region Immutability

        public int PrivateSetAccesstor { get;private set; }

        public int ReadonlyProperty { get; } = 2;

        #endregion
    }
}
