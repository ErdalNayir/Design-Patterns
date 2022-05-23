using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
     class CustomOperation
    {
        private IMathOperation _operation;

        public CustomOperation(IMathOperation operation)
        {
            _operation = operation;
        }

        public int Topla(int sayi1,int sayi2) 
        {
            return _operation.Topla(sayi1,sayi2);
        }
    }
}
