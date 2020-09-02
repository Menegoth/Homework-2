/// Week No. 2	Homework No. 2
/// File Name: Program.cs
/// @author: Antonio Monteiro
/// Date:  September 1st, 2020

using System;
using System.Reflection;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            //declare variables
            double degreesF, degreesC;

            //ask user for Farenhenti
            Console.WriteLine("Enter a temperature in Farenheit: ");
            degreesF = double.Parse(Console.ReadLine());

            //convert and round to one decimal point
            degreesC = 5 * (degreesF - 32) / 9;
            degreesC = Math.Round(degreesC, 1);

            //inform the user
            Console.WriteLine(degreesC);

            //pause console
            Console.ReadLine();

        }
    }
}
