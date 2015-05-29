using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LanguageFeatures
{
    [TestClass]
    public class StringInterpolationTests
    {
        public class Person
        {
            public string FName { get; } = "Matthew";
            public string LName { get; } = "Reily";

        }
        public string GetGreeting(Person person)
        {
            return $"Hello {person.FName} {person.LName}";
        }
        [TestMethod]
        public void Get_Greeting_Equals()
        {
            var person = new Person();
            var greeting = string.Format("Hello {0} {1}", person.FName, person.LName);
            Assert.AreEqual(greeting, GetGreeting(person));
        }
    }
}
