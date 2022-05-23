using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibiltyPattern
{
    internal class GardenHandler : BaseHandler
    {
        public override void HandleRequest(Home home)
        {
            if (home.WaterGarden == true)
            {
                Console.WriteLine("Bahçe Sulandı");
            }
        }
    }
}
