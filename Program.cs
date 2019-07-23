using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Vending
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine blah;
            blah = new VendingMachine();

            blah.DepositCoin(25);
            blah.DepositCoin(25);
            blah.DepositCoin(10);
            blah.DepositCoin(50);
            blah.DepositCoin(100);
            blah.GetDrink();
            blah.DepositCoin(25);
            blah.DepositCoin(25);
            blah.DepositCoin(10);
            blah.GetDrink();
            blah.GetRefund();
            blah.DepositCoin(100);
            blah.DepositCoin(25);
            blah.GetDrink();
            blah.GetRefund();
            Console.WriteLine("PAK");
            Console.ReadKey();
        }
    }
}
