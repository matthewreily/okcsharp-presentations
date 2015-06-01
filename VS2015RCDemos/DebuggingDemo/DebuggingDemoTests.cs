using System.Linq;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DebuggingDemo
{
    [TestClass]
    public class DebuggingDemoTests
    {
        [TestMethod]
        public void LamdaExample()
        {
            IEnumerable<Person> people = new List<Person>()
            {
                new Person { Name ="Tom", Age = 22 },
                new Person {Name="Jane", Age = 42 }
            };

            Assert.IsNotNull(people);
        }

        [TestMethod]
        public void PerfTipsExample()
        {
            var person = new Person { Name = "Matt" };
            person.GoToSleep();
            Assert.IsTrue(person.IsAwake);
        }
    }
    public class Person
    {
        public int Age { get; internal set; }
        public bool IsAwake { get; internal set; }
        public string Name { get; set; }

        internal void GoToSleep()
        {
            Thread.Sleep(2 * 1000);
            IsAwake = true;
        }
    }
}
