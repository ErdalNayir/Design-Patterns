using AbstractFactoryPattern.Abstract.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Abstract.Interface
{
     interface IBankFactory
    {
        AccountService createAccountService();
        BankService createBankService();
    }
}
