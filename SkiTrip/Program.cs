using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            int days = int.Parse(Console.ReadLine()) - 1;
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            double price = 0;

                switch (roomType)
                {
                    case "room for one person":
                        price = 18.00;
                        break;

                    case "apartment":
                        price = 25.00;

                        if (days <10)
                        {
                            price = price * 0.7;
                        }

                        else if (days >= 10 && days <= 15)
                        {
                            price = price * 0.65;
                        }

                        else if (days > 15)
                        {
                            price = price * 0.50;
                        }
                        break;

                    case "president apartment":
                        price = 35.00;

                        if (days < 10)
                        {
                            price = price * 0.9;
                        }

                        else if (days >= 10 && days <= 15)
                        {
                            price = price * 0.85;
                        }

                        else if (days > 15)
                        {
                            price = price * 0.80;
                        }
                        break;

                }

            if (feedback == "positive")
            {
                Console.WriteLine($"{((days * price) * 1.25):f2}");
            }

            else if (feedback == "negative")
            {
                Console.WriteLine($"{((days * price) * 0.9):f2}");
            }
        }
    }
}
