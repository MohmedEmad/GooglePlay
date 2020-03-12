using GooglePlay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GooglePlay_Test;

namespace Start
{
    class Program:BaseTest
    {
        static void Main(string[] args)
        {
            Driver.Initialize();
            SearchApps.SelectApps();
            SearchApps.AssertSelectApps();
            SearchApps.OpenEducation();
            SearchApps.AssertOpenEducation();
            SearchApps.ClickOnTED();
            SearchApps.AssertOpenTED();
            Driver.Instance.Close();
            
            
            Driver.Initialize();
            SearchApps.SearchForFB();
            SearchApps.AssertSearchForFB();
            Driver.Instance.Close();
            
        }
    }
}
