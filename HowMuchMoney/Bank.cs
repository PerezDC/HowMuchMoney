using System;
using System.Collections.Generic;
using System.Text;

namespace HowMuchMoney
{
    public class Bank
    {
        static string[] coins = { "penny", "nickel", " dime", "quarter" };
        Random RandomNumber;

        public Bank()
        {
            RandomNumber = new Random();
        }

        public Bank(int RandomSeed)
        {
            RandomNumber = new Random(RandomSeed);
        }

        public int CountMyCoins()
        {
            return RandomNumber.Next(10, 50);
        }

        public string[] GetCoins(int howMany)
        {
            string[] myCoins = new string[howMany];

            for (int i = 0; i < howMany; i++)
            {
                myCoins[i] = coins[RandomNumber.Next(0, 4)];
                //Console.Write(myCoins[i] + ' ');
            }
            Console.WriteLine();
            return myCoins;
        }

        public decimal HowMuch(string[] allTheCoins)
        {
            decimal total = 0;

            foreach (string coin in allTheCoins)
            {
                switch(coin)
                {
                    case "penny":
                        total+= .01m;
                        break;
                    case "nickel":
                        total += .05m;
                        break;
                    case "dime":
                        total += .10m;
                        break;
                    case "quarter":
                        total += .25m;
                        break;
                }
            }
            return total;
        }
    }
}
