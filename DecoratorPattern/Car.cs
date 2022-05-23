using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class Car : ICarFunction //Concrete Component
    {
        private string _name;

        public Car(string name)
        {
            _name = name;
        }

        public void getGas(int litres)
        {
            Console.WriteLine("You got "+litres+" gas");
        }

        public void slowDown()
        {
            Console.WriteLine("You slowed down");
        }

        public void speedUp()
        {
            Console.WriteLine("You speed up");
        }
    }
}
