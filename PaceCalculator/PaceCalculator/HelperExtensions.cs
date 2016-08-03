using System;

namespace PaceCalculator
{
    public static class HelperExtensions
    {
        public static double ToDistance(this string distance)
        {
            double distanceFromString;
            if(Double.TryParse(distance, out distanceFromString)){
                return distanceFromString;
            }
            throw new ArgumentException("Distance provided was not a valid double.","distance");
        }

        public static TimeSpan ToRequiredPace(this TimeSpan time, double distance)
        {
            double pace = 0;
            
            var totalSeconds = time.TotalSeconds;
            
            pace = (double) totalSeconds / distance;

            return TimeSpan.FromSeconds(pace);

        }
        public static TimeSpan ToTimeSpan(this string time)
        {
            TimeSpan timeParsed;
            if(TimeSpan.TryParse(time, out timeParsed))
            {
                return timeParsed;
            }
            throw new ArgumentException("Time was not in required format (hh:mm.ss).", "time");
        }

        public static string ToDistanceType(this string distanceType)
        {
            if(distanceType.StartsWith("m", StringComparison.OrdinalIgnoreCase) || distanceType.StartsWith("k",StringComparison.OrdinalIgnoreCase))
            {
                return distanceType.ToLower()[0] == 'm' ? "mile(s)" : "kilometer(s)";
            }
            throw new ArgumentException("Expected either m or k for miles or kilometers", "distanceType");
        }
    }
}