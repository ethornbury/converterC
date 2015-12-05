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
            // catch invalid values
            // show menu to choose conversion
            // accept menu choice for conversion type
            // show new distance
            // accept menu choice to convert again
            // allow until 4 is entered

            double metres = 0;
            int menuChoice = -1;

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n Distance Converter ");
            Console.ResetColor();
            Console.Write("\nEnter the distance in metres you would like converted: ");
            try
            {
                metres = double.Parse(Console.ReadLine());
                // catch invalid entries of metres

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
                    Menu();
                    //Console.WriteLine(" TESTLINE 1");   //testline             
                }

                menuChoice = int.Parse(Console.ReadLine());
                //Console.WriteLine(" TESTLINE 2");  //testline

                // loop to convert your metres into different types
                do
                {

                    // menu choice paths
                    if (menuChoice == 1)
                    {
                        //call my kilometres method                    
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Your distance in kilometres is ");
                        Console.WriteLine(ShowKilometres(metres));
                        Console.ResetColor();
                    }
                    else if (menuChoice == 2)
                    {
                        //call my inches method
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Your distance in inches is ");
                        Console.WriteLine(ShowInches(metres));
                        Console.ResetColor();

                    }
                    else if (menuChoice == 3)
                    {
                        //call my feet method
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("Your distance in feet is ");
                        Console.WriteLine(ShowFeet(metres));
                        Console.ResetColor();

                    }

                    else if (menuChoice != 4)
                    {
                        //gotcha
                        Console.WriteLine("Invalid option");

                    }
                    Menu();
                    menuChoice = int.Parse(Console.ReadLine());
                    //Console.WriteLine(" TESTLINE 3 and metres: "+ metres); //testline

                } while (menuChoice != 4);

            }// end of try
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //and we are done
                Console.WriteLine("Nice working with you");
                Console.ReadLine();
            }
        }

        // my methods
        static void Menu()
        {
            // menu method to display menu
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
        }
          
        static double ShowKilometres(double distance)
        {
            // method to show metres as kilometres
            return distance * 0.001;            
        }

        static double ShowInches(double distance)
        {
            // method to show inches
            return distance * 39.37;           
        }

        static double ShowFeet(double distance)
        {
            // method to show feet
            return distance * 3.281;            
        }

    }
}
