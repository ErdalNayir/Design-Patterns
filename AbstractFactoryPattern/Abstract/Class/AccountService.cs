using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Abstract.Class
{
    public abstract class AccountService
    {
        public abstract bool LoginSystem();
        public abstract bool LogoutSystem();
    }
}
