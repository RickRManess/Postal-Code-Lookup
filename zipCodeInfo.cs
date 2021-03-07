using System;
using System.Collections.Generic;
using System.Text;

namespace Postal_Code_Lookup
{
    class ZipCodeInfo
    {

        public string CountryCode;
        public int PostalCode;
        public string PlaceName;
        public string AdminNameOne;
        public string AdminCodeOne;
        public string AdminNameTwo;
        public string AdminCodeTwo;
        public string AdminNameThree;
        public string AdminCodeThree;
        public float Latitude;
        public float Longitude;
        public int Accuracy;

        public override string ToString()
        {
            return $"{PostalCode} - {PlaceName}";
        }

    }


}




