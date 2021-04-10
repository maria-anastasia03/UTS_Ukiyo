using System;

namespace Ukiyo
{
    class Program
    {
        static void Main(string[] args)
        {
            intro openingProgram = new intro();
            openingProgram.opening();
            customer userinput = new customer();
            userinput.userData();
            Console.WriteLine("Do you wish to reservate?");
            option myNumber = new option();
            myNumber.choose();
        }
    }
}
