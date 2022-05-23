using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class CustomMathOperations //Adaptee
    {
        public int Toplayici(int sayi1,int sayi2)
        {
            return sayi1+ sayi2;
        }
    }
}
