using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtDC_Examples
{
    public class House
    {
        public string kind;
        public int numberOfRooms;
        public Address address;
        public double price;

        public House(string kind, int numberOfRooms, Address address, double price)
        {
            this.kind = kind;
            this.numberOfRooms = numberOfRooms;
            this.address = address;
            this.price = price;
        }
    }

    public class Address
    {
        public int streetNumber;
        public string streetName;
        public string city;

        public Address(int streetNumber, string streetName, string city)
        {
            this.streetNumber = streetNumber;
            this.streetName = streetName;
            this.city = city;
        }
    }

    public class HouseExamples
    {
        public House house1;

        public HouseExamples()
        {
            Address address = new Address(34, "Louis Street", "Waltham");
            house1 = new House("Colonial", 4, address, 450000);

            var kind = house1.kind;
            var rooms = house1.numberOfRooms;
            var streetNum = house1.address.streetNumber;
            var streetName = house1.address.streetName;
            var city = house1.address.city;
            var price = house1.price;

            Console.WriteLine($"Kind: {kind} | Number of Rooms: {rooms} | " +
                $" Address: {streetNum} {streetName} {city} | Price: ${price}");
        }
    }
}
