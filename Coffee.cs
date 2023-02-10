using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtDC_Examples
{
    public class Coffee
    {
        private string kind;
        private float price;
        private float weight;

        public Coffee(string kind, float price, float weight)
        {
            this.kind = kind;
            this.price = price;
            this.weight = weight;

            Console.WriteLine("Coffee: " + kind + " $" + price + " " + weight + "lbs");
        }
    }

    public class CoffeeExamples
    {
        public Coffee kona = new Coffee("Kona", 20.95f, 10.0f);
        public Coffee ethi = new Coffee("Ethiopian", 8.00f, 100.0f);
        public Coffee colo = new Coffee("Columbian", 9.50f, 2.0f);

        public CoffeeExamples()
        {
            Console.ReadLine();
        }
    }
}
