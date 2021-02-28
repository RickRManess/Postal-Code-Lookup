using System;
using System.IO;
using System.Linq;

namespace Postal_Code_Lookup
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable created to read postal code text file
            var myLines = File.ReadLines(@"C:\Users\rrman\Documents\USN.txt");

            //Introduction Text
            Console.WriteLine("Please enter zip code");
            var zipCode = (Console.ReadLine());

            //foreach loop to find zipcode and return line
            foreach (var line in myLines)
            {
                if (line.Contains(zipCode))
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
