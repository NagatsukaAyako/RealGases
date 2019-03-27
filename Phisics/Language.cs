using RealGases.Properties;

namespace RealGases
{
    class Language
    {
        public static void ChangeLanguage()
        {
            if (Settings.Default["lang"] as string == "ru") {
                Settings.Default["lang"] = "ua";
                Settings.Default.Save();
            } else {
                Settings.Default["lang"] = "ru";
                Settings.Default.Save();
            }
        }
    }
}
