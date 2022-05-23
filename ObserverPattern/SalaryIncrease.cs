using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Bildirilecek olan nesnelere paremetre olarak giden mesaj.
// UML diyagramı ile ilgisi yoktur.

namespace ObserverPattern
{
    class SalaryIncrease
    {
        public string productName = "Salary";
        public string personName;
        public int amaount;
        public override string ToString()
        {
            return $"{personName} {productName} has been increased by {amaount}";
        }
    }
}