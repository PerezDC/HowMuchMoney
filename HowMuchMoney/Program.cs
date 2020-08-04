using System;

namespace HowMuchMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HowMuchMoney.Program.Main()");

            Bank MyBank = new Bank( 73 );
            int nmbrCoins = MyBank.CountMyCoins();
            Console.WriteLine($"Wow! I have {nmbrCoins} coins in my piggybank!");

            string[] allMyCoins = MyBank.GetCoins(nmbrCoins);
            int howMuch = MyBank.HowMuch(allMyCoins);

        }
    }
}
