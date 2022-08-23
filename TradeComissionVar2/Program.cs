using System;

namespace TradeComission
{
    class Program
    {
        static void Main(string[] args)
        {
            // INPUT
            string town = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());

            // CALCULATIONS
            double totalPrice = 0;

            if (!(town == "Sofia" || town == "Varna" || town == "Plovdiv") || sells <= 0)
            {
                Console.WriteLine("error");
            }

            else
            {
                switch (town)
                {
                    case "Sofia":
                        if (sells >= 0 && sells <= 500)
                        {
                            totalPrice = sells * 0.05;
                        }
                        else if (sells > 500 && sells <= 1000)
                        {
                            totalPrice = sells * 0.07;
                        }
                        else if (sells > 1000 && sells <= 10000)
                        {
                            totalPrice = sells * 0.08;
                        }
                        else if (sells > 10000)
                        {
                            totalPrice = sells * 0.12;
                        }
                        break;
                    case "Varna":
                        if (sells >= 0 && sells <= 500)
                        {
                            totalPrice = sells * 0.045;
                        }
                        else if (sells > 500 && sells <= 1000)
                        {
                            totalPrice = sells * 0.075;
                        }
                        else if (sells > 1000 && sells <= 10000)
                        {
                            totalPrice = sells * 0.10;
                        }
                        else if (sells > 10000)
                        {
                            totalPrice = sells * 0.13;
                        }
                        break;
                    case "Plovdiv":
                        if (sells >= 0 && sells <= 500)
                        {
                            totalPrice = sells * 0.055;
                        }
                        else if (sells > 500 && sells <= 1000)
                        {
                            totalPrice = sells * 0.08;
                        }
                        else if (sells > 1000 && sells <= 10000)
                        {
                            totalPrice = sells * 0.12;
                        }
                        else if (sells > 10000)
                        {
                            totalPrice = sells * 0.145;
                        }
                        break;

                }

                Console.WriteLine($"{totalPrice:f2}");
            }
        }
    }
}
