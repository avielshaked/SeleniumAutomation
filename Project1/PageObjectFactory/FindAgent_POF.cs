using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Project1.Report;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using System.Configuration;

namespace Project1.PageObjectFactory
{
    public class FindAgent_POF : PageGenerator
    {
        #region Properties/Fields

        private IList<IWebElement> _AgentsearchList;
        private IList<IWebElement> _AgencySearchList;
        private IList<IWebElement> _Table_Result_Values;
        int LineFailure;

        private IList<IWebElement> AgentsearchList
        {
            get
            {
                return _AgentsearchList = Driver.FindElements(By.CssSelector("body > div.ac_results > ul > li"));
            }
            set
            {
                _AgentsearchList = null;
            }
        }
        private IList<IWebElement> AgencySearchList
        {

            get { return _AgencySearchList = Driver.FindElements(By.XPath("//*[@id='ctl00_Html1']/body/div[3]/ul/li")); }
            set { _AgencySearchList = null; }
        }

        [FindsBy(How = How.Id, Using = "__tab_ctl00_Spwebpartmanager1_g_ae018e01_a0b9_4a6b_b00c_b725d038d57e_ctl00_tabContainer_tad4")]
        private IWebElement ExplainTab { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_Spwebpartmanager1_g_ae018e01_a0b9_4a6b_b00c_b725d038d57e_ctl00_tabContainer_tad4")]
        private IWebElement ExplainText { get; set; }

        [FindsBy(How = How.Id, Using = "__tab_ctl00_Spwebpartmanager1_g_ae018e01_a0b9_4a6b_b00c_b725d038d57e_ctl00_tabContainer_tab1")]
        private IWebElement OperationTab { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_Spwebpartmanager1_g_5d28ff10_d849_4334_986c_6cbf725eaae0")]
        private IWebElement ContactComponentCorrect { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_Spwebpartmanager1_g_ae018e01_a0b9_4a6b_b00c_b725d038d57e_ctl00_tabContainer_tab1_SearchAgentsOperation1_txtName")]
        private IWebElement AgentSearchField { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_Spwebpartmanager1_g_ae018e01_a0b9_4a6b_b00c_b725d038d57e_ctl00_tabContainer_tab1_SearchAgentsOperation1_txtAgencyName")]
        private IWebElement AgencySearchField { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_Spwebpartmanager1_g_ae018e01_a0b9_4a6b_b00c_b725d038d57e_ctl00_tabContainer_tab1_SearchAgentsOperation1_ddlErea")]
        private IWebElement _DropDownList { get; set; }
        private SelectElement DropDownList
        {
            get { return new SelectElement(_DropDownList); }
        }

        [FindsBy(How = How.Id, Using = "ctl00_Spwebpartmanager1_g_ae018e01_a0b9_4a6b_b00c_b725d038d57e_ctl00_tabContainer_tab1_SearchAgentsOperation1_imgSearch")]
        private IWebElement SearchBtn { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_Spwebpartmanager1_g_ae018e01_a0b9_4a6b_b00c_b725d038d57e_ctl00_tabContainer_tab1_SearchAgentsOperation1_TrNoData")]
        private IWebElement NoResult_Indicate { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_Spwebpartmanager1_g_ae018e01_a0b9_4a6b_b00c_b725d038d57e_ctl00_tabContainer_tab1_SearchAgentsOperation1_imgCleanView")]
        private IWebElement CleanBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ctl00_Spwebpartmanager1_g_ae018e01_a0b9_4a6b_b00c_b725d038d57e_ctl00_tabContainer_tab1_SearchAgentsOperation1_UpdatePanel1 > table > tbody > tr:nth-child(1) > td > table > tbody > tr:nth-child(1) > td > table > tbody > tr > td:nth-child(2)")]
        private IWebElement table_Result_title { get; set; }

        private IList<IWebElement> Table_Result_Values
        {
            get { return _Table_Result_Values = Driver.FindElements(By.Id("ctl00_Spwebpartmanager1_g_ae018e01_a0b9_4a6b_b00c_b725d038d57e_ctl00_tabContainer_tab1_SearchAgentsOperation1_UpdatePanel1")); }
            set { _Table_Result_Values = null; }
        }

        private IList<IWebElement> _ResultRows;
        private IList<IWebElement> ResultRows
        {
            get { return _ResultRows = Driver.FindElements(By.CssSelector("img[src*='/design/Images/_migdal/SearchIndex/plus.gif']")); }
            set { _ResultRows = null; }
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_Spwebpartmanager1_g_ae018e01_a0b9_4a6b_b00c_b725d038d57e_ctl00_tabContainer_tab1_SearchAgentsOperation1_UpdatePanel1']/table/tbody/tr[1]/td/table/tbody/tr[2]/td[2]")]
        private IWebElement AgentNameTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_Spwebpartmanager1_g_ae018e01_a0b9_4a6b_b00c_b725d038d57e_ctl00_tabContainer_tab1_SearchAgentsOperation1_UpdatePanel1']/table/tbody/tr[1]/td/table/tbody/tr[3]/td[2]")]
        private IWebElement AgentName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_Spwebpartmanager1_g_ae018e01_a0b9_4a6b_b00c_b725d038d57e_ctl00_tabContainer_tab1_SearchAgentsOperation1_UpdatePanel1']/table/tbody/tr[1]/td/table/tbody/tr[2]/td[3]")]
        private IWebElement AgencyNameTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_Spwebpartmanager1_g_ae018e01_a0b9_4a6b_b00c_b725d038d57e_ctl00_tabContainer_tab1_SearchAgentsOperation1_UpdatePanel1']/table/tbody/tr[1]/td/table/tbody/tr[3]/td[3]")]
        private IWebElement AgencyName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "img[src*='/design/Images/_migdal/SearchIndex/plus.gif']")]
        private IWebElement PlusIcon { get; set; }

        private IList<IWebElement> _TableData_List;
        private IList<IWebElement> TableData_List
        {
            get { return _TableData_List = Driver.FindElements(By.XPath("//*[@id='ctl00_Spwebpartmanager1_g_ae018e01_a0b9_4a6b_b00c_b725d038d57e_ctl00_tabContainer_tab1_SearchAgentsOperation1_UpdatePanel1']/table/tbody/tr[1]/td/table/tbody/tr[4]/td[2]/table/tbody/tr[1]/td/table/tbody/tr")); }
            set { _TableData_List = null; }
        }

        [FindsBy(How = How.Id, Using = "ctl00_Spwebpartmanager1_g_ae018e01_a0b9_4a6b_b00c_b725d038d57e_ctl00_tabContainer_tab1_SearchAgentsOperation1_trResults")]
        private IWebElement TableResults { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_Spwebpartmanager1_g_ae018e01_a0b9_4a6b_b00c_b725d038d57e_ctl00_tabContainer_tab1_SearchAgentsOperation1_UpdatePanel1']/table/tbody/tr[1]/td/table/tbody/tr[4]/td[2]/table/tbody/tr[2]/td/span[2]")]
        private IWebElement SMSLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='SMSMainTbl']/tbody/tr[1]/td/table/tbody/tr/td[2]")]
        private IWebElement SMS_PopUp_Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='SMSMainTbl']/tbody/tr[1]/td/table/tbody/tr/td[3]/img")]
        private IWebElement SMS_PopUp_Close { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_Spwebpartmanager1_g_ae018e01_a0b9_4a6b_b00c_b725d038d57e_ctl00_tabContainer_tab1_SearchAgentsOperation1_UpdatePanel1']/table/tbody/tr[1]/td/table/tbody/tr[4]/td[2]/table/tbody/tr[2]/td/span[3]")]
        private IWebElement PrintBtn { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "סוכני ביטוח בתל אביב")]
        private IWebElement AgentsInTvLink { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "סוכני ביטוח בראשל")]
        private IWebElement AgentsInRishonLink { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "סוכני ביטוח ברמת גן")]
        private IWebElement AgentsInRamatganLink { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "סוכני ביטוח בערים")]
        private IWebElement AgentsInOtherCityLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_Spwebpartmanager1_g_ae018e01_a0b9_4a6b_b00c_b725d038d57e_ctl00_tabContainer_tab1_SearchAgentsOperation1_UpdatePanel1']/table/tbody/tr[1]/td/table/tbody/tr[4]/td[2]/table/tbody/tr[3]/td/table/tbody/tr/td[3]/table/tbody/tr/td[2]")]
        private IWebElement TravelIinsurOnline { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_SPWebPartManager1_g_34a5d0be_3f45_4507_aeb3_e6647b2194c7_ctl00_tdSummaryTitle")]
        private IWebElement TravelInsuPageTitle_AgentName { get; set; }
        #endregion


        public void GetAgentResault()
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

                //var element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("ctl00_TopTabMenuAndLogin_rptTopMenuMainLinks_ctl00_hlLinkUrl")));
                //IWebElement menu = Driver.FindElement(By.Id("ctl00_TopTabMenuAndLogin_rptTopMenuMainLinks_ctl00_hlLinkUrl"));

                ////mouse over on the link and click on it
                //var js = (IJavaScriptExecutor)Driver;

                //js.ExecuteScript("$('[id=ctl00_TopTabMenuAndLogin_rptTopMenuMainLinks_ctl00_hlLinkUrl]').trigger('mouseover')");
                //Thread.Sleep(3000);
                //IWebElement FindAgentLink = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='ctl00_TopTabMenuAndLogin_rptTopMenuMainLinks_ctl00_ulLeftListSubMenu']/li[8]/span/a")));
                //js.ExecuteScript("arguments[0].click();", FindAgentLink);
                //Thread.Sleep(3000);

                Driver.Url = ConfigurationManager.AppSettings["FindAgentPageURL"];

                string AgentSearch_Window = Driver.CurrentWindowHandle;
                //clicking on explanation  
                ExplainTab.Click();
                Assert.True(ExplainText.Text.Contains("מערכת איתור סוכנים מאפשרת לך לקבל פרטים על סוכני מגדל לפי מידע שברשותך"));
                ReportGenerator.Test.Log(LogStatus.Pass, "verify explanation text is correct");
                //click on operation
                OperationTab.Click();

                //find contact component 
                int ContactComponentLocByX = ContactComponentCorrect.Location.X;
                int ContactComponentLocByY = ContactComponentCorrect.Location.Y;

                //ajax - autocomplete search field
                //Agent component
                AgentSearchField.SendKeys(GetXmlOneValue("AgentNamefield"));
                AgentSearchField.SendKeys(Keys.ArrowDown);

                Thread.Sleep(6000);

                Assert.Greater(AgentsearchList.Count, 0, "auto suggest for agent isn't working...");
                ReportGenerator.Test.Log(LogStatus.Pass, "verify auto complete for agent field is work");

                foreach (var ele in AgentsearchList)
                {
                    if (ele.Text.Equals(GetXmlOneValue("AgentChoice")))
                    {
                        ele.Click();
                        break;
                    }
                }
                ReportGenerator.Test.Log(LogStatus.Pass, "click in agent from the kist");
                string Agentchoose = GetXmlOneValue("AgentChoice");

                //Agency component
                wait.Timeout = TimeSpan.FromSeconds(40);

                AgencySearchField.SendKeys(GetXmlOneValue("AgencyNameField"));
                AgencySearchField.SendKeys(Keys.ArrowDown);

                Thread.Sleep(3000);
                Assert.Greater(AgencySearchList.Count, 0, "auto suggest for agency is not working...");
                ReportGenerator.Test.Log(LogStatus.Pass, "verify auto complete for agency field is work");

                AgencySearchField.Clear();
                Thread.Sleep(1500);
                AgencySearchField.SendKeys(GetXmlOneValue("AgencyChoice"));
                Thread.Sleep(3000);
                AgencySearchField.SendKeys(Keys.Enter);

                ReportGenerator.Test.Log(LogStatus.Pass, "click on agency from the list");
                string AgencyChoose = GetXmlOneValue("AgencyChoice");


                //option1
                //check if the collection of the elements is contain
                //create array 
                string[] drop = { "בחר מרשימה", "ביטוח כללי", "חיים ובריאות" };
                IEnumerable<string> actual = DropDownList.Options.Select(a => a.Text);


                string[] Actualarray = actual.ToArray();

                //check if exactly  the options in the drop down list are present
                if (drop.Length == Actualarray.Length)
                {
                    for (int k = 0; k < drop.Length; k++)
                    {
                        Assert.AreEqual(drop[k], Actualarray[k], "expected option {0} but was {1}", drop[k], Actualarray[k]);
                    }
                }
                else if (drop.Length > Actualarray.Length)
                {
                    Assert.IsTrue(drop.All(d => actual.Contains(d)), "option is missing in website");
                }

                //check if there is options in the  web that shouldn't be 
                Assert.IsFalse(Actualarray.Length > drop.Length, "in the website - dropdown list there's more option that should be");


                //picking option from drop down list 
                Thread.Sleep(2000);
                foreach (IWebElement delement in DropDownList.Options)
                {
                    if (delement.Text == "חיים ובריאות")
                    {
                        delement.Click();
                    }
                }

                //click on search 
                SearchBtn.Click();
                Thread.Sleep(3000);
                SearchBtn.Click();
                Thread.Sleep(5000);

                //check if the no result title is there 
                CheckIfElementPresent(NoResult_Indicate, 30);
                Assert.AreEqual(NoResult_Indicate.Text, "לא נמצאו תוצאות תואמות לשאילתא שלך");
                Thread.Sleep(3000);
                //click on clean btn 
                CleanBtn.Click();
                Thread.Sleep(10000);
                //check if clean btn is working
                bool CleanBtnWork = CheckIfElementPresent(NoResult_Indicate, 15);
                if (CleanBtnWork == true)
                {
                    CleanBtn.Click();
                    Thread.Sleep(10000);
                    CleanBtnWork = CheckIfElementPresent(NoResult_Indicate, 15);
                }

                Assert.False(CleanBtnWork, "clean btn not clean the result");
                ReportGenerator.Test.Log(LogStatus.Pass, "check the clean button");

                //picking option from drop down list 
                //Thread.Sleep(3000);
                DropDownList.SelectByText("ביטוח כללי");

                //click on search button 
                Thread.Sleep(3000);
                SearchBtn.Click();
                Thread.Sleep(13000);

                //find Contact component after clicking on searc button
                int ContactcomponentAfterLocByX = ContactComponentCorrect.Location.X;
                int ContactcomponentAfterLocByY = ContactComponentCorrect.Location.Y;


                //verfiy Contact component location is correct
                try
                {
                    Assert.AreEqual(ContactComponentLocByX, ContactcomponentAfterLocByX, "Contact Component change location, screenshot was taken");
                    Assert.AreEqual(ContactComponentLocByY, ContactcomponentAfterLocByY, "Contact Component change location, screenshot was taken");
                }
                catch (Exception e)
                {
                    
                    LineFailure = GetLineNumber_Fail(e);
                    Console.WriteLine("fail in line {0}", LineFailure);
                    ReportGenerator.Test.Log(LogStatus.Fail, ReportGenerator.Test.AddScreenCapture(TakeScreenShot("ComponentLocation", Driver)), e);
                    ReportGenerator.Extent.EndTest(ReportGenerator.Test);
                    throw e;
                }


                //check if the search result title is present 
                try
                {
                    CheckIfElementPresent(table_Result_title, 30);
                    Assert.IsTrue(table_Result_title.Text.Contains("תוצאות חיפוש"));
                }
                catch (NoSuchElementException)
                {
                    SearchBtn.Click();
                    Thread.Sleep(6000);
                }

                CheckIfElementPresent(table_Result_title, 30);
                Assert.IsTrue(table_Result_title.Text.Contains("תוצאות חיפוש"));

                //get table result values collection and printing them            
                //check if there's no result that no belong to the parameter are asked for 
                //verify the elements agent name + agency name is in the right place with there text belong 
                int NumOfRowsResult = ResultRows.Count;

                try
                {
                    if (NumOfRowsResult == 1)
                    {

                    }
                    else
                    {
                        throw new Exception("there is more/less result that should be....");
                    }

                }
                catch (Exception e)
                {
                    LineFailure = GetLineNumber_Fail(e);
                    Console.WriteLine("fail in line {0}", LineFailure);
                    ReportGenerator.Test.Log(LogStatus.Fail, ReportGenerator.Test.AddScreenCapture(TakeScreenShot("tableResult", Driver)), e);
                    ReportGenerator.Extent.EndTest(ReportGenerator.Test);
                    throw e;
                }

                try
                {

                    Assert.AreEqual(AgentNameTitle.Text, "שם סוכן");
                    Assert.AreEqual(AgentName.Text, Agentchoose, "not found the agent name are looking for...");

                    Thread.Sleep(2000);

                    Assert.AreEqual(AgencyNameTitle.Text, "סוכנות");
                    Assert.AreEqual(AgencyName.Text, AgencyChoose, "not given the agency name are looking for...");
                }
                catch (Exception e)
                {
                    LineFailure = GetLineNumber_Fail(e);
                    Console.WriteLine("fail in line {0}", LineFailure);
                    ReportGenerator.Test.Log(LogStatus.Fail, ReportGenerator.Test.AddScreenCapture(TakeScreenShot("tableres", Driver)), e);
                    ReportGenerator.Extent.EndTest(ReportGenerator.Test);
                    throw e;
                }


                Thread.Sleep(2000);

                //clicking on + for extension Data 
                PlusIcon.Click();
                Thread.Sleep(2000);

                //check that the element is equals to the insert value



                Assert.IsTrue(TableData_List.Any(a => a.Text.Contains(Agentchoose)));
                Assert.IsTrue(TableData_List.Any(a => a.Text.Contains(AgencyChoose)));

                //check if agentpage title is displayed and with the right text  

                Assert.IsTrue(TableData_List.Any(a => a.Text.Contains("דף סוכן")));

                //clicking on link and check if it work
                Driver.FindElement(By.LinkText("לחץ לקישור")).Click();
                Thread.Sleep(5000);

                IWebElement AgentPageTitleEle = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("ctl00_SPWebPartManager1_g_1ed1806c_9c64_4670_9a8e_175f66adc7ec_ctl00_tdAgentName")));
                string AgentPageTitle = AgentPageTitleEle.Text;
                string AgentPageTabTitle = Driver.Title;

                Assert.True(AgentPageTitleEle.Displayed, "agent page not upload");
                Assert.AreEqual(AgentPageTitle, Agentchoose);
                Assert.IsTrue(AgentPageTabTitle.Contains("שם הסוכן"));

                //clicking for back to the Agent searching page and printing the url            
                Driver.FindElement(By.Id("ctl00_SPWebPartManager1_g_1ed1806c_9c64_4670_9a8e_175f66adc7ec_ctl00_tdBackToSearch")).Click();

                //insert parameters all over again 
                AgentSearchField.SendKeys(GetXmlOneValue("AgentChoice"));
                Thread.Sleep(3000);


                foreach (var c in DropDownList.Options)
                {
                    if (c.Text == "ביטוח כללי")
                    {
                        c.Click();
                        break;
                    }
                }

                Thread.Sleep(4000);

                //clicking on the button to get table result
                wait.Until(ExpectedConditions.ElementToBeClickable(SearchBtn)).Click();

                Thread.Sleep(6000);
                try
                {
                    if (!table_Result_title.Displayed)
                    {
                        CleanBtn.Click();
                        SearchBtn.Click();
                        Thread.Sleep(6000);
                    }
                }
                catch (Exception)
                {
                    CleanBtn.Click();
                    SearchBtn.Click();
                    Thread.Sleep(6000);
                }

                //clicking again on + for extension Data
                wait.Until(ExpectedConditions.ElementToBeClickable(PlusIcon)).Click();
                Thread.Sleep(2000);

                //bool SendDetailsSubtitle= driver.FindElement(By.XPath("//*[@id='ctl00_Spwebpartmanager1_g_ae018e01_a0b9_4a6b_b00c_b725d038d57e_ctl00_tabContainer_tab1_SearchAgentsOperation1_UpdatePanel1']/table/tbody/tr[1]/td/table/tbody/tr[4]/td[2]/table/tbody/tr[2]/td")).Displayed;
                //Assert.IsTrue(SendDetailsSubtitle);

                //click on sms                   
                SMSLink.Click();
                Thread.Sleep(2000);

                //check sms popup is present with the title                    
                Assert.IsTrue(SMS_PopUp_Title.Text.Contains("SMS"));

                Thread.Sleep(2000);
                //closing sms popup 
                SMS_PopUp_Close.Click();

                Thread.Sleep(2000);
                //click on print button     
                PrintBtn.Click();
                Thread.Sleep(2000);

                foreach (string window in Driver.WindowHandles)
                {
                    Driver.SwitchTo().Window(window);
                }

                //verify print window is open and after  closing it            

                //Thread.Sleep(3000);
                try
                {
                    Driver.Close();
                }
                catch (NoSuchWindowException e)
                {
                    LineFailure = GetLineNumber_Fail(e);
                    Console.WriteLine("fail in line {0}", e);
                    ReportGenerator.Test.Log(LogStatus.Fail, ReportGenerator.Test.AddScreenCapture(TakeScreenShot("PrintWindow", Driver)), e);
                    ReportGenerator.Extent.EndTest(ReportGenerator.Test);
                    throw e;
                }

                //switching back to agent search window and print the url 

                Driver.SwitchTo().Window(AgentSearch_Window);

                //verify the bottom links agents is shown                  

                Assert.IsTrue(AgentsInTvLink.Text.Contains("סוכני ביטוח בתל אביב"), "text for agent in tv is incorrect");
                Assert.IsTrue(AgentsInRishonLink.Text.Contains("סוכני ביטוח בראשל"), "text for agent in rhison is incorrect");
                Assert.IsTrue(AgentsInRamatganLink.Text.Contains("סוכני ביטוח ברמת גן"), "text for agent in ramat-gan is incorrect");

                //verify the bottom link is shown               
                Assert.IsTrue(AgentsInOtherCityLink.Text.Contains("סוכני ביטוח בערים נוספות"), "text for agent in other city  is incorrect");

                //verify travl limk is shown up and click on it and verify redirecting to the right screen                          
                Assert.True(TravelIinsurOnline.Displayed, "link for travel insur isn't shown");

                TravelIinsurOnline.Click();
                Thread.Sleep(3000);
                string TravelIinsurOnlineUrl = Driver.Url.ToString();
                Assert.IsTrue(TravelIinsurOnlineUrl.Contains("TravelInsurance"));

                ReportGenerator.Extent.EndTest(ReportGenerator.Test);

            }
            catch (Exception e)
            {
                LineFailure = GetLineNumber_Fail(e);
                Console.WriteLine("fail in line {0}", LineFailure);
                ReportGenerator.Test.Log(LogStatus.Fail, e);
                ReportGenerator.Extent.EndTest(ReportGenerator.Test);
                Console.WriteLine(LineFailure);
                throw e;
            }
        }
    }
}