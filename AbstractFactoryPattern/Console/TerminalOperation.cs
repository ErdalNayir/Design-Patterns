using AbstractFactoryPattern.Abstract.Class;
using AbstractFactoryPattern.Abstract.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Console
{
    class TerminalOperation
    {
        IBankFactory _bankFactory;
        AccountService _accountService;
        BankService _bankService;
        public TerminalOperation(IBankFactory bankFactory)
        {
            _bankFactory = bankFactory;
            _accountService=bankFactory.createAccountService();
            _bankService=bankFactory.createBankService();

        }
        public int GetHundredLiras(string emir)
        {
            _accountService.LoginSystem();
            _accountService.LogoutSystem();
            return _bankService.ParaIslemleri(emir);
        }
    }
}
