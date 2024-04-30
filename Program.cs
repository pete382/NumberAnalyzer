using System;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

public class NumberAnalyzer
{
    public static void Main()
    {
        

        do
        {


            Console.WriteLine("Hello, whot is your name ?");
            string name = Console.ReadLine();
            Console.WriteLine(name + ", pick a Number between 1 and 100 and I will provide an analysis of it. ");

            int number = int.Parse(Console.ReadLine());

            int odd_even = number % 2;



            if (odd_even != 0 && number < 60)
            {

                string value = ($"value:{number}");
                Console.WriteLine(name + " ,Odd and less than 60.");

            }

            else if (odd_even == 0 && number < 25)
            {

                string value = ($"value:{number}");
                Console.WriteLine(name + " ,even and less than 25.");

            }
            else if (odd_even == 0 && number <= 60)
            {

                string value = ($"value:{number}");
                Console.WriteLine(name + " ,even and between 26 and 60 inclusive.");

            }

            else if (odd_even == 0 && number > 60)
            {

                string value = ($"value:{number}");
                Console.WriteLine(name + " ,even and greater than 60.");

            }

            else if (odd_even != 0 && number > 60)
            {

                string value = ($"value:{number}");
                Console.WriteLine(name + ",odd and greater than 60.");

            }

            Console.WriteLine(name + ", if you want to stop type 'n' or press enter.");
             
        } while (Console.ReadLine() != "n");
        
     }
    }





















