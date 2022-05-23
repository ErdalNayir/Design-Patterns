using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Takip edilecek olan yapımızdır.
// İçerisinde Observer (değişimden etkilenecek) nesneleri tutar.
// UML diyagramındaki Observable yapısına denk gelmektedir.

namespace ObserverPattern
{
    abstract class ObservableSalary
    {
        private List<Worker> _workerList;
        protected SalaryIncrease salaryIncrease;

        protected ObservableSalary()
        {
            _workerList = new List<Worker>();
            this.salaryIncrease = new SalaryIncrease();
        }

        public void AddObserver(Worker observerUser)
        {
            _workerList.Add(observerUser);
        }
        public void RemoveObserver(Worker observerUser)
        {
            _workerList.Remove(observerUser);
        }
        public void NotifyObserver()
        {
            foreach (Worker worker in _workerList)
            {
                salaryIncrease.personName = worker.name;
                worker.IncreaseSalary(salaryIncrease);
                
            }
        }
    }
}

