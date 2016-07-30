using System;
using PaceCalculator;
using Xunit;
namespace ConsoleApplication
{
    public class PaceCalculatorTests
    {
        [Fact]
        public void CanGetTimespanForValidEntry()
        {
           var time = "03:00:00";
           var timeSpan = PaceCalculator.App.GetTime(time); 
        }
    }
}
