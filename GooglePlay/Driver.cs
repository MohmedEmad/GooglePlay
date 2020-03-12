using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System.Linq.Expressions;
using System.IO;
using System.Configuration;
using System.Reflection;

namespace GooglePlay
{
    public class Driver
    {
        public static ChromeDriver Instance;

        public static void Initialize()
        {            
            string driverFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\chromedriver";            

            OpenQA.Selenium.Chrome.ChromeOptions chromeoptions = new OpenQA.Selenium.Chrome.ChromeOptions();
            chromeoptions.AddArgument("--start-maximized");
            Instance = new OpenQA.Selenium.Chrome.ChromeDriver(driverFolder, chromeoptions);
            Instance.Navigate().GoToUrl("https://play.google.com/store?hl=en");
        }
        public static void OpenGooglePlayWebsite()
        {
            string url = ConfigurationManager.AppSettings["testUrl"];            
        }

    }
}
