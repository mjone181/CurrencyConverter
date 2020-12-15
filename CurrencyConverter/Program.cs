using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initial balance
            decimal cashBalance = 5000;
            decimal bitcoinBalance = 0;
            decimal litecoinBalance = 0;
            decimal etheriumBalance = 0;

            //Inital market values
            decimal bitcoinValue = 7480;
            decimal etheriumValue = 586.15m;
            decimal litecoinValue = 119.04m;

            bool isAppRunning = true;

            do
            {
                Console.WriteLine("Welcome to the application");
                Console.WriteLine("What would you like to do? Purchase/Sell/View Balance/Transfer/Exit");
                string userInput = Console.ReadLine();
                switch (userInput.ToUpper())
                {
                    //Allow the user to purchase digital currency for cash
                    case "PURCHASE":
                    case "P":
                        Console.WriteLine("What currency would you like to purchase?");
                        string purchaseSelection = Console.ReadLine();
                        break;
                    //Allow the user to sell digital currency for cash
                    case "SELL":
                    case "S":
                        bool isSelling = true;
                        while(isSelling == true)
                        {
                            Console.WriteLine("What currency would you like to sell for cash? Bitcoin/Litecoin/Etherium/Exit");
                            string currencySelection = Console.ReadLine();
                            switch (currencySelection.ToUpper())
                            {
                                case "BITCOIN":
                                case "B":
                                    Console.WriteLine($"You have {bitcoinBalance} Bitcoin");
                                    Console.WriteLine($"The current market value is {bitcoinValue}, how many would you like to sell? Enter an amount.");
                                    break;
                                case "LITECOIN":
                                case "L":
                                    Console.WriteLine($"You have {litecoinBalance} Bitcoin");
                                    Console.WriteLine($"The current market value is {bitcoinValue}, how many would you like to sell? Enter an amount.");
                                    break;
                                case "ETHERIUM":
                                case "E":
                                    break;
                                case "EXIT":
                                case "EX":
                                    break;
                                default:
                                    break;
                            }
                            
                        }
                        break;
                    //Allow the user to view the balance of all of their currencies
                    case "VIEW BALANCE":
                    case "V":
                        break;
                    //Allow the user to transfer between digial currency types
                    case "TRANSFER":
                    case "T":
                        break;
                    case "EXIT":
                    case "E":
                        isAppRunning = false;
                        break;
                    //Default case - kick them back to start of loop.
                    default:
                        break;
                }
            } while (isAppRunning == true);
            


        }
    }
}
