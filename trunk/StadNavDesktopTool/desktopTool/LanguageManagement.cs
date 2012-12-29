using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace StadNavDesktopTool
{
    class LanguageManagement
    {
        private static BindingList<Language> languages = new BindingList<Language>();

        public static void LoadFromFile(string path)
        {
            Stream stream = File.Open(path, FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            languages = bFormatter.Deserialize(stream) as BindingList<Language>;
            stream.Flush();
            stream.Close();
        }

        public static bool RemoveLanguage(int iLanguageID)
        {
            foreach (Language language in languages)
            {
                if (language.ID == iLanguageID)
                {
                    languages.Remove(language);
                    return true;
                }
            }

            return false;
        }

        public static Language GetLanguage(int iLanguageID)
        {
            foreach(Language language in languages)
            {
                if (language.ID == iLanguageID)
                    return language;
            }

            return null;
        }

        public static void SaveToFile(string path)
        {
            Stream stream = File.Open(path, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, languages);
            stream.Flush();
            stream.Close();
        }

        public static BindingList<Language> GetAllLanguages()
        {
            return languages;
        }

        public static void UpdateLanguage(Language language)
        {
            languages.Remove(language);
            languages.Add(language);
        }

        public static bool AddLanguage(int iLanguageID, string strLanguageName)
        {
            if (GetLanguage(iLanguageID) == null)
            {
                languages.Add(new Language(iLanguageID, strLanguageName));
                return true;
            }
            else
                return false;
            
        }

        public static void AddLanguage(Language newLanguage)
        {
            languages.Add(newLanguage);
        }
    }
}
