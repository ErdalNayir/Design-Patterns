using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibiltyPattern
{
    class DinnerHandler : BaseHandler
    {
        public override void HandleRequest(Home home)
        {
            if (home.MakeDinner == true)
            {
                Console.WriteLine("Yemek Yapılıyor");
                _nextHandler.HandleRequest(home);
            }
            else
            {
                _nextHandler.HandleRequest(home);
            }
        }
    }
}
