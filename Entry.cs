using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HtDC_Examples
{
    public class Entry
    {
        public Date date;
        public float distance;
        public int duration;
        public string comment;

        public Entry(Date date, float distance, int duration, string comment)
        {
            this.date = date;
            this.distance = distance;
            this.duration = duration;
            this.comment = comment;

            Console.WriteLine(date + " | " + distance + " | " + duration + " | " + comment);
        }
    }
}
