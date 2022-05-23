using AbstractFactoryPattern.Abstract.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Conctrete
{
    internal class HalkBankasiAccountManager : AccountService
    {
        public override bool LoginSystem()
        {
            //Console.WriteLine("Sisteme Giriş Yapıldı");
            return true;
        }

        public override bool LogoutSystem()
        {
            //Console.WriteLine("Sisteme Çıkış Yapıldı");
            return true;
        }
    }
}
