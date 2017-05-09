using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using System.IO;
using System.Configuration;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Reflection;

namespace Project1.GenericMethods
{
    public class Generic_Methods : Wait_Methods
    {
        public string TakeScreenShot(string PicName, IWebDriver driver)
        {
            string ScreenShots_AbsolutePath = ConfigurationManager.AppSettings["ScreenShots_Path"];
            string ScreenShots_RelativePath = Get_Relative_Project_Path();

            string ScreenShots_FullPath = ScreenShots_RelativePath + ScreenShots_AbsolutePath;

            if (!Directory.Exists(ScreenShots_FullPath))
                Directory.CreateDirectory(ScreenShots_FullPath);

            Random ran = new Random();
            string ImagePath = ScreenShots_FullPath + "\\" + PicName + ran.Next() +".jpg";
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(ImagePath, ScreenshotImageFormat.Jpeg);
            return ImagePath;
        }

        public Func<IWebDriver,IList<IWebElement>> GetAllElements(By locator)
        {
            return ((x) =>
            {
                return x.FindElements(locator);
            });
        }

        public delegate bool PointToCheckIfElementPresentMethod(IWebElement element);
        public bool IsElementPresent(IWebElement element)
        {
            if (element.Displayed == true)
                return true;
            else
                return false;
        }

        public bool ElementListIsPresent(IList<IWebElement> elementlist,PointToCheckIfElementPresentMethod ispresent)
        {
            foreach(IWebElement e in elementlist)
            {
                if (ispresent(e))
                    return true;
            }
            return false;
        }

        public bool VerifyElementIsNotPresent(IWebDriver driver, By locatorKey)
        {
            try
            {
                driver.FindElement(locatorKey);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int GetLineNumber_Fail(Exception e)
        {
            var st = new StackTrace(e, true);
            var frame = st.GetFrame(st.FrameCount - 1);
            var line = frame.GetFileLineNumber();
            return line;
        }

        public string Get_Relative_Project_Path()
        {
            string Rpath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            int count = 1;
            while(!File.Exists(Rpath+ "SeleniumAuto"))
            {
                switch (count)
                {
                    case 1:
                        Rpath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\"));
                        count++;
                        break;
                    case 2:
                        Rpath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\"));
                        count++;
                        break;
                    case 3:
                        Rpath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\"));
                        count++;
                        break;
                    case 4:
                        Rpath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\..\\"));
                        count++;
                        break;
                }
            }
            return Rpath;
        }

        public string returnLast_FileName(out DateTime value)
        {
            var files = new DirectoryInfo(BrowserFactory.directory).GetFiles("*.pdf");
            string LatestFile = null;
            DateTime LastUpdate = DateTime.MinValue;
            foreach (FileInfo file in files)
            {
                if (file.LastWriteTime > LastUpdate)
                {
                    LastUpdate = file.LastWriteTime;
                    LatestFile = file.Name;
                }
            }
            value = LastUpdate;
            return LatestFile;
        }

    }
}
