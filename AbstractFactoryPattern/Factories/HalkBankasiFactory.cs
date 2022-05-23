using AbstractFactoryPattern.Abstract.Class;
using AbstractFactoryPattern.Abstract.Interface;
using AbstractFactoryPattern.Conctrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Factories
{
    public class HalkBankasiFactory : IBankFactory
    {
        public AccountService createAccountService()
        {
            return new HalkBankasiAccountManager();
        }

        public BankService createBankService()
        {
            return new HalkBankasiManager();
        }
    }
}
