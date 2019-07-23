using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Vending
{
    class VendingMachine
    {
        int depositedamount;

        public VendingMachine()
        {
            depositedamount = 0;
        }
        public void DepositCoin(int coinAmount)
        {
            if (coinAmount == 5 || coinAmount == 10 || coinAmount == 25 || coinAmount == 100)
            {
                depositedamount = depositedamount + coinAmount;
            }
            else
            {
                Console.WriteLine("Error coin not recognized");
            }
            Console.WriteLine($"You have deposited {depositedamount} cents so far ");
        }
        public void GetDrink()
        {
            if (depositedamount >= 125)
            {
                Console.WriteLine("Enjoy your Drink");
                Console.WriteLine($"Your change is {depositedamount - 125} ");
                depositedamount = 0;
            }
             else
            {
                Console.WriteLine("You must insert 125 cents");
            }
        }

        public void GetRefund()
        {
            if (depositedamount > 0)
            {
                Console.WriteLine($"You were refunded {depositedamount} cents ");
                depositedamount = 0;
            }
            else
            {
                Console.WriteLine("No coin was inserted");
            }

        }

    }
}
        
