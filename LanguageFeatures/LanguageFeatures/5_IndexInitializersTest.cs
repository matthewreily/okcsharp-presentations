using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LanguageFeatures
{

    [TestClass]
    public class IndexInitializersTest
    {
        public Dictionary<int, string> MyDictionary { get; } = new Dictionary<int, string>
        {
            [1] = "Hello"
        };

        [TestMethod]
        public void Get_Index_Value()
        {
            Assert.AreEqual("Hello", MyDictionary[1]);
        }
    }
}
