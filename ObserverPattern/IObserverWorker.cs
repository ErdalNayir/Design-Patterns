using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Değişimden etkilenecek, izleyecek olan sınıfların uyguladığı arayüzdür.
// UML diyagramındaki Observer yapısına denk gelmektedir.


namespace ObserverPattern
{
     interface IObserverWorker
    {
        void IncreaseSalary(SalaryIncrease salaryIncrease);
    }
}
