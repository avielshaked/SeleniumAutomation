using NUnit.Framework;
using Project1.PageObjectFactory;
using Project1.Report;
using System;

namespace Project1.TestCases
{
    [TestFixture]
    class TestCases_Lab
    {
        public int lineFailure;

        [Test]
        public void Login_Migdal()
        {
            ReportGenerator.Test = ReportGenerator.Extent.StartTest("Login_Migdal", "Test the login to migdal site");
            Console.WriteLine("Test RunTime :{0}", DateTime.Now);
            PageGenerator.LoginPage.LoginFLow();

        }

        [Test]
        public void ContactPage_With_UploadFile()
        {
            ReportGenerator.Test = ReportGenerator.Extent.StartTest("ContactPage_With_UploadFile", "upload file and send details to contact");
            Console.WriteLine("Test RunTime :{0}", DateTime.Now);
            PageGenerator.LoginPage.Navigate_To_Contact_Page();
            PageGenerator.ContactPage_pof.Contact_With_UploadFile_Flow();
        }

        [Test]
        public void FindAgent()
        {
            ReportGenerator.Test = ReportGenerator.Extent.StartTest("Find agent", "check find agent component");
            Console.WriteLine("Test RunTime :{0}", DateTime.Now);
            PageGenerator.FindAgent_pof.GetAgentResault();
        }

        public int ReciveLineFailure(int lineNum)
        {
            lineFailure = lineNum;
            return lineFailure;
        }
    }
}
