using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp67._7._1
{
    class AsyncMain
    {
        static async Task<int> Main()
        {
            // This could also be replaced with the body
            // DoAsyncWork, including its await expressions:
            return await DoAsyncWork();
        }

        static Task<int> DoAsyncWork()
        {
            throw new NotImplementedException();
        }
    }

    
}
