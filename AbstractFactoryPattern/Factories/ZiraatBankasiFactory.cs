using AbstractFactoryPattern.Abstract.Class;
using AbstractFactoryPattern.Conctrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factories
{
    public class ZiraatBankasiFactory
    {
        public AccountService createAccountService()
        {
            return new ZiraatAccountManager();
        }

        public BankService createBankService()
        {
            return new ZiraatBankasiManager();
        }
    }
}
