using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp67
{
    class Program
    {
        //https://docs.microsoft.com/en-us/dotnet/csharp/
        static void Main(string[] args)
        {
            //AutopropertiesAndImmutability aai = new AutopropertiesAndImmutability();
            //aai.NoSetAccesstor = 1;
            //aai.ReadonlyProperty = 1;

            //ExceptionFilters exceptionFilters = new ExceptionFilters();
            //exceptionFilters.DoSomethingWithException();

            //var atuple = EnhancedTuples.ReturnARealTuple();
            //(string tuple, string yes) = EnhancedTuples.ReturnARealTuple();
            //var (tuple, yes) = EnhancedTuples.ReturnARealTuple();
            var (_, yes) = EnhancedTuples.ReturnARealTuple();
            

            var matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Func<int, bool> predicate = v => v == 1;
            ref var value = ref RefReturns.Find3(matrix, predicate);
            value = 10;
        }
    }
}
