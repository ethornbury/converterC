using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author: Emer Thornbury
//Date: 1/12/2015

namespace CalcDist
{
    class Program
    {

        static void Main(string[] args)
        {
            // accept distance in form of metres
            // catch the invalid values
            // and ..
            // else show menu to choose conversion
            // accept menu choice for conversion type
            // show new distance
            // allow again until 4 is entered

            double metres = 0;

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n Distance Converter ");
            Console.ResetColor();
            Console.Write("\nEnter the distance in metres you would like converted: ");
            metres = double.Parse(Console.ReadLine());
            if (metres < 0)
            {
                //catch the idiot
                Console.WriteLine("That entry can't be converted, you would be going backwards.. somewhere");
            }
            else if (metres == 0)
            {
                //catch the idiot
                Console.WriteLine("That entry can't be converted, you would be going nowhere...");
            }
            else
            {
                //into menu options
                // pass the metres in to be converted
                Menu(metres);
            }
        }


        // menu method
        static void Menu(double metres)
        {
            // int menuChoice to -1 to force into loop first time
            int menuChoice = -1;

            while (menuChoice != 4)
            {

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\n Convert to: ");
                Console.ResetColor();
                Console.WriteLine("------");
                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("Kilometres: ");
                Console.ResetColor();
                Console.WriteLine("(type 1)");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Inches: ");
                Console.ResetColor();
                Console.WriteLine("(type 2)");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Feet: ");
                Console.ResetColor();
                Console.WriteLine("(type 3)");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Exit and get the hell out of here: ");
                Console.ResetColor();
                Console.WriteLine("(type 4)");
                Console.ResetColor();
                Console.WriteLine("------");
                menuChoice = int.Parse(Console.ReadLine());

                // menu choice paths
                if (menuChoice == 1)
                {
                    //call my method
                    ShowKilometres(metres);
                }
                else if (menuChoice == 2)
                {
                    //call my method
                    ShowInches(metres);
                }
                else if (menuChoice == 3)
                {
                    //call my method
                    ShowFeet(metres);
                }

                else if (menuChoice != 4)
                {
                    //gotcha
                    Console.WriteLine("Invalid option");

                }
            }

            //and we are done
            Console.WriteLine("Nice working with you");
            Console.ReadLine();
        }

        // my methods
        static void ShowKilometres(double metres)
        {
            // method to show metres as kilometres
            double distance = metres * 0.001;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Your distance of {0} metres in kilometres is {1}", metres, distance);
            Console.ResetColor();
        }

        static void ShowInches(double metres)
        {
            // method to show inches
            double distance = metres * 39.37;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your distance of {0} metres in inches is {1}", metres, distance);
            Console.ResetColor();
        }

        static void ShowFeet(double metres)
        {
            // method to show feet
            double distance = metres * 3.281;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Your distance of {0} metres in feet is {1}", metres, distance);
            Console.ResetColor();
        }

    }
}
