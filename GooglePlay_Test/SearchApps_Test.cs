using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GooglePlay;

namespace GooglePlay_Test
{
    [TestClass]
    public class SearchApps_Test:BaseTest
    {
        [TestMethod]
        public void SelectApps_Test()
        {
            SearchApps.SelectApps();
            Assert.IsTrue(SearchApps.AssertSelectApps());
            SearchApps.OpenEducation();
            Assert.IsTrue(SearchApps.AssertOpenEducation());
            SearchApps.ClickOnTED();
            Assert.IsTrue(SearchApps.AssertOpenTED());
        }
        [TestMethod]
        public void SearchForFB_Test()
        {
            SearchApps.SearchForFB();
            Assert.IsTrue(SearchApps.AssertSearchForFB());
        }
    }
}
