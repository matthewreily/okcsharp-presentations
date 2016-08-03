using System;

namespace PaceCalculator
{
    public class App
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pace Calculator! Press ENTER to begin.");
            Console.ReadLine();

            Console.WriteLine("Would you like to use miles(m) or kilometers(km)?");
            var distanceType = Console.ReadLine().ToDistanceType();
            
            Console.WriteLine("What distance would you like to use for the calculation?");
            var distance = Console.ReadLine();
            
            Console.WriteLine("What is your desired finishing time?\nUse hh:mm.ss format. ex 01:10:00 for 1 hour 10 minutes");
            var time = Console.ReadLine().ToTimeSpan();
            
            var pace = time.ToRequiredPace(distance.ToDistance());
            Console.WriteLine($"Your required pace to run {distance} {distanceType} is {pace.ToString()} per {distanceType}");
        }
    }
}
