using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.WaitingMethods
{
    class WaitSync
    {
        protected Func<IWebElement, bool> Wait_For_Element_IsDisplay = new Func<IWebElement, bool>((IWebElement ele) =>
        {
            try
            {
                bool ele_IsDisplay = ele.Displayed;
                if (ele_IsDisplay)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        });

        public bool WaitForElement(IWebElement element, int seconds)
        {
            DefaultWait<IWebElement> Waiter = new DefaultWait<IWebElement>(element)
            {
                Timeout = TimeSpan.FromSeconds(seconds),
                PollingInterval = TimeSpan.FromMilliseconds(250)
            };
            try
            {
                Waiter.Until(Wait_For_Element_IsDisplay);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void WaitFor_PageLoad(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }

        public bool WaitFor_PageUrl(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            try
            {
                wait.Until(d => d.Url.Contains("Edit"));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
