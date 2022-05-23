using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
     interface ICarFunction //Component
    {
        void slowDown();
        void getGas(int litres);
        void speedUp();
    }
}
