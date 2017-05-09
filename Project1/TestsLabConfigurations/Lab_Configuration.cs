using NUnit.Framework;
using System;
using System.Configuration;
using System.IO;
using Project1.Report;
using RelevantCodes.ExtentReports;
using Project1.GenericMethods;
using Project1.WrapperFactory;


namespace Project1.TestsLabConfigurations
{
    class Lab_Configuration
    {
        [OneTimeSetUp]
        public void OnTimeSetUp()
        {
            Random ran = new Random();
            string Report_Absolute_Path = ConfigurationManager.AppSettings["Report_Path"];
            string Report_FileName = ConfigurationManager.AppSettings["Report_File_Name"];

            Generic_Methods gm = new Generic_Methods();
            string ProjectPath = gm.Get_Relative_Project_Path();

            string Report_FullPath = ProjectPath + Report_Absolute_Path;

            if (!Directory.Exists(ProjectPath + Report_Absolute_Path))
                Directory.CreateDirectory(Report_FullPath);
            Report.ReportGenerator.Extent = new ExtentReports(Report_FullPath + Report_FileName + ran.Next() + ".html", false);
        }

        [SetUp]
        public void SetUp()
        {
            BrowserFactory.InitBrowser("Chrome");
            string WebURL = ConfigurationManager.AppSettings["URL"];
            BrowserFactory.LoadApplication(WebURL);
            //BrowserFactory.Driver.Manage().Window.Maximize();
            BrowserFactory.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(int.Parse(ConfigurationManager.AppSettings["Driver_Timeout"]));
            BrowserFactory.Driver.Manage().Cookies.DeleteAllCookies();
            BrowserFactory.Driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(int.Parse(ConfigurationManager.AppSettings["Driver_Set_Page_script_Timeout"]));
            BrowserFactory.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(int.Parse(ConfigurationManager.AppSettings["Driver_Set_Page_script_Timeout"]));
        }

        [TearDown]
        public void TearDown()
        {
            BrowserFactory.CloseAllDrivers();
        }


        [OneTimeTearDown]
        public void OnTimeTearDown()
        {
            string Env = ConfigurationManager.AppSettings["SystemInfo"];
            ReportGenerator.Extent.Flush();
            ReportGenerator.Extent.AddSystemInfo("Environment", Env);
            ReportGenerator.Extent.Close();
        }
    }
}
