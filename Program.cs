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
            Console.WriteLine("Enter any zip code in the United States");
            Console.WriteLine();
            var zipCode = (Console.ReadLine());
            Console.WriteLine("Location information below:");
             
            //initializing new instance of zipcodeinfo class 
            zipCodeInfo zip = new zipCodeInfo();

            //foreach loop to find zipcode and return line
            foreach (var line in myLines)
            {
                if (line.Contains(zipCode))
                {
                    string[] zipInfo = line.Split("\t");
                    foreach (var part in zipInfo)
                    {
                       
                    }
  
                    
                }
                        
            }


        }

    }
}
