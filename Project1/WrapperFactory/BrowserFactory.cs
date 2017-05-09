using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.IO;
using Project1.GenericMethods;


namespace Project1.WrapperFactory
{
    public class BrowserFactory :  XmlMethods
    {
        internal static string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        internal static string directory = Path.Combine(userProfile, "Downloads");

        static readonly IDictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();
        static IWebDriver _driver;

        public static IWebDriver Driver
        {
            get
            {
                return _driver;
            }
            private set
            {
                _driver = value;
            }
        }

        public static void InitBrowser(string browserName)
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("download.default_directory", directory);
            switch (browserName)
            {
                case "IE":
                    if (Driver == null)
                    {
                        _driver = new InternetExplorerDriver();
                        Drivers.Add("IE", Driver);
                    }
                    break;
                case "Chrome":
                    if (Driver == null)
                    {
                        _driver = new ChromeDriver(chromeOptions);
                        Drivers.Add("Chrome", Driver);
                    }
                    break;
            }
        }

        public static void LoadApplication(string Url)
        {
            Driver.Url = Url;
        }

        public static void CloseAllDrivers()
        {
            foreach (var key in Drivers.Keys)
            {
                Drivers[key].Close();
                Drivers[key].Quit();
            }
            _driver = null;
            Drivers.Remove("Chrome");
        }
    }
}
