using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp67
{
    class GeneralizedAsyncReturnTypes
    {
        public async ValueTask<int> Func()
        {
            await Task.Delay(100);
            return 5;
        }

        public async Task<int> Func2()
        {
            await Task.Delay(100);
            return 5;
        }
    }
}
