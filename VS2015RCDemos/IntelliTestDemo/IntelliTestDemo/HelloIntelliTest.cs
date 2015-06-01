using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace IntelliTestDemo
{
    [TestClass]
    public class HelloIntelliTest
    {
        public string GetHelloWorld(Message message)
        {
            return $"Thank you {message.Salutation}. Here is your Message {message.WelcomMessage}";
        }

        public List<int> BubbleSort(List<int> a)
        {
            int temp;
            for (int i = 1; i <= a.Count; i++)
            {

                for (int j = 0; j < a.Count - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            return a;
        }

        //Show conditional break points
        [TestMethod]
        public void BubbleSortTest()
        {
            var results = BubbleSort(new List<int> { 1, 5, 7, 2 });
            var expected = new List<int> { 1, 2, 5, 7 };
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], results[i]);
            } 
        }

    }
}
