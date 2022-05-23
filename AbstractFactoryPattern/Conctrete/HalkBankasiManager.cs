using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class HalkBankasiManager : BankService
    {
        public override int ParaIslemleri(string emir)
        {
            if(emir == "para çek")
            {
                return 100;
            }
            else
            {
                return 0;
            }
        }
        
    }
}
