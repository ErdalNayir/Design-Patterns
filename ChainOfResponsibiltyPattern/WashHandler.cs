using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibiltyPattern
{
    internal class WashHandler : BaseHandler
    {
        public override void HandleRequest(Home home)
        {
            if (home.WashDishes == true)
            {
                Console.WriteLine("Bulaşıklar Yıkandı");
                _nextHandler.HandleRequest(home);
            }
            else
            {
                _nextHandler.HandleRequest(home);
            }
        }
    }
}
