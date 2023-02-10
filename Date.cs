using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtDC_Examples
{
    public class Date
    {
        public int day;
        public int month;
        public int year;

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;

            Console.WriteLine(day + " " + month + " " + year);
        }
    }
}
