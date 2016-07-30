using System;

namespace PaceCalculator
{
    public class App
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pace Calculator! Press ENTER to begin");
            Console.ReadLine();

            Console.WriteLine("Would you like to use miles(m) or kilometers(km)?");
            var distanceType = GetDistanceType(Console.ReadLine());
            
            Console.WriteLine("What distance would you like to use for the calculation?");
            var distance = Console.ReadLine();
            
            Console.WriteLine("What is your desired finishing time?\nUse hh:mm.ss format. ex 01:10.00 for 1 hour 10 minutes");
            var time = GetTime(Console.ReadLine());
            
            var pace = RequiredPaceCalculator(time, GetDistance(distance));
            Console.WriteLine($"Your required pace to run {distance} {distanceType} is {pace.ToString()} per {distanceType}");
        }

        public static string GetDistanceType(string distanceType)
        {
            if(distanceType.StartsWith("m", StringComparison.OrdinalIgnoreCase) || distanceType.StartsWith("k",StringComparison.OrdinalIgnoreCase))
            {
                return distanceType.ToLower()[0] == 'm' ? "mile(s)" : "kilometer(s)";
            }
            throw new ArgumentException("Expected either m or k for miles or kilometers", "distanceType");
        }
        public static double GetDistance(string distance)
        {
            double distanceFromString;
            if(Double.TryParse(distance, out distanceFromString)){
                return distanceFromString;
            }
            throw new ArgumentException("Distance provided was not a valid double.","distance");
        }

        public static TimeSpan RequiredPaceCalculator(TimeSpan time, double distance)
        {
            double pace = 0;
            
            var totalSeconds = time.TotalSeconds;
            
            pace = (double) totalSeconds / distance;

            return TimeSpan.FromSeconds(pace);

        }
        public static TimeSpan GetTime(string time)
        {
            TimeSpan timeParsed;
            if(TimeSpan.TryParse(time, out timeParsed))
            {
                return timeParsed;
            }
            throw new ArgumentException("Time was not in required format (hh:mm.ss).", "time");
        }
    }
}
