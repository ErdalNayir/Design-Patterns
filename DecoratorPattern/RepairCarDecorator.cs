using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Yeni davranışların tanımlandığı sınıftır.
// UML diyagramındaki BaseDecorator (BaseDataSourceDecorator) sınıfından türer.
// UML diyagramındaki ConcreteDecorator sınıfına denk gelmektedir.

namespace DecoratorPattern
{
    class RepairCarDecorator : BaseCarDecorator
    {
        public RepairCarDecorator(ICarFunction carFunction) : base(carFunction)
        {
        }

        public override void getGas(int litres)
        {
            Console.WriteLine("You got"+litres+ "gas");
            Console.WriteLine("Your cars has been repaired");
        }

        public override void slowDown()
        {
            base.carFunction.slowDown();
        }

        public override void speedUp()
        {
            base.carFunction.speedUp();
        }
    }
}
