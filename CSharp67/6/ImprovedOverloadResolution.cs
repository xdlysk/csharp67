using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp67._6
{
    class ImprovedOverloadResolution
    {
        static Task DoThings()
        {
            return Task.FromResult(0);
        }

        void main()
        {
            //now
            Task.Run(DoThings);


            //before
            Task.Run(() => DoThings());
        }

        


    }
}
