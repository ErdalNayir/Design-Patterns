using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    abstract class BaseCarDecorator:ICarFunction
    {
        protected ICarFunction carFunction;

        protected BaseCarDecorator(ICarFunction carFunction)
        {
            this.carFunction = carFunction;
        }

        //DEGİSTİRİLMEK ISTENEN OZELLIKLER
        public abstract void slowDown();
        public abstract void speedUp();
        public abstract void getGas(int litres);
    }
}
