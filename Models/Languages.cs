
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class Language
    {
        public string DisplayName { get; set; }
        public string ShortName { get; set; }

    }
    public static class Languages
    {
        public const string English = "en";
        public const string Dutch = "nl";
        public const string German = "de";
        public const string Portuguese = "pt";

        private static readonly List<Language> available = new()
        {
            new Language { DisplayName = "English", ShortName = English },
            new Language { DisplayName = "Nederlands - Dutch", ShortName = Dutch },
            new Language { DisplayName = "Deutsche - German", ShortName = German },
            new Language { DisplayName = "Português - Portuguese", ShortName = Portuguese}
        };

        public static List<Language> Available { get => available; }
        public static int IndexOf(string languageCode)
        {
            int index = available.FindIndex(a => a.ShortName == languageCode);
            if (index < 0) index = 0; // set to English if not found
            return index;
        }
    }
}
