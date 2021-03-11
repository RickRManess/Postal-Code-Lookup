using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Postal_Code_Lookup
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Initializing variable outside of try catch loop
            int zipCodeToLookup = 0;

            do
            {
                try
                {
                    //Function for introduction text 
                    Console.Clear();
                    DisplayWelcomeScreen();
                    //User input for zipcodelookup 
                    zipCodeToLookup = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Location information below:");
                }
                catch (Exception zipError)
                {

                    Console.WriteLine("Invalid Format Try Again");
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {

                    }
                }
            }
            while (zipCodeToLookup == 0);

            //variable created to read postal code text file
            var myLines = File.ReadLines(@"../../../USZipCodes.txt");
            var zipList = new List<ZipCodeInfo>();


            //foreach loop to split each line into parts 
            foreach (string line in myLines)
            {
                try
                {
                    string[] part = line.Split("\t");
                    var locationData = new ZipCodeInfo();
                    locationData.CountryCode = part[0];
                    locationData.PostalCode = Int32.Parse(part[1]);
                    locationData.PlaceName = part[2];
                    locationData.AdminNameOne = part[3];
                    locationData.AdminCodeOne = part[4];
                    locationData.AdminNameTwo = part[5];
                    locationData.AdminCodeTwo = part[6];
                    locationData.AdminNameThree = part[7];
                    locationData.AdminCodeThree = part[8];
                    locationData.Latitude = float.Parse(part[9]);
                    locationData.Longitude = float.Parse(part[10]);
                    Int32.TryParse(part[11], out locationData.Accuracy);
                    zipList.Add(locationData);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Malformed Input Info:" + e.Message);
                }
            }

            //foreach loop to search for zipcode and return city and state
            foreach (ZipCodeInfo zI in zipList)
            {
                if (zipCodeToLookup == zI.PostalCode)
                {
                    Console.WriteLine("City: " + zI.PlaceName);
                    Console.WriteLine("State: " + zI.AdminNameOne);
                    break;
                }
            }

        }
        static void DisplayWelcomeScreen()
        {
            Console.WriteLine("Enter any zip code in the United States");
            Console.WriteLine();
        }

    }
}



