using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class CustomMathOperationsAdapter : IMathOperation //Adapter
    {
        public int Topla(int sayi1, int sayi2)
        {
            CustomMathOperations customMathOperations = new CustomMathOperations();
            return customMathOperations.Toplayici(sayi1, sayi2);
        }
    }
}
