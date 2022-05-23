using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Zincirin bir sonraki halkasının referansının tutulduğu sınıftır.
// İşlemi gerçekleştirecek olan metot tanımı bulunur.
// UML diyagramındaki BaseHandler sınıfına denk gelmektedir.

namespace ChainOfResponsibiltyPattern
{
    abstract class BaseHandler
    {
        protected BaseHandler _nextHandler;

        public void SetNextHandler(BaseHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void HandleRequest(Home home);
    }

}
