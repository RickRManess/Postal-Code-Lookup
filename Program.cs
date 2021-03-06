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
            //Introduction Text
            Console.WriteLine("Enter any zip code in the United States");
            Console.WriteLine();
            // var zipCode = (Console.ReadLine());
            Console.WriteLine("Location information below:");


            //variable created to read postal code text file
            var myLines = File.ReadLines(@"../../../USZipCodes.txt");
            var zipList = new List<zipCodeInfo>();


            //foreach loop to split each line into parts 
            foreach (string line in myLines)
            {
                try
                {
                    string[] part = line.Split("\t");
                    var locationData = new zipCodeInfo();
                    locationData.CountryCode = part[0];
                    locationData.PostalCode = Int32.Parse(part[1]);
                    locationData.PlaceName = part[2];
                    locationData.AdminNameOne = part[3];
                    locationData.AdminCodeOne = (part[4]);
                    locationData.AdminNameTwo = part[5];
                    locationData.AdminCodeTwo = (part[6]);
                    locationData.AdminNameThree = part[7];
                    locationData.AdminCodeThree = (part[8]);
                    locationData.Latitude = float.Parse(part[9]);
                    locationData.Longitude = float.Parse(part[10]);
                   // locationData.Accuracy = Int32.Parse(part[11]);
                    Int32.TryParse(part[11], out locationData.Accuracy);

                    zipList.Add(locationData);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Malformed Input Info:" + e.Message);
                }

            }

        }

    }
}



