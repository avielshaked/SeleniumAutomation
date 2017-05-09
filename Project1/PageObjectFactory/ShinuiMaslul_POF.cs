using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project1.PageObjectFactory
{
    class ShinuiMaslul_POF : PageGenerator
    {
        int? AcoountNumber;
        int lineFailure_Num;
        Test_Env_TestCases_Lab tc = new Test_Env_TestCases_Lab();

        #region Stage1_Properties/Fields
        [FindsBy(How = How.Id, Using = "ctl00_Spwebpartmanager1_g_460a79da_b691_4c1b_a653_131342b85dd3_ctl00_ucFundsList_lstGemel_ctl00_Label1")]
        private IWebElement GemelAccount { get; set; }

        [FindsBy(How = How.Id, Using = "btnClean")]
        private IWebElement Clean_Btn { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_460a79da_b691_4c1b_a653_131342b85dd3$ctl00$ucFundsList$btnNext")]
        private IWebElement Forward_Btn { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_460a79da_b691_4c1b_a653_131342b85dd3$ctl00$ucFundsList$lstKranot$ctl00$cbFunds")]
        private IWebElement HishtalmutAccount { get; set; } // account 232058

        [FindsBy(How = How.Id, Using = "ctl00_Spwebpartmanager1_g_460a79da_b691_4c1b_a653_131342b85dd3_ctl00_ucFundsList_lstGemelInvestment_ctl00_Label1")]
        private IWebElement Gemel_Lehashkaa_Account { get; set; } //account 37322436

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_460a79da_b691_4c1b_a653_131342b85dd3$ctl00$ucFundsList$lstBituachMigdalorPrat$ctl00$cbFunds")]
        private IWebElement KeshetAccount { get; set; } // account 4547739

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_460a79da_b691_4c1b_a653_131342b85dd3$ctl00$ucFundsList$lstPensia$ctl00$cbFunds")]
        private IWebElement PensionAccount { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_460a79da_b691_4c1b_a653_131342b85dd3$ctl00$ucFundsList$lstBituachMigdal$ctl00$cbFunds")]
        private IWebElement BituahHaimAccount { get; set; }
        #endregion

        #region Stage2_Properties/Fields 
        [FindsBy(How = How.Id, Using = "ctl00_Spwebpartmanager1_g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f_ctl00_ctl01_lstStatusFunds_ctl00_lblStatusFund")]
        private IWebElement Account_Indicate_title { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_Spwebpartmanager1_g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd_ctl00_ctl01_lstStatusFunds_ctl00_lblStatusFund")]
        public IWebElement Keshet_Account_Indicate_title { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_Spwebpartmanager1_g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd_ctl00_ctl01_lstStatusFunds_ctl00_lblStatusFund")]
        public IWebElement Pension_Account_Indicate_title { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_Spwebpartmanager1_g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd_ctl00_ctl01_lstStatusFunds_ctl00_lblStatusFund")]
        public IWebElement BituahHaim_Account_Indicate_title { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$btnChangeMaslul")]
        private IWebElement step2Forward_Btn { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$btnChangeMaslul")]
        private IWebElement Keshet_step2Forward_Btn { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$btnChangeMaslul")]
        private IWebElement Pension_step2Forward_Btn { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$btnChangeMaslul")]
        private IWebElement BituahHaim_step2Forward_Btn { get; set; }

        [FindsBy(How = How.ClassName, Using = "returnToStep")]
        private IWebElement Back_Link_Btn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_Spwebpartmanager1_g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f']/table/tbody/tr[2]/td[1]/label/span")]
        private IWebElement ItraTzvura_And_HafkadotShotfot { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_Spwebpartmanager1_g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f']/table/tbody/tr[2]/td[2]/label/div/span")]
        private IWebElement ItraTzvura { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_Spwebpartmanager1_g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f']/table/tbody/tr[2]/td[3]/label/span")]
        private IWebElement HafkadotShotfot { get; set; }

        //gemel tracks                  
        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl00$txtPercentItra_-1")]
        private IWebElement Gemel_TlooyGil_track_Precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl01$txtPercentItra_859")]
        private IWebElement Gemel_Hagach_track_Precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl02$txtPercentItra_858")]
        private IWebElement Gemel_ShikliTvachKatzar_track_Percent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl03$txtPercentItra_860")]
        private IWebElement Gemel_TzmoodMadad_track_percent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl04$txtPercentItra_862")]
        private IWebElement Gemel_Khool_track_Precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl05$txtPercentItra_863")]
        private IWebElement Gemel_Menayot_track_Precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl06$txtPercentItra_8012")]
        private IWebElement Gemel_HagachAd10_track_Percent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl07$txtPercentItra_9779")]
        private IWebElement Gemel_50AndLess_track_Precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl08$txtPercentItra_9780")]
        private IWebElement Gemel_50to60_track_precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl09$txtPercentItra_9781")]
        private IWebElement Gemel_60AndMore_track_precent_Input { get; set; }

        //Hishtalmout tracks
        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl00$txtPercentItra_-2")]
        private IWebElement Hishtalmut_TlooyGil_track_Precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl01$txtPercentItra_199")]
        private IWebElement Hishtalmut_Hagah_track_precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl02$txtPercentItra_579")]
        private IWebElement Hishtalmut_Klali_track_precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl03$txtPercentItra_599")]
        private IWebElement Hishtalmut_Hagah_Ad10Menayot_track_precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl04$txtPercentItra_864")]
        private IWebElement Hishtalmut_shikli_TvahKatzar_track_precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl05$txtPercentItra_865")]
        private IWebElement Hishtalmut__Hagah_Mimshalti_tracl_precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl06$txtPercentItra_868")]
        private IWebElement Hishtalmut_Khool_track_precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl07$txtPercentItra_869")]
        private IWebElement Hishtalmut_Menayot_track_precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl08$txtPercentItra_2048")]
        private IWebElement Hishtalmut_Halach_track_precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl09$txtPercentItra_7256")]
        private IWebElement Hishtalmut_Pasivi_Klali_track_precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl10$txtPercentItra_7253")]
        private IWebElement Hishtalmut_50AndLess_track_Precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl11$txtPercentItra_7254")]
        private IWebElement Hishtalmut_50to60_track_precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl12$txtPercentItra_470")]
        private IWebElement Hishtalmut_60AndMore_track_precent_Input { get; set; }

        [FindsBy(How = How.Id, Using = "spnStepTwoValidID")]
        private IWebElement divide_Msg { get; set; }

        //gemel lehashkaa tracks
        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl00$txtPercentItra_7936")]
        private IWebElement Gemel_Lehashkaa_Klali_track_precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl01$txtPercentItra_7935")]
        private IWebElement Gemel_Lehashkaa_Hagah_Ad10Menayot_track_precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl02$txtPercentItra_7931")]
        private IWebElement Gemel_Lehashkaa_ShikliTvach_Katzar_track_precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl03$txtPercentItra_7932")]
        private IWebElement Gemel_Lehashkaa_HagahMimshalti_track_precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl04$txtPercentItra_7933")]
        private IWebElement Gemel_Lehashkaa_Khool_track__precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl05$txtPercentItra_7934")]
        private IWebElement Gemel_Lehashkaa_Menayot_track_precent_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0905fd0c_23f5_47d1_9f40_ca5cd36d787f$ctl00$lstMaslul$ctl06$txtPercentItra_7937")]
        private IWebElement Gemel_Lehashkaa_Halacha_track_precent_Input { get; set; }

        //keshet                         
        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_Spwebpartmanager1_g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd_ctl00_tdFuturePaymentsBox']/label/span")]
        private IWebElement Keshet_FeautersPayments_comp { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_Spwebpartmanager1_g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd_ctl00_tdItraTzvura']/label/table/tbody/tr/td[2]")]
        private IWebElement Keshet_TzviraKayemet_comp { get; set; }

        //keshet tracks
        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPrati$ctl00$cbPrat")]
        private IWebElement Keshet_Klali_track_CheckBox { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPrati$ctl01$cbPrat")]
        private IWebElement Keshet_Hagah_Ad10_Menayot_track_CheckBox { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPrati$ctl02$cbPrat")]
        public IWebElement Keshet_Hagah_Ad25_Menayot_track_Checkbox { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPrati$ctl03$cbPrat")]
        private IWebElement Keshet_Menayot_track_Checkbox { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPrati$ctl04$cbPrat")]
        private IWebElement Keshet_Hagah_MimsheletIsrael_track_Checkbox { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPrati$ctl05$cbPrat")]
        private IWebElement Keshet_Halacha_track_Checkbox { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPrati$ctl06$cbPrat")]
        private IWebElement Keshet_khool_track_Checkbox { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPrati$ctl07$cbPrat")]
        private IWebElement Keshet_Hagah_track_Checkbox { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPrati$ctl08$cbPrat")]
        private IWebElement Keshet_Shikli_TvachKatzar_track_Checkbox { get; set; }


        //Pension                       
        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_Spwebpartmanager1_g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd_ctl00_tdFuturePaymentsBox']/label/span")]
        private IWebElement Pension_FeautersPayments_comp { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_Spwebpartmanager1_g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd_ctl00_tdItraTzvura']/label/table/tbody/tr/td[2]")]
        private IWebElement Pension_TzviraKayemet_comp { get; set; }

        //Pension tracks
        //menayot
        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPensia$ctl00$cbPitzui")]
        private IWebElement Pension_Menayot_track_Pitzuim_CheckBox { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPensia$ctl00$cbTagmul")]
        private IWebElement Pension_Menayot_track_Tagmuilim_CheckBox { get; set; }

        //shikli
        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPensia$ctl01$cbPitzui")]
        private IWebElement Pension_Shikli_track_Pitzuim_CheckBox { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPensia$ctl01$cbTagmul")]
        private IWebElement Pension_Shikli_track_Tagmulim_CheckBox { get; set; }

        //hagah
        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPensia$ctl02$cbPitzui")]
        private IWebElement Pension_Hagah_track_Pitzuim_CheckBox { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPensia$ctl02$cbTagmul")]
        private IWebElement Pension_Hagah_track_Tagmulim_CheckBox { get; set; }

        //halacha
        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPensia$ctl03$cbPitzui")]
        private IWebElement Pension_Halacha_track_Pitzuim_CheckBox { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPensia$ctl03$cbTagmul")]
        private IWebElement Pension_Halacha_track_Tagmulim_CheckBox { get; set; }

        //Tlooy gil
        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPensia$ctl04$cbPitzui")]
        private IWebElement Pension_TlooyGil_track_Pitzuim_CheckBox { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPensia$ctl04$cbTagmul")]
        private IWebElement Pension_TlooyGil_track_Tagmulim_CheckBox { get; set; }

        //50 and less
        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPensia$ctl05$cbPitzui")]
        private IWebElement Pension_50AndLess_track_Pitzuim_CheckBox { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPensia$ctl05$cbTagmul")]
        private IWebElement Pension_50AndLess_track_Tagmulim_CheckBox { get; set; }

        //50-60
        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPensia$ctl06$cbPitzui")]
        private IWebElement Pension_50To60_track_Pitzuim_CheckBox { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPensia$ctl06$cbTagmul")]
        private IWebElement Pension_50To60_track_Tagmulim_CheckBox { get; set; }

        //60 and more 
        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPensia$ctl07$cbPitzui")]
        private IWebElement Pension_60AndMore_track_Pitzuim_CheckBox { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulPensia$ctl07$cbTagmul")]
        private IWebElement Pension_60AndMore_track_Tagmulim_CheckBox { get; set; }

        //bituah
        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_Spwebpartmanager1_g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd_ctl00_tdFuturePaymentsBox']/label/span")]
        private IWebElement BituahHaim_FeautersPayments_comp { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_Spwebpartmanager1_g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd_ctl00_tdItraTzvura']/label/table/tbody/tr/td[2]/span")]
        private IWebElement BituahHaim_ItraTzvura_comp { get; set; }

        //bituah haim  tracks
        //hagah ad 10%
        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulMenahalim$ctl00$cbPitzui")]
        private IWebElement BituahHaim_HagahAd10_men_track_Pitzuim_CheckBox { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulMenahalim$ctl00$cbTagmul")]
        private IWebElement BituahHaim_HagahAd10_men_track_Tagmulim_CheckBox { get; set; }

        //hagah ad 25%
        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulMenahalim$ctl01$cbPitzui")]
        private IWebElement BituahHaim_HagahAd25_men_track_Pitzuim_CheckBox { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulMenahalim$ctl01$cbTagmul")]
        private IWebElement BituahHaim_HagahAd25_men_track_Tagmulim_CheckBox { get; set; }

        //menayot
        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulMenahalim$ctl02$cbPitzui")]
        private IWebElement BituahHaim_Menayot_track_Pitzuim_CheckBox { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulMenahalim$ctl02$cbTagmul")]
        private IWebElement BituahHaim_Menayot_track_Tagmulim_CheckBox { get; set; }

        //hagah mimshelet israel
        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulMenahalim$ctl03$cbPitzui")]
        private IWebElement BituahHaim_Hagah_Mimshelet_Israel_track_Pitzuim_CheckBox { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_0cf6f474_3e33_4fe8_8703_bc150ebc3fbd$ctl00$lstMaslulMenahalim$ctl03$cbTagmul")]
        private IWebElement BituahHaim_Hagah_Mimshelet_Israel_track_Tagmulim_CheckBox { get; set; }

        #endregion

        #region Stage3_Properties/Fields
        [FindsBy(How = How.Id, Using = "txtOTP")]
        private IWebElement Otp_Input { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$Spwebpartmanager1$g_8ca64ac9_82ad_4ad8_9885_3c236c13b243$ctl00$btnApproval")]
        private IWebElement Confirm_Btn { get; set; }

        [FindsBy(How = How.Id, Using = "cbAgree")]
        private IWebElement Statment_CheckBox { get; set; }
        #endregion

        #region Stage4_Properties/Fields
        [FindsBy(How = How.Id, Using = "ctl00_Spwebpartmanager1_g_376c3475_a555_4f7a_ba89_5358d2aeb423_ctl00_lblMaslulDone")]
        private IWebElement Confirm_Msg { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_Spwebpartmanager1_g_376c3475_a555_4f7a_ba89_5358d2aeb423_ctl00_ctl00_imgPdf")]
        private IWebElement Pdf_Link { get; set; }
        #endregion

        [FindsBy(How = How.ClassName, Using = "ExitNewAccount")]
        private IWebElement WebExitBtn { get; set; }



        public void Gemel_Change_Of_Investment_track_E2E()
        {
            int UserId = int.Parse(GetXmlOneValue("GemelID"));
            try
            {
                //stage 1
                Forward_Btn.Click();
                Assert.True(Driver.Url.Contains("step1"), "you can forward to the next step whitout choosing any account");
                GemelAccount.Click();
                Forward_Btn.Click();

                //stage 2 
                Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step2");
                using (MigdalSiteEntities context = new MigdalSiteEntities())
                {
                    Tbl_ShinuiMaslul_Transaction obj = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.UserID == UserId).OrderByDescending(o => o.StartProcessDate).FirstOrDefault();
                    Tbl_ShinuiMaslul_TransactionToFund obj_found = context.Tbl_ShinuiMaslul_TransactionToFund.Where(o => o.TransactionID == obj.TransactionID).FirstOrDefault();
                    AcoountNumber = obj_found.FundID;
                    string AcoountNumber2 = AcoountNumber.ToString();
                    Assert.True(Account_Indicate_title.Text.Contains(AcoountNumber2), "the account number that shown is not the account that chosen");

                    //try to move next step without choosing track or one of the 3 options
                    step2Forward_Btn.Click();
                    Assert.True(Driver.Url.Contains("step2"), "you can forward to the next step whitout choosing track or one of the 3 options");
                    Gemel_TlooyGil_track_Precent_Input.SendKeys("100");
                    step2Forward_Btn.Click();
                    Assert.True(Driver.Url.Contains("step2"), "you can forward to the next step whitout choosing one of 3 options ");
                    Gemel_TlooyGil_track_Precent_Input.Clear();
                    ItraTzvura.Click();
                    step2Forward_Btn.Click();
                    Assert.True(Driver.Url.Contains("step2"), "you can forward to the next step whitout choosing track ");

                    //verify all 3 option is writing in DB 
                    //tzvura & hafkadot
                    ItraTzvura_And_HafkadotShotfot.Click();
                    Gemel_TlooyGil_track_Precent_Input.SendKeys("100");
                    step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    List<Tbl_ShinuiMaslul_TransactionFundMaslul> obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True((item.PercentItra != "0" && item.PercentItra != null) && (item.PercentHafkada != "0" && item.PercentHafkada != null), "picking the tzvura and hafkdaot option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();
                    //itra only
                    ItraTzvura.Click();
                    Gemel_TlooyGil_track_Precent_Input.Clear();
                    Gemel_Hagach_track_Precent_Input.SendKeys("100");
                    step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True((item.PercentItra != "0" && item.PercentItra != null) && (item.PercentHafkada == "0" || item.PercentHafkada == null), "picking only  tzvura  option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();
                    //hafkadot only
                    HafkadotShotfot.Click();
                    step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True((item.PercentItra == "0" || item.PercentItra == null) && (item.PercentHafkada != "0" && item.PercentHafkada != null), "picking only hafkdaot option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();

                    //check all the tracks
                    ItraTzvura.Click();
                    Gemel_Hagach_track_Precent_Input.Clear();
                    Gemel_Hagach_track_Precent_Input.SendKeys("10");
                    Gemel_ShikliTvachKatzar_track_Percent_Input.SendKeys("10");
                    Gemel_TzmoodMadad_track_percent_Input.SendKeys("10");
                    Gemel_Khool_track_Precent_Input.SendKeys("10");
                    Gemel_Menayot_track_Precent_Input.SendKeys("10");
                    Gemel_HagachAd10_track_Percent_Input.SendKeys("10");
                    Gemel_50AndLess_track_Precent_Input.SendKeys("10");
                    Gemel_50to60_track_precent_Input.SendKeys("10");
                    Gemel_60AndMore_track_precent_Input.SendKeys("20");
                    step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    List<Tbl_ShinuiMaslul_TransactionFundMaslul> TracksList = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    Assert.True(TracksList.Count == 9, "not all the selected tracks is writing in the db");
                    Back_Link_Btn.Click();

                    //clear all tracks
                    Gemel_TlooyGil_track_Precent_Input.Clear();
                    Gemel_Hagach_track_Precent_Input.Clear();
                    Gemel_ShikliTvachKatzar_track_Percent_Input.Clear();
                    Gemel_TzmoodMadad_track_percent_Input.Clear();
                    Gemel_Khool_track_Precent_Input.Clear();
                    Gemel_Menayot_track_Precent_Input.Clear();
                    Gemel_HagachAd10_track_Percent_Input.Clear();
                    Gemel_50AndLess_track_Precent_Input.Clear();
                    Gemel_50to60_track_precent_Input.Clear();
                    Gemel_60AndMore_track_precent_Input.Clear();


                    //pick tlooy gil track + check divid message
                    ItraTzvura_And_HafkadotShotfot.Click();
                    Gemel_TlooyGil_track_Precent_Input.SendKeys("50");
                    Assert.True(divide_Msg.Displayed, "divide message in not displayed");
                    Gemel_TlooyGil_track_Precent_Input.Clear();
                    Gemel_TlooyGil_track_Precent_Input.SendKeys("99");
                    Assert.True(divide_Msg.Displayed, "divide message in not displayed");
                    Gemel_TlooyGil_track_Precent_Input.Clear();
                    Gemel_TlooyGil_track_Precent_Input.SendKeys("101");
                    Assert.True(divide_Msg.Displayed, "divide message in not displayed");
                    Gemel_TlooyGil_track_Precent_Input.Clear();
                    Gemel_TlooyGil_track_Precent_Input.SendKeys("50");
                    Gemel_Menayot_track_Precent_Input.SendKeys("50");
                    Assert.True(!divide_Msg.Displayed, "divide message is displayed");
                    step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    TracksList = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    Assert.True(TracksList.Exists(o => o.MaslulDescription.Contains("מנוהל תלוי גיל") || o.MaslulDescription.Contains("מניות")), "the track that chosen is not writing correct in db");
                    foreach (var item in TracksList)
                    {
                        Assert.True(item.PercentHafkada == "50" && item.PercentItra == "50", "the percent for each track was not eriting correctly");
                    }
                    Assert.True(TracksList.Count == 2);

                    //stage 3
                    Confirm_Btn.Click();
                    Assert.True(Driver.Url.Contains("step3"), "move to step 4 without otp and approve agreement");

                    string obj_otp = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.TransactionID == obj.TransactionID).Select(o => o.OTP).FirstOrDefault();


                    Otp_Input.SendKeys(obj_otp);
                    Confirm_Btn.Click();
                    Assert.True(Driver.Url.Contains("step3"), "move to step 4 without approve agreement");
                    IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
                    js.ExecuteScript("arguments[0].scrollIntoView(true);", Statment_CheckBox);
                    Statment_CheckBox.Click();
                    Confirm_Btn.Click();

                    //stage 4
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step4");
                    Assert.True(Confirm_Msg.Displayed, "confirm message is not displayed");
                    int? obj_StepNumber = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.TransactionID == obj.TransactionID).Select(o => o.StepNumber).FirstOrDefault();
                    Assert.True(obj_StepNumber == 4, "step number is not correct in db in the end of the proccess");
                    bool? obj_ApproveAgreement = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.TransactionID == obj.TransactionID).Select(o => o.ApproveAgreement).FirstOrDefault();
                    Assert.True(obj_ApproveAgreement, "approve agreement is not 1 in db");


                    DateTime time = DateTime.Now;
                    //js.ExecuteScript("arguments[0].scrollIntoView(true);", Pdf_Link);

                    js.ExecuteScript("scroll(-300,0);");
                    WaitForElement(Pdf_Link, TimeSpan.FromSeconds(60), Driver);
                    Pdf_Link.Click();
                    Thread.Sleep(4000);


                    DateTime lastUpdate_File;
                    string FileName = returnLast_FileName(out lastUpdate_File);

                    Assert.True(lastUpdate_File.Date.Equals(time.Date), "last file was not download");
                    Assert.True(lastUpdate_File.Hour.Equals(time.Hour), "last file was not download");
                }
            }
            catch (Exception e)
            {
                lineFailure_Num = GetLineNumber_Fail(e);
                tc.ReciveLineFailure(lineFailure_Num);
                throw e;
            }
        }

        public void Hishtalmoot_Change_Of_Investment_track_E2E()
        {
            int UserId = int.Parse(GetXmlOneValue("HishtalmutID"));

            try
            {
                //stage1
                Forward_Btn.Click();
                Assert.True(Driver.Url.Contains("step1"), "you can forward to the next step whitout choosing any account");
                HishtalmutAccount.Click();
                Forward_Btn.Click();

                //stage 2 
                Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step2");
                using (MigdalSiteEntities context = new MigdalSiteEntities())
                {
                    Tbl_ShinuiMaslul_Transaction obj = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.UserID == UserId).OrderByDescending(o => o.StartProcessDate).FirstOrDefault();
                    Tbl_ShinuiMaslul_TransactionToFund obj_found = context.Tbl_ShinuiMaslul_TransactionToFund.Where(o => o.TransactionID == obj.TransactionID).FirstOrDefault();
                    AcoountNumber = obj_found.FundID;
                    string AcoountNumber2 = AcoountNumber.ToString();
                    Assert.True(Account_Indicate_title.Text.Contains(AcoountNumber2), "the account number that shown is not the account that chosen");

                    //try to move next step without choosing track or one of the 3 options
                    step2Forward_Btn.Click();
                    Assert.True(Driver.Url.Contains("step2"), "you can forward to the next step whitout choosing track or one of the 3 options");
                    Hishtalmut_TlooyGil_track_Precent_Input.SendKeys("100");
                    step2Forward_Btn.Click();
                    Assert.True(Driver.Url.Contains("step2"), "you can forward to the next step whitout choosing one of 3 options ");
                    Hishtalmut_TlooyGil_track_Precent_Input.Clear();
                    ItraTzvura.Click();
                    step2Forward_Btn.Click();
                    Assert.True(Driver.Url.Contains("step2"), "you can forward to the next step whitout choosing track ");

                    //verify all 3 option is writing in DB 
                    //tzvura & hafkadot
                    ItraTzvura_And_HafkadotShotfot.Click();
                    Hishtalmut_TlooyGil_track_Precent_Input.SendKeys("100");
                    step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    List<Tbl_ShinuiMaslul_TransactionFundMaslul> obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True((item.PercentItra != "0" && item.PercentItra != null) && (item.PercentHafkada != "0" && item.PercentHafkada != null), "picking the tzvura and hafkdaot option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();
                    //itra only
                    ItraTzvura.Click();
                    Hishtalmut_TlooyGil_track_Precent_Input.Clear();
                    Hishtalmut_Hagah_track_precent_Input.SendKeys("100");
                    step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True((item.PercentItra != "0" && item.PercentItra != null) && (item.PercentHafkada == "0" || item.PercentHafkada == null), "picking only  tzvura  option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();
                    //hafkadot only
                    HafkadotShotfot.Click();
                    step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True((item.PercentItra == "0" || item.PercentItra == null) && (item.PercentHafkada != "0" && item.PercentHafkada != null), "picking only hafkdaot option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();

                    //check all the tracks
                    ItraTzvura.Click();
                    Hishtalmut_Hagah_track_precent_Input.Clear();
                    Hishtalmut_Hagah_track_precent_Input.SendKeys("10");
                    Hishtalmut_Klali_track_precent_Input.SendKeys("10");
                    Hishtalmut_Hagah_Ad10Menayot_track_precent_Input.SendKeys("10");
                    Hishtalmut_shikli_TvahKatzar_track_precent_Input.SendKeys("10");
                    Hishtalmut__Hagah_Mimshalti_tracl_precent_Input.SendKeys("10");
                    Hishtalmut_Khool_track_precent_Input.SendKeys("10");
                    Hishtalmut_Menayot_track_precent_Input.SendKeys("10");
                    Hishtalmut_Halach_track_precent_Input.SendKeys("10");
                    Hishtalmut_Pasivi_Klali_track_precent_Input.SendKeys("10");
                    Hishtalmut_50AndLess_track_Precent_Input.SendKeys("4");
                    Hishtalmut_50to60_track_precent_Input.SendKeys("4");
                    Hishtalmut_60AndMore_track_precent_Input.SendKeys("2");
                    step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    List<Tbl_ShinuiMaslul_TransactionFundMaslul> TracksList = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    Assert.True(TracksList.Count == 12, "not all the selected tracks is writing in the db");
                    Back_Link_Btn.Click();

                    //clear all tracks
                    Hishtalmut_Hagah_track_precent_Input.Clear();
                    Hishtalmut_Klali_track_precent_Input.Clear();
                    Hishtalmut_Hagah_Ad10Menayot_track_precent_Input.Clear();
                    Hishtalmut_shikli_TvahKatzar_track_precent_Input.Clear();
                    Hishtalmut__Hagah_Mimshalti_tracl_precent_Input.Clear();
                    Hishtalmut_Khool_track_precent_Input.Clear();
                    Hishtalmut_Menayot_track_precent_Input.Clear();
                    Hishtalmut_Halach_track_precent_Input.Clear();
                    Hishtalmut_Pasivi_Klali_track_precent_Input.Clear();
                    Hishtalmut_50AndLess_track_Precent_Input.Clear();
                    Hishtalmut_50to60_track_precent_Input.Clear();
                    Hishtalmut_60AndMore_track_precent_Input.Clear();

                    //pick tlooy gil track + check divid message
                    ItraTzvura_And_HafkadotShotfot.Click();
                    Hishtalmut_TlooyGil_track_Precent_Input.SendKeys("50");
                    Assert.True(divide_Msg.Displayed, "divide message in not displayed");
                    Hishtalmut_TlooyGil_track_Precent_Input.Clear();
                    Hishtalmut_TlooyGil_track_Precent_Input.SendKeys("99");
                    Assert.True(divide_Msg.Displayed, "divide message in not displayed");
                    Hishtalmut_TlooyGil_track_Precent_Input.Clear();
                    Hishtalmut_TlooyGil_track_Precent_Input.SendKeys("101");
                    Assert.True(divide_Msg.Displayed, "divide message in not displayed");
                    Hishtalmut_TlooyGil_track_Precent_Input.Clear();
                    Hishtalmut_TlooyGil_track_Precent_Input.SendKeys("50");
                    Hishtalmut_Menayot_track_precent_Input.SendKeys("50");
                    Assert.True(!divide_Msg.Displayed, "divide message is displayed");
                    step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    TracksList = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    Assert.True(TracksList.Exists(o => o.MaslulDescription.Contains("מנוהל תלוי גיל") || o.MaslulDescription.Contains("מניות")), "the track that chosen is not writing correct in db");
                    foreach (var item in TracksList)
                    {
                        Assert.True(item.PercentHafkada == "50" && item.PercentItra == "50", "the percent for each track was not eriting correctly");
                    }
                    Assert.True(TracksList.Count == 2);

                    //stage 3
                    Confirm_Btn.Click();
                    Assert.True(Driver.Url.Contains("step3"), "move to step 4 without otp and approve agreement");

                    string obj_otp = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.TransactionID == obj.TransactionID).Select(o => o.OTP).FirstOrDefault();

                    Otp_Input.SendKeys(obj_otp);
                    Confirm_Btn.Click();
                    Assert.True(Driver.Url.Contains("step3"), "move to step 4 without approve agreement");
                    IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
                    js.ExecuteScript("arguments[0].scrollIntoView(true);", Statment_CheckBox);
                    Statment_CheckBox.Click();
                    Confirm_Btn.Click();

                    //stage 4
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step4");
                    Assert.True(Confirm_Msg.Displayed, "confirm message is not displayed");
                    int? obj_StepNumber = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.TransactionID == obj.TransactionID).Select(o => o.StepNumber).FirstOrDefault();
                    Assert.True(obj_StepNumber == 4, "step number is not correct in db in the end of the proccess");
                    bool? obj_ApproveAgreement = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.TransactionID == obj.TransactionID).Select(o => o.ApproveAgreement).FirstOrDefault();
                    Assert.True(obj_ApproveAgreement, "approve agreement is not 1 in db");


                    DateTime time = DateTime.Now;
                    //js.ExecuteScript("arguments[0].scrollIntoView(true);", Pdf_Link);

                    js.ExecuteScript("scroll(-300,0);");
                    WaitForElement(Pdf_Link, TimeSpan.FromSeconds(60), Driver);
                    Pdf_Link.Click();
                    Thread.Sleep(4000);


                    DateTime lastUpdate_File;
                    string FileName = returnLast_FileName(out lastUpdate_File);

                    Assert.True(lastUpdate_File.Date.Equals(time.Date), "last file was not download");
                    Assert.True(lastUpdate_File.Hour.Equals(time.Hour), "last file was not download");
                }

            }
            catch (Exception e)
            {
                lineFailure_Num = GetLineNumber_Fail(e);
                tc.ReciveLineFailure(lineFailure_Num);
                throw e;
            }
        }

        public void Gemel_Lehashkaa_Change_Of_Investment_E2E()
        {
            int UserId = int.Parse(GetXmlOneValue("Gemel_LehashkaaID"));

            try
            {
                //stage 1
                Forward_Btn.Click();
                Assert.True(Driver.Url.Contains("step1"), "you can forward to the next step whitout choosing any account");
                Gemel_Lehashkaa_Account.Click();
                Forward_Btn.Click();

                //stage 2 
                Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step2");
                using (MigdalSiteEntities context = new MigdalSiteEntities())
                {
                    Tbl_ShinuiMaslul_Transaction obj = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.UserID == UserId).OrderByDescending(o => o.StartProcessDate).FirstOrDefault();
                    Tbl_ShinuiMaslul_TransactionToFund obj_found = context.Tbl_ShinuiMaslul_TransactionToFund.Where(o => o.TransactionID == obj.TransactionID).FirstOrDefault();
                    AcoountNumber = obj_found.FundID;
                    string AcoountNumber2 = AcoountNumber.ToString();
                    Assert.True(Account_Indicate_title.Text.Contains(AcoountNumber2), "the account number that shown is not the account that chosen");

                    //try to move next step without choosing track or one of the 3 options
                    step2Forward_Btn.Click();
                    Assert.True(Driver.Url.Contains("step2"), "you can forward to the next step whitout choosing track or one of the 3 options");
                    Gemel_Lehashkaa_Klali_track_precent_Input.SendKeys("100");
                    step2Forward_Btn.Click();
                    Assert.True(Driver.Url.Contains("step2"), "you can forward to the next step whitout choosing one of 3 options ");
                    Gemel_Lehashkaa_Klali_track_precent_Input.Clear();
                    ItraTzvura.Click();
                    step2Forward_Btn.Click();
                    Assert.True(Driver.Url.Contains("step2"), "you can forward to the next step whitout choosing track ");

                    //verify all 3 option is writing in DB 
                    //tzvura & hafkadot
                    ItraTzvura_And_HafkadotShotfot.Click();
                    Gemel_Lehashkaa_Klali_track_precent_Input.SendKeys("100");
                    step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    List<Tbl_ShinuiMaslul_TransactionFundMaslul> obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True((item.PercentItra != "0" && item.PercentItra != null) && (item.PercentHafkada != "0" && item.PercentHafkada != null), "picking the tzvura and hafkdaot option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();
                    //itra only
                    ItraTzvura.Click();
                    Gemel_Lehashkaa_Klali_track_precent_Input.Clear();
                    Gemel_Lehashkaa_Klali_track_precent_Input.SendKeys("100");
                    step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True((item.PercentItra != "0" && item.PercentItra != null) && (item.PercentHafkada == "0" || item.PercentHafkada == null), "picking only  tzvura  option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();
                    //hafkadot only
                    HafkadotShotfot.Click();
                    step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True((item.PercentItra == "0" || item.PercentItra == null) && (item.PercentHafkada != "0" && item.PercentHafkada != null), "picking only hafkdaot option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();

                    //check all the tracks
                    ItraTzvura.Click();
                    Gemel_Lehashkaa_Klali_track_precent_Input.Clear();
                    Gemel_Lehashkaa_Klali_track_precent_Input.SendKeys("10");
                    Gemel_Lehashkaa_Hagah_Ad10Menayot_track_precent_Input.SendKeys("10");
                    Gemel_Lehashkaa_ShikliTvach_Katzar_track_precent_Input.SendKeys("10");
                    Gemel_Lehashkaa_HagahMimshalti_track_precent_Input.SendKeys("10");
                    Gemel_Lehashkaa_Khool_track__precent_Input.SendKeys("10");
                    Gemel_Lehashkaa_Menayot_track_precent_Input.SendKeys("10");
                    Gemel_Lehashkaa_Halacha_track_precent_Input.SendKeys("40");
                    step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    List<Tbl_ShinuiMaslul_TransactionFundMaslul> TracksList = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    Assert.True(TracksList.Count == 7, "not all the selected tracks is writing in the db");
                    Back_Link_Btn.Click();

                    //clear all tracks
                    Gemel_Lehashkaa_Klali_track_precent_Input.Clear();
                    Gemel_Lehashkaa_Klali_track_precent_Input.Clear();
                    Gemel_Lehashkaa_Hagah_Ad10Menayot_track_precent_Input.Clear();
                    Gemel_Lehashkaa_ShikliTvach_Katzar_track_precent_Input.Clear();
                    Gemel_Lehashkaa_HagahMimshalti_track_precent_Input.Clear();
                    Gemel_Lehashkaa_Khool_track__precent_Input.Clear();
                    Gemel_Lehashkaa_Menayot_track_precent_Input.Clear();
                    Gemel_Lehashkaa_Halacha_track_precent_Input.Clear();

                    //pick klali track + check divid message                    
                    ItraTzvura_And_HafkadotShotfot.Click();
                    Gemel_Lehashkaa_Klali_track_precent_Input.SendKeys("50");
                    Assert.True(divide_Msg.Displayed, "divide message in not displayed");
                    Gemel_Lehashkaa_Klali_track_precent_Input.Clear();
                    Gemel_Lehashkaa_Klali_track_precent_Input.SendKeys("99");
                    Assert.True(divide_Msg.Displayed, "divide message in not displayed");
                    Gemel_Lehashkaa_Klali_track_precent_Input.Clear();
                    Gemel_Lehashkaa_Klali_track_precent_Input.SendKeys("101");
                    Assert.True(divide_Msg.Displayed, "divide message in not displayed");
                    Gemel_Lehashkaa_Klali_track_precent_Input.Clear();
                    Gemel_Lehashkaa_Klali_track_precent_Input.SendKeys("50");
                    Gemel_Lehashkaa_Menayot_track_precent_Input.SendKeys("50");
                    Assert.True(!divide_Msg.Displayed, "divide message is displayed");
                    step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    TracksList = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    Assert.True(TracksList.Exists(o => o.MaslulDescription.Contains("כללי") || o.MaslulDescription.Contains("מניות")), "the track that chosen is not writing correct in db");
                    foreach (var item in TracksList)
                    {
                        Assert.True(item.PercentHafkada == "50" && item.PercentItra == "50", "the percent for each track was not eriting correctly");
                    }
                    Assert.True(TracksList.Count == 2);

                    //stage 3
                    Confirm_Btn.Click();
                    Assert.True(Driver.Url.Contains("step3"), "move to step 4 without otp and approve agreement");

                    string obj_otp = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.TransactionID == obj.TransactionID).Select(o => o.OTP).FirstOrDefault();


                    Otp_Input.SendKeys(obj_otp);
                    Confirm_Btn.Click();
                    Assert.True(Driver.Url.Contains("step3"), "move to step 4 without approve agreement");
                    IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
                    js.ExecuteScript("arguments[0].scrollIntoView(true);", Statment_CheckBox);
                    Statment_CheckBox.Click();
                    Confirm_Btn.Click();

                    //stage 4
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step4");
                    Assert.True(Confirm_Msg.Displayed, "confirm message is not displayed");
                    int? obj_StepNumber = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.TransactionID == obj.TransactionID).Select(o => o.StepNumber).FirstOrDefault();
                    Assert.True(obj_StepNumber == 4, "step number is not correct in db in the end of the proccess");
                    bool? obj_ApproveAgreement = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.TransactionID == obj.TransactionID).Select(o => o.ApproveAgreement).FirstOrDefault();
                    Assert.True(obj_ApproveAgreement, "approve agreement is not 1 in db");


                    DateTime time = DateTime.Now;
                    //js.ExecuteScript("arguments[0].scrollIntoView(true);", Pdf_Link);                    

                    js.ExecuteScript("scroll(-300,0);");
                    WaitForElement(Pdf_Link, TimeSpan.FromSeconds(60), Driver);
                    Pdf_Link.Click();
                    Thread.Sleep(4000);


                    DateTime lastUpdate_File;
                    string FileName = returnLast_FileName(out lastUpdate_File);

                    Assert.True(lastUpdate_File.Date.Equals(time.Date), "last file was not download");
                    Assert.True(lastUpdate_File.Hour.Equals(time.Hour), "last file was not download");
                }
            }
            catch (Exception e)
            {
                lineFailure_Num = GetLineNumber_Fail(e);
                tc.ReciveLineFailure(lineFailure_Num);
                throw e;
            }
        }

        public void Keshet_Change_Of_Investment_E2E()
        {
            int UserId = int.Parse(GetXmlOneValue("KeshetID"));

            try
            {
                //stage 1
                Forward_Btn.Click();
                Assert.True(Driver.Url.Contains("step1"), "you can forward to the next step whitout choosing any account");
                KeshetAccount.Click();
                Forward_Btn.Click();

                //stage 2 
                Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step_bp");
                using (MigdalSiteEntities context = new MigdalSiteEntities())
                {
                    Tbl_ShinuiMaslul_Transaction obj = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.UserID == UserId).OrderByDescending(o => o.StartProcessDate).FirstOrDefault();
                    Tbl_ShinuiMaslul_TransactionToFund obj_found = context.Tbl_ShinuiMaslul_TransactionToFund.Where(o => o.TransactionID == obj.TransactionID).FirstOrDefault();
                    AcoountNumber = obj_found.FundID;
                    string AcoountNumber2 = AcoountNumber.ToString();
                    Assert.True(Keshet_Account_Indicate_title.Text.Contains(AcoountNumber2), "the account number that shown is not the account that chosen");

                    //try to move next step without choosing track or one of the 3 options
                    Keshet_step2Forward_Btn.Click();
                    Assert.True(Driver.Url.Contains("step_bp"), "you can forward to the next step whitout choosing track or one of the 3 options");
                    Keshet_Hagah_Ad10_Menayot_track_CheckBox.Click();
                    Keshet_step2Forward_Btn.Click();
                    Assert.True(Driver.Url.Contains("step_bp"), "you can forward to the next step whitout choosing one of 3 options ");
                    Keshet_Hagah_Ad10_Menayot_track_CheckBox.Click();
                    Keshet_FeautersPayments_comp.Click();
                    Keshet_step2Forward_Btn.Click();
                    Assert.True(Driver.Url.Contains("step_bp"), "you can forward to the next step whitout choosing track ");

                    //verify all 2 option is writing in DB 
                    //features payments             
                    Keshet_Menayot_track_Checkbox.Click();
                    Keshet_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    List<Tbl_ShinuiMaslul_TransactionFundMaslul> obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.AfrashaPrat == true && item.AfkadaAllSum == true && item.AfkadaType == 0, "picking feauters payments  option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();

                    //tzvira kayemet 
                    Keshet_FeautersPayments_comp.Click();
                    Keshet_TzviraKayemet_comp.Click();
                    Keshet_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.AfrashaPrat == true && item.AfkadaAllSum == true && item.AfkadaType == 2, "picking tzvira kayemet  option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();

                    //tzvira kayemet + features payments
                    Keshet_FeautersPayments_comp.Click();
                    Keshet_TzviraKayemet_comp.Click();
                    Keshet_FeautersPayments_comp.Click();
                    Keshet_TzviraKayemet_comp.Click();
                    Keshet_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.AfrashaPrat == true && item.AfkadaAllSum == true && item.AfkadaType == 2, "picking tzvira kayemet + features payments  option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();
                    IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
                    js.ExecuteScript("scroll(-300,0);");
                    Keshet_Menayot_track_Checkbox.Click();

                    //pick each track and verify in db 
                    //klali
                    Keshet_Klali_track_CheckBox.Click();
                    Keshet_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.MaslulDescription.Contains("כללי"), "picking tzvira kayemet + features payments  option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");
                    Keshet_Klali_track_CheckBox.Click();

                    //10% menayot
                    Keshet_Hagah_Ad10_Menayot_track_CheckBox.Click();
                    Keshet_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.MaslulDescription.Contains("10"), "picking tzvira kayemet + features payments  option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");
                    Keshet_Hagah_Ad10_Menayot_track_CheckBox.Click();

                    //25% menayot
                    Keshet_Hagah_Ad25_Menayot_track_Checkbox.Click();
                    Keshet_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.MaslulDescription.Contains("25"), "picking tzvira kayemet + features payments  option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");
                    Keshet_Hagah_Ad25_Menayot_track_Checkbox.Click();

                    //menayot
                    Keshet_Menayot_track_Checkbox.Click();
                    Keshet_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.MaslulDescription.Contains("מניות"), "picking tzvira kayemet + features payments  option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");
                    Keshet_Menayot_track_Checkbox.Click();

                    //hagah mhimshelet israel
                    Keshet_Hagah_MimsheletIsrael_track_Checkbox.Click();
                    Keshet_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.MaslulDescription.Contains("ישראל"), "picking tzvira kayemet + features payments  option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");
                    Keshet_Hagah_MimsheletIsrael_track_Checkbox.Click();

                    //halacha
                    Keshet_Halacha_track_Checkbox.Click();
                    Keshet_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.MaslulDescription.Contains("הלכה"), "picking tzvira kayemet + features payments  option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");
                    Keshet_Halacha_track_Checkbox.Click();

                    //halacha
                    Keshet_khool_track_Checkbox.Click();
                    Keshet_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.MaslulDescription.Contains("חו"), "picking tzvira kayemet + features payments  option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");
                    Keshet_khool_track_Checkbox.Click();

                    //hagah
                    Keshet_Hagah_track_Checkbox.Click();
                    Keshet_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.MaslulDescription.Contains("אג"), "picking tzvira kayemet + features payments  option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");
                    Keshet_Hagah_track_Checkbox.Click();

                    //shikli
                    Keshet_Shikli_TvachKatzar_track_Checkbox.Click();
                    Keshet_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.MaslulDescription.Contains("שקלי"), "picking tzvira kayemet + features payments  option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");
                    Keshet_Shikli_TvachKatzar_track_Checkbox.Click();

                    //logout and login again 
                    WebExitBtn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "HomePage");
                    LoginPage.LoginAction(GetXmlOneValue("KeshetID"), GetXmlOneValue("KeshetPassword"));
                    personal_details_rikuz_pof.Click_On_ShinuiMaslul();

                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step1");
                    KeshetAccount.Click();
                    Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step_bp");
                    obj = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.UserID == UserId).OrderByDescending(o => o.StartProcessDate).FirstOrDefault();

                    Keshet_FeautersPayments_comp.Click();
                    js.ExecuteScript("scroll(-300,0);");
                    Keshet_Klali_track_CheckBox.Click();
                    Keshet_Hagah_Ad10_Menayot_track_CheckBox.Click();
                    Keshet_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    Assert.True(obj_options_list.Count == 1, "you can pick more than 1 track");

                    //stage 3
                    Confirm_Btn.Click();
                    Assert.True(Driver.Url.Contains("step3"), "move to step 4 without otp and approve agreement");

                    string obj_otp = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.TransactionID == obj.TransactionID).Select(o => o.OTP).FirstOrDefault();


                    Otp_Input.SendKeys(obj_otp);
                    Confirm_Btn.Click();
                    Assert.True(Driver.Url.Contains("step3"), "move to step 4 without approve agreement");
                    js = (IJavaScriptExecutor)Driver;
                    js.ExecuteScript("arguments[0].scrollIntoView(true);", Statment_CheckBox);
                    Statment_CheckBox.Click();
                    Confirm_Btn.Click();

                    //stage 4
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step4");
                    Assert.True(Confirm_Msg.Displayed, "confirm message is not displayed");
                    int? obj_StepNumber = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.TransactionID == obj.TransactionID).Select(o => o.StepNumber).FirstOrDefault();
                    Assert.True(obj_StepNumber == 4, "step number is not correct in db in the end of the proccess");
                    bool? obj_ApproveAgreement = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.TransactionID == obj.TransactionID).Select(o => o.ApproveAgreement).FirstOrDefault();
                    Assert.True(obj_ApproveAgreement, "approve agreement is not 1 in db");


                    DateTime time = DateTime.Now;
                    //js.ExecuteScript("arguments[0].scrollIntoView(true);", Pdf_Link);               
                    js.ExecuteScript("scroll(-300,0);");
                    WaitForElement(Pdf_Link, TimeSpan.FromSeconds(60), Driver);
                    Pdf_Link.Click();
                    Thread.Sleep(4000);


                    DateTime lastUpdate_File;
                    string FileName = returnLast_FileName(out lastUpdate_File);

                    Assert.True(lastUpdate_File.Date.Equals(time.Date), "last file was not download");
                    Assert.True(lastUpdate_File.Hour.Equals(time.Hour), "last file was not download");
                }
            }
            catch (Exception e)
            {
                lineFailure_Num = GetLineNumber_Fail(e);
                tc.ReciveLineFailure(lineFailure_Num);
                throw e;
            }
        }

        public void Pension_Change_Of_Investment_E2E()
        {
            int UserId = int.Parse(GetXmlOneValue("PensionID"));

            try
            {
                //stage 1
                Forward_Btn.Click();
                Assert.True(Driver.Url.Contains("step1"), "you can forward to the next step without choosing any account");
                PensionAccount.Click();
                Forward_Btn.Click();

                //stage 2 
                Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step_bp");
                using (MigdalSiteEntities context = new MigdalSiteEntities())
                {
                    Tbl_ShinuiMaslul_Transaction obj = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.UserID == UserId).OrderByDescending(o => o.StartProcessDate).FirstOrDefault();
                    Tbl_ShinuiMaslul_TransactionToFund obj_found = context.Tbl_ShinuiMaslul_TransactionToFund.Where(o => o.TransactionID == obj.TransactionID).FirstOrDefault();
                    AcoountNumber = obj_found.FundID;
                    string AcoountNumber2 = AcoountNumber.ToString();
                    Assert.True(Pension_Account_Indicate_title.Text.Contains(AcoountNumber2), "the account number that shown is not the account that chosen");

                    //try to move next step without choosing track or one of the 3 options
                    Pension_step2Forward_Btn.Click();
                    Assert.True(Driver.Url.Contains("step_bp"), "you can forward to the next step whitout choosing track or one of the 3 options");
                    Pension_Menayot_track_Pitzuim_CheckBox.Click();
                    Pension_step2Forward_Btn.Click();
                    Assert.True(Driver.Url.Contains("step_bp"), "you can forward to the next step whitout choosing one of 3 options ");
                    Pension_Menayot_track_Pitzuim_CheckBox.Click();
                    Pension_FeautersPayments_comp.Click();
                    Pension_step2Forward_Btn.Click();
                    Assert.True(Driver.Url.Contains("step_bp"), "you can forward to the next step whitout choosing track ");

                    //verify all 2 option is writing in DB 
                    //features payments             
                    Pension_Menayot_track_Pitzuim_CheckBox.Click();
                    Pension_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    List<Tbl_ShinuiMaslul_TransactionFundMaslul> obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.AfrashaPrat == false && item.AfkadaAllSum == true && item.AfkadaType == 0, "picking feauters payments  option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();

                    //tzvira kayemet
                    Pension_FeautersPayments_comp.Click();
                    Pension_TzviraKayemet_comp.Click();
                    Pension_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.AfrashaPrat == false && item.AfkadaAllSum == true && item.AfkadaType == 2, "picking feauters payments  option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();

                    //tzvira kayemet + features payments 
                    Pension_FeautersPayments_comp.Click();
                    Pension_TzviraKayemet_comp.Click();
                    Pension_FeautersPayments_comp.Click();
                    Pension_TzviraKayemet_comp.Click();
                    Pension_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.AfrashaPrat == false && item.AfkadaAllSum == true && item.AfkadaType == 2, "picking feauters payments  option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();

                    //check each sug hafrasha
                    //only pitzuim
                    IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
                    js.ExecuteScript("scroll(-300,0);");
                    Pension_Menayot_track_Pitzuim_CheckBox.Click();
                    Pension_Shikli_track_Pitzuim_CheckBox.Click();
                    Pension_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    Assert.True(obj_options_list.Count == 1, "there is more than 1 row in db");
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.AfrashaPitzui == true && item.AfrashaTagmul == false, "sug hafrasha pitzui is not marked true in the db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");

                    //only tagmulim
                    Pension_Shikli_track_Pitzuim_CheckBox.Click();
                    Pension_Shikli_track_Tagmulim_CheckBox.Click();
                    Pension_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    Assert.True(obj_options_list.Count == 1, "there is more than 1 row in db");
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.AfrashaPitzui == false && item.AfrashaTagmul == true, "sug hafrasha tagmulim is not marked true in the db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");

                    //pitzuim + tagmulim
                    Pension_Shikli_track_Pitzuim_CheckBox.Click();
                    Pension_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    Assert.True(obj_options_list.Count == 2, "there are no 2 rows in db");
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.AfrashaPitzui == true || item.AfrashaTagmul == true, "sug hafrasha pitzuim + tagmulim is not marked true in the db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");

                    Pension_Shikli_track_Pitzuim_CheckBox.Click();
                    Pension_Shikli_track_Tagmulim_CheckBox.Click();

                    //pick each track and verify in db 
                    //menayot
                    Pension_Menayot_track_Pitzuim_CheckBox.Click();
                    Pension_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.MaslulDescription.Contains("מניות"), "the picking track is not writing in db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");

                    //shikli
                    Pension_Shikli_track_Pitzuim_CheckBox.Click();
                    Pension_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.MaslulDescription.Contains("שקלי"), "the picking track is not writing in db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");

                    //hagah
                    Pension_Hagah_track_Pitzuim_CheckBox.Click();
                    Pension_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.MaslulDescription.Contains("אג"), "the picking track is not writing in db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");

                    //halacha
                    Pension_Halacha_track_Pitzuim_CheckBox.Click();
                    Pension_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.MaslulDescription.Contains("הלכה"), "the picking track is not writing in db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");

                    //tlooy gil
                    Pension_TlooyGil_track_Pitzuim_CheckBox.Click();
                    Pension_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.MaslulDescription.Contains("גיל"), "the picking track is not writing in db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");

                    //50 and less 
                    Pension_50AndLess_track_Pitzuim_CheckBox.Click();
                    Pension_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.MaslulDescription.Contains("ומטה"), "the picking track is not writing in db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");

                    //50-60
                    Pension_50To60_track_Pitzuim_CheckBox.Click();
                    Pension_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.MaslulDescription.Contains("עד"), "the picking track is not writing in db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");

                    //60 and more 
                    Pension_60AndMore_track_Pitzuim_CheckBox.Click();
                    Pension_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.MaslulDescription.Contains("ומעלה"), "the picking track is not writing in db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");

                    Pension_60AndMore_track_Pitzuim_CheckBox.Click();

                    //check that you can choose track for pitzuim and different track for tagmulim
                    Pension_Hagah_track_Pitzuim_CheckBox.Click();
                    Pension_TlooyGil_track_Tagmulim_CheckBox.Click();
                    Pension_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    Assert.True(obj_options_list.Count == 2, "there are no 2 rows in db");
                    Assert.True(!obj_options_list[0].MaslulDescription.Equals(obj_options_list[1].MaslulDescription), "there are not 2 different track in db");

                    //logout and login again 
                    WebExitBtn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "HomePage");
                    LoginPage.LoginAction(GetXmlOneValue("PensionID"), GetXmlOneValue("PensionPassword"));
                    personal_details_rikuz_pof.Click_On_ShinuiMaslul();

                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step1");
                    PensionAccount.Click();
                    Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step_bp");
                    obj = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.UserID == UserId).OrderByDescending(o => o.StartProcessDate).FirstOrDefault();

                    js.ExecuteScript("scroll(-300,0);");
                    Pension_FeautersPayments_comp.Click();
                    Pension_Hagah_track_Pitzuim_CheckBox.Click();
                    Pension_Shikli_track_Tagmulim_CheckBox.Click();
                    Pension_step2Forward_Btn.Click();

                    //stage3
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    Confirm_Btn.Click();
                    Assert.True(Driver.Url.Contains("step3"), "move to step 4 without otp and approve agreement");

                    string obj_otp = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.TransactionID == obj.TransactionID).Select(o => o.OTP).FirstOrDefault();

                    Otp_Input.SendKeys(obj_otp);
                    Confirm_Btn.Click();
                    Assert.True(Driver.Url.Contains("step3"), "move to step 4 without approve agreement");
                    js = (IJavaScriptExecutor)Driver;
                    js.ExecuteScript("arguments[0].scrollIntoView(true);", Statment_CheckBox);
                    Statment_CheckBox.Click();
                    Confirm_Btn.Click();

                    //stage 4
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step4");
                    Assert.True(Confirm_Msg.Displayed, "confirm message is not displayed");
                    int? obj_StepNumber = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.TransactionID == obj.TransactionID).Select(o => o.StepNumber).FirstOrDefault();
                    Assert.True(obj_StepNumber == 4, "step number is not correct in db in the end of the proccess");
                    bool? obj_ApproveAgreement = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.TransactionID == obj.TransactionID).Select(o => o.ApproveAgreement).FirstOrDefault();
                    Assert.True(obj_ApproveAgreement, "approve agreement is not 1 in db");

                    DateTime time = DateTime.Now;
                    //js.ExecuteScript("arguments[0].scrollIntoView(true);", Pdf_Link);

                    js.ExecuteScript("scroll(-300,0);");
                    WaitForElement(Pdf_Link, TimeSpan.FromSeconds(60), Driver);
                    Pdf_Link.Click();
                    Thread.Sleep(4000);


                    DateTime lastUpdate_File;
                    string FileName = returnLast_FileName(out lastUpdate_File);

                    Assert.True(lastUpdate_File.Date.Equals(time.Date), "last file was not download");
                    Assert.True(lastUpdate_File.Hour.Equals(time.Hour), "last file was not download");

                }
            }
            catch (Exception e)
            {
                lineFailure_Num = GetLineNumber_Fail(e);
                tc.ReciveLineFailure(lineFailure_Num);
                throw e;
            }
        }

        public void BituahHaim_Change_Of_Investment_E2E()
        {
            int UserId = int.Parse(GetXmlOneValue("BituahHaimID"));

            try
            {
                //stage 1
                Forward_Btn.Click();
                Assert.True(Driver.Url.Contains("step1"), "you can forward to the next step without choosing any account");
                BituahHaimAccount.Click();
                Forward_Btn.Click();

                //stage 2 
                Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step_bp");
                using (MigdalSiteEntities context = new MigdalSiteEntities())
                {
                    Tbl_ShinuiMaslul_Transaction obj = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.UserID == UserId).OrderByDescending(o => o.StartProcessDate).FirstOrDefault();
                    Tbl_ShinuiMaslul_TransactionToFund obj_found = context.Tbl_ShinuiMaslul_TransactionToFund.Where(o => o.TransactionID == obj.TransactionID).FirstOrDefault();
                    AcoountNumber = obj_found.FundID;
                    string AcoountNumber2 = AcoountNumber.ToString();
                    Assert.True(BituahHaim_Account_Indicate_title.Text.Contains(AcoountNumber2), "the account number that shown is not the account that chosen");

                    //try to move next step without choosing track or one of the 3 options
                    BituahHaim_step2Forward_Btn.Click();
                    Assert.True(Driver.Url.Contains("step_bp"), "you can forward to the next step whitout choosing track or one of the 3 options");
                    BituahHaim_HagahAd10_men_track_Pitzuim_CheckBox.Click();
                    BituahHaim_step2Forward_Btn.Click();
                    Assert.True(Driver.Url.Contains("step_bp"), "you can forward to the next step whitout choosing one of 3 options ");
                    BituahHaim_HagahAd10_men_track_Pitzuim_CheckBox.Click();
                    BituahHaim_FeautersPayments_comp.Click();
                    BituahHaim_step2Forward_Btn.Click();
                    Assert.True(Driver.Url.Contains("step_bp"), "you can forward to the next step whitout choosing track ");

                    //verify all 2 option is writing in DB 
                    //features payments             
                    BituahHaim_HagahAd10_men_track_Pitzuim_CheckBox.Click();
                    BituahHaim_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    List<Tbl_ShinuiMaslul_TransactionFundMaslul> obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.AfrashaPrat == false && item.AfkadaAllSum == true && item.AfkadaType == 0, "picking feauters payments  option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();

                    //tzvira kayemet
                    BituahHaim_FeautersPayments_comp.Click();
                    BituahHaim_ItraTzvura_comp.Click();
                    BituahHaim_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.AfrashaPrat == false && item.AfkadaAllSum == true && item.AfkadaType == 2, "picking feauters payments  option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();

                    //tzvira kayemet + features payments 
                    BituahHaim_FeautersPayments_comp.Click();
                    BituahHaim_ItraTzvura_comp.Click();
                    BituahHaim_FeautersPayments_comp.Click();
                    BituahHaim_ItraTzvura_comp.Click(); ;
                    BituahHaim_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.AfrashaPrat == false && item.AfkadaAllSum == true && item.AfkadaType == 2, "picking feauters payments  option is not writing correct in db");
                    }
                    Back_Link_Btn.Click();

                    //check each sug hafrasha
                    //only pitzuim
                    IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
                    js.ExecuteScript("scroll(-300,0);");
                    BituahHaim_HagahAd10_men_track_Pitzuim_CheckBox.Click();
                    BituahHaim_Menayot_track_Pitzuim_CheckBox.Click();
                    BituahHaim_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    Assert.True(obj_options_list.Count == 1, "there is more than 1 row in db");
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.AfrashaPitzui == true && item.AfrashaTagmul == false, "sug hafrasha pitzui is not marked true in the db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");

                    //only tagmulim
                    BituahHaim_Menayot_track_Pitzuim_CheckBox.Click();
                    BituahHaim_Menayot_track_Tagmulim_CheckBox.Click();
                    BituahHaim_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    Assert.True(obj_options_list.Count == 1, "there is more than 1 row in db");
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.AfrashaPitzui == false && item.AfrashaTagmul == true, "sug hafrasha tagmulim is not marked true in the db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");

                    //pitzuim + tagmulim
                    BituahHaim_Menayot_track_Pitzuim_CheckBox.Click();
                    BituahHaim_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    Assert.True(obj_options_list.Count == 2, "there are no 2 rows in db");
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.AfrashaPitzui == true || item.AfrashaTagmul == true, "sug hafrasha pitzuim + tagmulim is not marked true in the db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");

                    BituahHaim_Menayot_track_Pitzuim_CheckBox.Click();
                    BituahHaim_Menayot_track_Tagmulim_CheckBox.Click();

                    //pick each track and verify in db 
                    //hagah ad 10%
                    BituahHaim_HagahAd10_men_track_Pitzuim_CheckBox.Click();
                    BituahHaim_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.MaslulDescription.Contains("10%"), "the picking track is not writing in db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");

                    //hagah ad 25%
                    BituahHaim_HagahAd25_men_track_Pitzuim_CheckBox.Click();
                    BituahHaim_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.MaslulDescription.Contains("25%"), "the picking track is not writing in db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");

                    //menayot
                    BituahHaim_Menayot_track_Pitzuim_CheckBox.Click();
                    BituahHaim_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.MaslulDescription.Contains("מניות"), "the picking track is not writing in db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");

                    //hagah mimshelet israel
                    BituahHaim_Hagah_Mimshelet_Israel_track_Pitzuim_CheckBox.Click();
                    BituahHaim_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    foreach (var item in obj_options_list)
                    {
                        Assert.True(item.MaslulDescription.Contains("ממשלת ישראל"), "the picking track is not writing in db");
                    }
                    Back_Link_Btn.Click();
                    js.ExecuteScript("scroll(-300,0);");

                    BituahHaim_Hagah_Mimshelet_Israel_track_Pitzuim_CheckBox.Click();
                    //check that you can choose track for pitzuim and different track for tagmulim
                    BituahHaim_HagahAd25_men_track_Pitzuim_CheckBox.Click();
                    BituahHaim_Hagah_Mimshelet_Israel_track_Tagmulim_CheckBox.Click();
                    BituahHaim_step2Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    obj_options_list = context.Tbl_ShinuiMaslul_TransactionFundMaslul.Where(o => o.TransactionID == obj.TransactionID).ToList();
                    Assert.True(obj_options_list.Count == 2, "there are no 2 rows in db");
                    Assert.True(!obj_options_list[0].MaslulDescription.Equals(obj_options_list[1].MaslulDescription), "there are not 2 different track in db");

                    //logout and login again 
                    WebExitBtn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "HomePage");
                    LoginPage.LoginAction(GetXmlOneValue("BituahHaimID"), GetXmlOneValue("BituahHaimPassword"));
                    personal_details_rikuz_pof.Click_On_ShinuiMaslul();

                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step1");
                    BituahHaimAccount.Click();
                    Forward_Btn.Click();
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step_bp");
                    obj = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.UserID == UserId).OrderByDescending(o => o.StartProcessDate).FirstOrDefault();

                    js.ExecuteScript("scroll(-300,0);");
                    BituahHaim_FeautersPayments_comp.Click();
                    BituahHaim_HagahAd25_men_track_Pitzuim_CheckBox.Click();
                    BituahHaim_Hagah_Mimshelet_Israel_track_Tagmulim_CheckBox.Click();
                    BituahHaim_step2Forward_Btn.Click();

                    //stage3
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step3");
                    Confirm_Btn.Click();
                    Assert.True(Driver.Url.Contains("step3"), "move to step 4 without otp and approve agreement");

                    string obj_otp = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.TransactionID == obj.TransactionID).Select(o => o.OTP).FirstOrDefault();

                    Otp_Input.SendKeys(obj_otp);
                    Confirm_Btn.Click();
                    Assert.True(Driver.Url.Contains("step3"), "move to step 4 without approve agreement");
                    js = (IJavaScriptExecutor)Driver;
                    js.ExecuteScript("arguments[0].scrollIntoView(true);", Statment_CheckBox);
                    Statment_CheckBox.Click();
                    Confirm_Btn.Click();

                    //stage 4
                    Wait_For_Next_Step(TimeSpan.FromSeconds(60), Driver, "step4");
                    Assert.True(Confirm_Msg.Displayed, "confirm message is not displayed");
                    int? obj_StepNumber = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.TransactionID == obj.TransactionID).Select(o => o.StepNumber).FirstOrDefault();
                    Assert.True(obj_StepNumber == 4, "step number is not correct in db in the end of the proccess");
                    bool? obj_ApproveAgreement = context.Tbl_ShinuiMaslul_Transaction.Where(o => o.TransactionID == obj.TransactionID).Select(o => o.ApproveAgreement).FirstOrDefault();
                    Assert.True(obj_ApproveAgreement, "approve agreement is not 1 in db");

                    DateTime time = DateTime.Now;
                    //js.ExecuteScript("arguments[0].scrollIntoView(true);", Pdf_Link);

                    js.ExecuteScript("scroll(-300,0);");
                    WaitForElement(Pdf_Link, TimeSpan.FromSeconds(60), Driver);
                    Pdf_Link.Click();
                    Thread.Sleep(4000);


                    DateTime lastUpdate_File;
                    string FileName = returnLast_FileName(out lastUpdate_File);

                    Assert.True(lastUpdate_File.Date.Equals(time.Date), "last file was not download");
                    Assert.True(lastUpdate_File.Hour.Equals(time.Hour), "last file was not download");

                }
            }
            catch (Exception e)
            {
                lineFailure_Num = GetLineNumber_Fail(e);
                tc.ReciveLineFailure(lineFailure_Num);
                throw e;
            }
        }
    }
}
