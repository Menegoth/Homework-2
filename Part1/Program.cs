/// Week No. 2	Homework No. 1
/// File Name: Program.cs
/// @author: Antonio Monteiro
/// Date:  September 1st, 2020

using System;
using System.Linq;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {

            //declare variables
            string firstLetter;
            string fullName;

            //declare string variables
            string pigLatin = "ay";
            string first = "antonio";
            string last = "monteiro";

            //fix first name
            //start with getting firstletter
            firstLetter = first.Substring(0, 1);

            //remove first letter from name and add it to the end
            first = first.Substring(1);
            first = first + firstLetter + pigLatin;

            //capitalize it
            first = first.Substring(0, 1).ToUpper() + first.Substring(1);

            //do the same for last name
            //start with getting firstletter
            firstLetter = last.Substring(0, 1);

            //remove first letter from name and add it to the end
            last = last.Substring(1);
            last = last + firstLetter + pigLatin;

            //capitalize it
            last = last.Substring(0, 1).ToUpper() + last.Substring(1);

            //combine both names
            fullName = first + " " + last;
            Console.WriteLine(fullName);

            //pause console
            Console.ReadLine();

        }
    }
}
