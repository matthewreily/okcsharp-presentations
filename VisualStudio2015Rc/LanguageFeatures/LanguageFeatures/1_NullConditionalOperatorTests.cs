using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LanguageFeatures
{
    [TestClass]
    public class NullConditionalOperatorTests
    {
        //Even the newest.NET developers are likely familiar with the NullReferenceException.
        //This is an exception that almost always indicates a bug because the developer didn’t 
        //perform sufficient null checking before invoking a member on a (null) object. Consider this example: 

        public static string Truncate(string value, int length)
        {
            string result = value;
            if (value != null) // Skip empty string check for elucidation
            {
                result = value.Substring(0, Math.Min(value.Length, length));
            }
            return result;
        }

        //If it wasn’t for the check for null, the method would throw a NullReferenceException. 
        //Although it’s simple, having to check the string parameter for null is somewhat verbose. 
        //Often, that verbose approach is likely unnecessary given the frequency of the comparison. 
        //C# 6.0 includes a new null-conditional operator that helps you write these checks more succinctly:
        public static string TruncateWithNullConditionalOperator(string value, int length)
        {
            return value?.Substring(0, Math.Min(value.Length, length));
        }
        [TestMethod]
        public void Truncate_WithNull_ReturnsNull()
        {
            Assert.AreEqual<string>(null, Truncate(null, 42));
        }
    }
