using System;

namespace Ukiyo
{
    public class failInput
    {
        public void failNumber()
        {
            Console.WriteLine("Invalid input.");
        }
        public void failRoom()
        {
            Console.WriteLine("We are sorry. The room is unavailable at this moment.");
        }
        public void cont()
        {
            Console.WriteLine("Do you want to continue to the payment?\nYes/No?");
            string buh = Console.ReadLine();
            
            if(buh == "yes" || buh == "Yes" || buh == "YES")
            {
                payment newpay = new payment();
                newpay.paymentmethod();
            }
            else
            {
                Console.WriteLine("Thankyou for using our service.");
                return;
            }
        }
    }
}