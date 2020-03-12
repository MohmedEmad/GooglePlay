using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Linq.Expressions;
using System.IO;


namespace GooglePlay
{
    public class SearchApps
    {
        public static void SelectApps()
        {                        
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='wrapper']/div[1]/div/ul/li[2]/a/span/span[2]")));
            Driver.Instance.FindElement(By.XPath("//*[@id='wrapper']/div[1]/div/ul/li[2]/a/span/span[2]")).Click();            
        }
        
        public static bool AssertSelectApps()
        {
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='wrapper']/div[1]/div/ul/li[1]/ul/li[1]/a")));
            string Title = Driver.Instance.FindElement(By.XPath("//*[@id='wrapper']/div[1]/div/ul/li[1]/ul/li[1]/a")).Text;
            if (Title == "My apps")
                return true;
            else
                return false;
        }
        
        public static void OpenEducation()
        {
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("action-dropdown-parent-Categories")));
            Driver.Instance.FindElement(By.Id("action-dropdown-parent-Categories")).Click();
            Driver.Instance.FindElement(By.LinkText("Education")).Click();            
        }

        public static bool AssertOpenEducation()
        {
           var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
           wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='action-dropdown-parent-Education']/span[1]")));
           string PageTitle= Driver.Instance.FindElement(By.XPath("//*[@id='action-dropdown-parent-Education']/span[1]")).Text;
           if (PageTitle == "Education")
                return true;
        else
               return false;
    }
        
        public static void ClickOnTED()
        {            
            Driver.Instance.FindElement(By.LinkText("TED")).Click();            
        }

        public static bool AssertOpenTED()
        {
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='body-content']/div[2]/div/div[1]/div[1]/div/div[1]/div/div[2]/h1/div")));
            string IconName = Driver.Instance.FindElement(By.XPath("//*[@id='body-content']/div[2]/div/div[1]/div[1]/div/div[1]/div/div[2]/h1/div")).Text;
            if (IconName == "TED")
                return true;
            else
                return false;
        }    
      
        public static void SearchForFB()
        {
            Driver.Instance.FindElement(By.Id("gbqfq")).SendKeys("Facebook");
            Driver.Instance.FindElement(By.XPath("//*[@id='gbqfb']/span")).Click();            
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Facebook")));
            Driver.Instance.FindElement(By.LinkText("Facebook")).Click();            
        }

        public static bool AssertSearchForFB()
        {
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='body-content']/div[2]/div/div[1]/div[1]/div/div[1]/div/div[2]/h1/div")));
            string AppName = Driver.Instance.FindElement(By.XPath("//*[@id='body-content']/div[2]/div/div[1]/div[1]/div/div[1]/div/div[2]/h1/div")).Text;                                                                   
          if (AppName == "Facebook")
              return true;
          else
              return false;
        }        
    }
}
