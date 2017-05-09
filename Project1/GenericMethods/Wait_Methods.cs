using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;

namespace Project1.GenericMethods
{
    public class Wait_Methods
    {
        public static void WaitForElementVisible(By by, int TimeOutInSeconds, IWebDriver driver)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            try
            {
                var Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(TimeOutInSeconds));
                Wait.Until(ExpectedConditions.ElementIsVisible(by));
            }
            catch (Exception)
            {
                Console.WriteLine("time Elapsed:{0}", stopwatch.Elapsed.Seconds);
            }
        }

        public WebDriverWait GetWebDriverWait(TimeSpan timeout, IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, timeout)
            {
                PollingInterval = TimeSpan.FromMilliseconds(500),
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            return wait;
        }

        public bool CheckIfElementPresent(IWebElement elm, int time)
        {
            DefaultWait<IWebElement> waiter = new DefaultWait<IWebElement>(elm)
            {
                PollingInterval = TimeSpan.FromMilliseconds(250),
                Timeout = TimeSpan.FromSeconds(time)
            };
            try
            {
                waiter.Until(ElementPresernt);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        Func<IWebElement, bool> ElementPresernt = (IWebElement elm) =>
        {
            try
            {
                if (elm.Displayed)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        };

        public bool Wait_For_Next_Step(TimeSpan timeout, IWebDriver driver, string stepname)
        {
            WebDriverWait wait = new WebDriverWait(driver, timeout);
            wait.Until(d => d.Url.Contains(stepname));
            return true;
        }

        public void WaitForElement(IWebElement elm, TimeSpan time, IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, time)
            {
                PollingInterval = TimeSpan.FromMilliseconds(250),
                Message = "cannot find the element",
            };
            wait.Until(ExpectedConditions.ElementToBeClickable(elm));
        }
    }
}
