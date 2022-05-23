using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Observer arayüzünü uygulayan, değişimi takip eden sınıflardır.
// Değişim update metotu ile bildirilir.
// UML diyagramındaki ConcreteObserver yapısına denk gelmektedir.

namespace ObserverPattern
{
    class Worker : IObserverWorker
    {
        public string name { get; set; }

        public Worker(string name)
        {
            this.name = name;
        }

        public void IncreaseSalary(SalaryIncrease salaryIncrease)
        {
            Console.WriteLine(salaryIncrease.ToString());
        }
    }
}
