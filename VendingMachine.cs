using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Vending
{
    class VendingMachine
    {
        int depositedamount; #creates the depositedamount integer

        public VendingMachine()
        {
            depositedamount = 0; #sets the integer to 0
        }
        public void DepositCoin(int coinAmount) #method for depositing various amounts of change into the machine
        {
            if (coinAmount == 5 || coinAmount == 10 || coinAmount == 25 || coinAmount == 100) #the different ammounts that are accepted
            {
                depositedamount = depositedamount + coinAmount; #adds the depositedamount and coinAmount to new total depositedamount
            }
            else
            {
                Console.WriteLine("Error coin not recognized"); #if one of the options arent used then this is the message that shows
            }
            Console.WriteLine($"You have deposited {depositedamount} cents so far "); #lets the user know how much money is in the machine
        }
        public void GetDrink() #method for buying drink out the machine 
        {
            if (depositedamount >= 125) #if the deposited amount is more greater than or equal to 125 cents
            {   
                Console.WriteLine("Enjoy your Drink"); #writes out message to console
                Console.WriteLine($"Your change is {depositedamount - 125} "); #tallies the change for the user 
                depositedamount = 0; #resets the deposited amount to 0
            }
             else
            {
                Console.WriteLine("You must insert 125 cents"); #if change is not equal to that deposited amount this message shows
            }
        }

        public void GetRefund() #method for getting refund for the user
        {
            if (depositedamount > 0) #if the amount is greater than 0
            {
                Console.WriteLine($"You were refunded {depositedamount} cents "); #writes message to the screen 
                depositedamount = 0; #resets depositedamount to 0
            }
            else
            {
                Console.WriteLine("No coin was inserted"); #if no coin was inserted then this message shows
            }

        }

    }
}
        
