using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class CarFactory
    {
        public ISell createSell(string sellType)
        {
            if (sellType == "Bitcoin")
            {
                return new SellWithBitcoin();
            }
            else if(sellType == "Money")
            {
                return new SellWithRealMoner();
            }
            return null;

        }
    }
}
