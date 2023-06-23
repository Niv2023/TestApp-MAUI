
using LocalizationResourceManager.Maui;


namespace TestApp.Models
{
    public static class AppData
    {
        static ILocalizationResourceManager LocResMgr;

        private static string appLanguage;
        public static string Language
        {
            get
            {
                return appLanguage;
            }
            set
            {
                appLanguage = value;
                if (LocResMgr.CurrentCulture.TwoLetterISOLanguageName != appLanguage)
                {
                    LocResMgr.CurrentCulture = new System.Globalization.CultureInfo(appLanguage);
                }
            }
        }

        public static void Init(ILocalizationResourceManager localizationResource)
        {
            LocResMgr = localizationResource;
            Language = Languages.English;
        }
    }
}
