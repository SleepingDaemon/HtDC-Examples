using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtDC_Examples
{
    public class GPSLocation
    {
        double latitude;
        double longitude;

        public GPSLocation(double latitude, double longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;

            Console.WriteLine(latitude+ "," + longitude);
        }
    }

    public class GPSLocationExamples
    {
        public GPSLocation coordinate1 = new GPSLocation(340, 504);
        public GPSLocation coordinate2 = new GPSLocation(42.34, 71.09);

        public GPSLocationExamples()
        {
            Console.ReadLine();
        }
    }
}
