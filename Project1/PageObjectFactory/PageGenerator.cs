using OpenQA.Selenium.Support.PageObjects;
using Project1.WrapperFactory;
using Project1.PageObjectFactory;


namespace Project1.PageObjectFactory
{
    public class PageGenerator : BrowserFactory
    {
        private static T GetPage<T>() where T : new()
        {
            T page = new T();
            PageFactory.InitElements(Driver, page);
            return page;
        }

        public static Login_POF LoginPage
        {
            get { return GetPage<Login_POF>(); }
        }

        public static ContactPage_POF ContactPage_pof
        {
            get { return GetPage<ContactPage_POF>(); }
        }

        public static FindAgent_POF FindAgent_pof
        {
            get { return GetPage<FindAgent_POF>(); }
        }

        public static PersonalDetails_Rikuz_POF personal_details_rikuz_pof
        {
            get { return GetPage<PersonalDetails_Rikuz_POF>(); }
        }

        public static ShinuiMaslul_POF shinui_maslul_pof
        {
            get { return GetPage<ShinuiMaslul_POF>(); }
        }
    }
}
