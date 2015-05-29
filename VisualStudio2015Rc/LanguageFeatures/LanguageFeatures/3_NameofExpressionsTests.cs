using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LanguageFeatures
{
    [TestClass]
    public class NameofExpressionsTests
    {
        //Another addition introduced in the CTP3 release is support for nameof expressions.
        //There are several occasions when you’ll need to use “magic strings” within your code.
        //Such “magic strings” are normal C# strings that map to program elements within your code. 
        //For example, when throwing an ArgumentNullException, you’d use a string for the name of the 
        //corresponding parameter that was invalid. Unfortunately, these magic strings had no compile time 
        //validation and any program element changes (such as renaming the parameter) wouldn’t 
        //automatically update the magic string, resulting in an inconsistency that was never caught by the compiler.

        //On other occasions, such as when raising OnPropertyChanged events, you can avoid the magic string via tree 
        //expression gymnastics that extract the name.It’s perhaps a little more irritating given the operation’s simplicity, 
        //which is just identifying the program element name. In both cases, the solution was less than ideal.
        //To address this idiosyncrasy, C# 6.0 provides access to a “program element” name, whether it’s a class name, 
        //method name, parameter name or particular attribute name (perhaps when using reflection).

        void ThrowArgumentNullException(string param1)
        {
            throw new ArgumentNullException("param1");
        }

        void ThrowArgumentNullExceptionUsingNameOf(string param1)
        {
            throw new ArgumentNullException(nameof(param1));
        }
        [TestMethod]
        public void NameOf_UsingNameofExpressionInArgumentNullException()
        {
            try
            {
                ThrowArgumentNullExceptionUsingNameOf("data");
                Assert.Fail("This code should not be reached");
            }
            catch (ArgumentNullException exception)
            {
                Assert.AreEqual<string>("param1", exception.ParamName);
            }
        }
        [TestClass]
        public class NameofTests
        {
            [TestMethod]
            public void Nameof_ExtractsName()
            {
                Assert.AreEqual<string>("NameofTests", nameof(NameofTests));

                Assert.AreEqual<string>("TestMethodAttribute",
                  nameof(TestMethodAttribute));

                Assert.AreEqual<string>("TestMethodAttribute",
                  nameof(
                   Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute));

                Assert.AreEqual<string>("Nameof_ExtractsName",
                  string.Format("{0}", nameof(Nameof_ExtractsName)));
            }
        }
    }
}
