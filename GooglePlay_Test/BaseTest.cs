using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GooglePlay;

namespace GooglePlay_Test
{
    [TestClass]
    public class BaseTest
    {
        [TestInitialize]
        public void TestMethod1()
        {
            Driver.Initialize();
            Driver.OpenGooglePlayWebsite();            
        }

        [TestCleanup]
        public void CloseBrowser()
        {
        Driver.Instance.Close();
        }
    }
}
