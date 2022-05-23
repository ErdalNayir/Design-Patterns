using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Observer sınıfından türer.
// UML diyagramındaki ConcreteObservable yapısına denk gelmektedir.

namespace ObserverPattern
{
     class Vestel:ObservableSalary
    {
        public void increaseAllSalariesBy()
        {
            this.salaryIncrease.amaount = 100;
            this.NotifyObserver();
        }
    }
}
