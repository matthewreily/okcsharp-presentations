using System;
using Xunit;

namespace PaceCalculator.Tests
{
    public class AppTests
    {
        [Fact]
        public void CanGetTimespanForValidEntry()
        {
           var time = "03:00:00";
           var timeSpan = time.ToTimeSpan();
           Assert.Equal(3 * 60 * 60, timeSpan.TotalSeconds); 
        }
        [Fact]
        public void ThrowsArguementExceptionForUnexpectedValue()
        {
            var time = "3.3.3";
            Assert.Throws<ArgumentException>(()=> time.ToTimeSpan());
        } 
    }
}

