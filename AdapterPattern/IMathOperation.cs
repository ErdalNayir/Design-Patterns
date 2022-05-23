using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    interface IMathOperation //Target
    {
        public int Topla(int sayi1, int sayi2);
    }
}
