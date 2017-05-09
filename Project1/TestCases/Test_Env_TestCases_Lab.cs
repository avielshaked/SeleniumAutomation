using NUnit.Framework;
using Project1.PageObjectFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.TestsLabConfigurations;
using Project1.GenericMethods;

namespace Project1.TestCases
{
    [TestFixture]
    class Test_Env_TestCases_Lab : Lab_Configuration
    {
        static int lineFailure_Num;
        XmlMethods xmlM = new XmlMethods();

        [Test]
        public void Gemel_change_of_investment_Track()
        {
            try
            {
                PageGenerator.LoginPage.LoginAction(xmlM.GetXmlOneValue("GemelID"), xmlM.GetXmlOneValue("GemelIDPassword"));
                PageGenerator.personal_details_rikuz_pof.Click_On_ShinuiMaslul();
                PageGenerator.shinui_maslul_pof.Gemel_Change_Of_Investment_track_E2E();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Test]
        public void Hishtalmoot_change_of_investment_Track()
        {
            try
            {
                PageGenerator.LoginPage.LoginAction(xmlM.GetXmlOneValue("HishtalmutID"), xmlM.GetXmlOneValue("HishtalmutIDPassword"));
                PageGenerator.personal_details_rikuz_pof.Click_On_ShinuiMaslul();
                PageGenerator.shinui_maslul_pof.Hishtalmoot_Change_Of_Investment_track_E2E();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [Test]
        public void Gemel_Lehashkaa_change_of_investment_track()
        {
            try
            {
                PageGenerator.LoginPage.LoginAction(xmlM.GetXmlOneValue("Gemel_LehashkaaID"), xmlM.GetXmlOneValue("Gemel_LehashkaaPassword"));
                PageGenerator.personal_details_rikuz_pof.Click_On_ShinuiMaslul();
                PageGenerator.shinui_maslul_pof.Gemel_Lehashkaa_Change_Of_Investment_E2E();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [Test]
        public void Keshet_Change_of_investment_track()
        {
            try
            {
                PageGenerator.LoginPage.LoginAction(xmlM.GetXmlOneValue("KeshetID"), xmlM.GetXmlOneValue("KeshetPassword"));
                PageGenerator.personal_details_rikuz_pof.Click_On_ShinuiMaslul();
                PageGenerator.shinui_maslul_pof.Keshet_Change_Of_Investment_E2E();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [Test]
        public void Pension_Change_of_investment_track()
        {
            try
            {
                PageGenerator.LoginPage.LoginAction(xmlM.GetXmlOneValue("PensionID"), xmlM.GetXmlOneValue("PensionPassword"));
                PageGenerator.personal_details_rikuz_pof.Click_On_ShinuiMaslul();
                PageGenerator.shinui_maslul_pof.Pension_Change_Of_Investment_E2E();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [Test]
        public void BituahHaim_Change_of_investment_track()
        {
            try
            {
                PageGenerator.LoginPage.LoginAction(xmlM.GetXmlOneValue("BituahHaimID"), xmlM.GetXmlOneValue("BituahHaimPassword"));
                PageGenerator.personal_details_rikuz_pof.Click_On_ShinuiMaslul();
                PageGenerator.shinui_maslul_pof.BituahHaim_Change_Of_Investment_E2E();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int ReciveLineFailure(int lineNum)
        {
            lineFailure_Num = lineNum;
            return lineFailure_Num;
        }
    }
}
