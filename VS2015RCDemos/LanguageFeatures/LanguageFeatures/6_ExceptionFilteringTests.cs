using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LanguageFeatures
{

    public class ExceptionFilteringTests
    {
        [TestMethod]
        [ExpectedException(typeof(Win32Exception))]
        public void ExceptionFilter_DontCatchAsNativeErrorCodeIsNot42()
        {
            try
            {
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }
            catch (Win32Exception exception) when (exception.NativeErrorCode == 0x00042)
            {
                // Only provided for elucidation (not required).
                Assert.Fail("No catch expected.");
            }
        }
    }
}
