using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtDC_Examples
{
    public class Train
    {
        public Schedule schedule;
        public Route route;
        public bool isLocal;

        public Train(Schedule schedule, Route route, bool isLocal)
        {
            this.schedule = schedule;
            this.route = route;
            this.isLocal = isLocal;

            Console.WriteLine(schedule.ToString() + " " + route.ToString() + " " + isLocal); ;
        }
    }

    public class Schedule
    {
        public ClockTime departureTime;
        public ClockTime arrivalTime;

        public Schedule(ClockTime departureTime, ClockTime arrivalTime)
        {
            this.departureTime = departureTime;
            this.arrivalTime = arrivalTime;
        }
    }

    public class ClockTime
    {
        public int hour;
        public int minute;

        public ClockTime(int hour, int minute)
        {
            this.hour = hour;
            this.minute = minute;
        }
    }

    public class Route
    {
        public string originDestination;
        public string destination;

        public Route(string originDestination, string destination)
        {
            this.originDestination = originDestination;
            this.destination = destination;
        }
    }

    public class TrainExamples
    {
        public TrainExamples()
        {
            Console.ReadLine();
        }

        public void Trains()
        {
            Route route1 = new Route("Boston", "New York");

            ClockTime clockTime1 = new ClockTime(23, 50);
            ClockTime clockTime2 = new ClockTime(12, 20);

            Schedule schedule1 = new Schedule(clockTime1, clockTime2);

            Train train1 = new Train(schedule1, route1, true);

        }
    }
}
