using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Project1.GenericMethods;
using Project1.Report;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project1.PageObjectFactory
{
    class Login_POF : PageGenerator
    {
        int LineFailure;
        #region Properties
        [FindsBy(How = How.ClassName, Using = "UserLoginKey")]
        private IWebElement LoginBtn { get; set; }

        [FindsBy(How = How.ClassName, Using = "UserRegHeaderBG")]
        private IWebElement LoginPopup_Title { get; set; }

        [FindsBy(How = How.ClassName, Using = "ngdialog-close")]
        private IWebElement LoginPopup_X { get; set; }

        [FindsBy(How = How.ClassName, Using = "link_UnderLineLogin")]
        private IWebElement ID_Pass_Enter_Text { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ngdialog2']/div[2]/div[4]/ng-form/div/div/div[8]/span")]
        private IWebElement ID_Phone_Enter_Text { get; set; }

        [FindsBy(How = How.Name, Using = "TxtID")]
        private IWebElement ID_InputField { get; set; }

        [FindsBy(How = How.Name, Using = "LoginPassword")]
        private IWebElement Pass_InputField { get; set; }

        [FindsBy(How = How.ClassName, Using = "UserRegSubmitBG")]
        private IWebElement LoginSubmit { get; set; }

        [FindsBy(How = How.ClassName, Using = "validationMessages")]
        private IWebElement ID_Validation_Msg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ngdialog2']/div[2]/div[4]/ng-form/div/div/div[2]/div[3]")]
        private IWebElement Id_InvalidMsg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ngdialog2']/div[2]/div[4]/ng-form/div/div/div[3]/div[3]")]
        private IWebElement Pass_EmptyValue_Msg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ngdialog2']/div[2]/div[4]/ng-form/div/div/div[3]/div[4]")]
        private IWebElement WrongPass_Msg { get; set; }

        [FindsBy(How = How.ClassName, Using = "LoginNewUserData")]
        private IWebElement ID_Pass_Indicate_After_Login { get; set; }

        [FindsBy(How = How.LinkText, Using = "צור קשר")]
        private IWebElement ContactLink { get; set; }
        #endregion

        public void LoginFLow()
        {
            Wait_Methods Wm = new Wait_Methods();
            WebDriverWait wait = Wm.GetWebDriverWait(TimeSpan.FromSeconds(60), Driver);

            //click on login 
            LoginBtn.Click();
            Thread.Sleep(2000);
            //check if the login popup title is present
            Assert.True(LoginPopup_Title.Displayed);

            //close login popup
            this.LoginPopup_X.Click();
            Thread.Sleep(2000);

            //click again on login 
            LoginBtn.Click();
            Thread.Sleep(2000);
            //check the text is correct and click on enter with password link          
            Assert.AreEqual("לכניסה עם ת.ז. + סיסמה", ID_Pass_Enter_Text.Text, "the link text for enter with password is not correct");
            ID_Pass_Enter_Text.Click();
            Thread.Sleep(3000);
            //check if the link text is changed
            Assert.AreEqual("לכניסה עם ת.ז. + טלפון/מייל", this.ID_Phone_Enter_Text.Text, "the link text for enter with mail/phone is not correct");
            //locate id + Pass - Attribute value        
            string ID_InputField_Value = ID_InputField.GetAttribute("placeholder");
            string Pass_InputField_Value = Pass_InputField.GetAttribute("placeholder");

            try
            {
                //check validation on ID field 
                Assert.AreEqual("ת.ז 9 ספרות כולל ספרת ביקורת", ID_InputField_Value, "there's no defualt value inside the id field");
                LoginSubmit.Click();
                Assert.True(ID_Validation_Msg.Displayed, "invalid message for id input value is not present");
                ID_InputField.SendKeys("asdfg");
                ID_InputField_Value = ID_InputField.GetAttribute("value");
                Assert.LessOrEqual(ID_InputField_Value.Length, 0, "the id input field accept letters");
                ID_InputField.Clear();
                ID_InputField.SendKeys("שדגדגד");
                ID_InputField_Value = ID_InputField.GetAttribute("value");
                Assert.LessOrEqual(ID_InputField_Value.Length, 0, "the id input field accept letters");
                ID_InputField.Clear();
                ID_InputField.SendKeys("!#!##$#");
                ID_InputField_Value = ID_InputField.GetAttribute("value");
                Assert.LessOrEqual(ID_InputField_Value.Length, 0, "the id input field accept chars");
                ID_InputField.Clear();
                ID_InputField.SendKeys("123 4");
                ID_InputField_Value = ID_InputField.GetAttribute("value");
                Assert.LessOrEqual(ID_InputField_Value.Length, 4, "the id input field accept spacing");
                ID_InputField.Clear();
                ID_InputField.SendKeys("1234567890");
                ID_InputField_Value = ID_InputField.GetAttribute("value");
                Assert.LessOrEqual(ID_InputField_Value.Length, 9, "the id input field accept more than 9 digits");
                this.LoginSubmit.Click();
                Assert.AreEqual("מס' ת.ז אינו תקין", Id_InvalidMsg.Text, "the message for incorrect id is not shown / in the right text");
                ID_InputField.Clear();
                ID_InputField.SendKeys(GetXmlOneValue("ID"));
                Thread.Sleep(2000);
                Assert.True(!Id_InvalidMsg.Displayed, "with valid id the message for validation is still shown");
                ReportGenerator.Test.Log(LogStatus.Pass, "check validation on id field ");
            }
            catch (Exception e)
            {
                LineFailure = GetLineNumber_Fail(e);
                Console.WriteLine("fail in line {0}", LineFailure);
                //ReportGenerator.Test.Log(LogStatus.Fail, e + "     " + ReportGenerator.Test.AddScreenCapture(TakeScreenShot("ID-Input-Field", Driver)));
                ReportGenerator.Extent.EndTest(ReportGenerator.Test);
                throw e;
            }

            try
            {
                //check validation on password field 
                Assert.AreEqual("סיסמה", Pass_InputField_Value, "there's no defualt value inside the id field");
                this.LoginSubmit.Click();
                Assert.AreEqual("יש להזין סיסמה", Driver.FindElement(By.XPath("//*[@id='ngdialog2']/div[2]/div[4]/ng-form/div/div/div[3]/div[3]")).Text, "validation message for empty value in password field is not correct");
                Assert.True(Pass_EmptyValue_Msg.Displayed);
                Pass_InputField.SendKeys("123456789012");
                Pass_InputField_Value = Pass_InputField.GetAttribute("value");
                Assert.LessOrEqual(Pass_InputField_Value.Length, 12, "password field accept more than 12 chars");
                Pass_InputField.Clear();
                ReportGenerator.Test.Log(LogStatus.Pass, "check validation on password  field ");
            }
            catch (Exception e)
            {
                LineFailure = GetLineNumber_Fail(e);
                Console.WriteLine("fail in line {0}", LineFailure);
                ReportGenerator.Test.Log(LogStatus.Fail, e + "     " + ReportGenerator.Test.AddScreenCapture(TakeScreenShot("ID-Input-Field", Driver)));
                ReportGenerator.Extent.EndTest(ReportGenerator.Test);
                throw e;
            }

            try
            {
                //login attemp with id and password do not matched
                ID_InputField.Clear();
                ID_InputField.SendKeys(GetXmlOneValue("ID"));
                Pass_InputField.SendKeys("AZ123Q");
                this.LoginSubmit.Click();
                Assert.AreEqual("הסיסמה שהוזנה שגויה", wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ngdialog2']/div[2]/div[4]/ng-form/div/div/div[3]/div[4]"))).Text, "invalid message is not present/not correct");
                Assert.True(WrongPass_Msg.Displayed, "text of error message for incorrect password is not displayed");
                ReportGenerator.Test.Log(LogStatus.Pass, "try to login attemp with id and password do not  matched");

                //login attemp with id and password are match             
                ID_InputField.Clear();
                Pass_InputField.Clear();
                ID_InputField.SendKeys(GetXmlOneValue("ID"));
                Pass_InputField.SendKeys(GetXmlOneValue("Password"));
                this.LoginSubmit.Click();
                ReportGenerator.Test.Log(LogStatus.Pass, "try to login attemp with id and password are matched");
            }
            catch (Exception e)
            {
                LineFailure = GetLineNumber_Fail(e);
                Console.WriteLine("fail in line {0}", LineFailure);
                ReportGenerator.Test.Log(LogStatus.Fail, e + "     " + ReportGenerator.Test.AddScreenCapture(TakeScreenShot("LoginAttemp_NotMatch_IDpassword", Driver)));
                ReportGenerator.Extent.EndTest(ReportGenerator.Test);
                throw e;
            }

            //locate id and user name indicate after login
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("LoginNewUserData")));
                Assert.True(ID_Pass_Indicate_After_Login.Displayed, "user and id is not present after login");

                //get data collection tab title page                      
                string Tab_Title_dataC_InPersonalInfo = Driver.Title;
                Assert.True(Tab_Title_dataC_InPersonalInfo.Contains("ריכוז נתונים"), "there is error in the tab title afte login");
                ReportGenerator.Test.Log(LogStatus.Pass, "locate id and user name indicate after login");
            }
            catch (Exception e)
            {
                LineFailure = GetLineNumber_Fail(e);
                Console.WriteLine("fail in line {0}", LineFailure);
                ReportGenerator.Test.Log(LogStatus.Fail, "locate id and user name indicate after login" + e + "     " + ReportGenerator.Test.AddScreenCapture(TakeScreenShot("after_login", Driver)));
                throw e;
            }
            finally
            {
                ReportGenerator.Extent.EndTest(ReportGenerator.Test);
            }
        }

        public void Navigate_To_Contact_Page()
        {
            PageGenerator.LoadApplication(ConfigurationManager.AppSettings["ContactPageURL"]);
        }

        public void LoginAction(string id, string pass)
        {
            LoginBtn.Click();
            ID_Pass_Enter_Text.Click();
            ID_InputField.SendKeys(id);
            Pass_InputField.SendKeys(pass);
            LoginSubmit.Click();
        }
    }
}
