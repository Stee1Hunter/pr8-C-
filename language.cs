using System.Windows;
using System;

public class LanguageManager
{
    private ResourceDictionary _currentLanguageResources;

    public void ChangeLanguage(string culture)
    {
        if (culture == "ru")
        {
            _currentLanguageResources = new ResourceDictionary()
            {
                Source = new Uri("languageEng.xaml", UriKind.Relative)
            };

            culture = "eng";
            Application.Current.Resources.MergedDictionaries.Add(_currentLanguageResources);
        }
        else if (culture == "eng")
        {
            _currentLanguageResources = new ResourceDictionary()
            {
                Source = new Uri("LanguageRu.xaml", UriKind.Relative)
            };

            culture = "ru";
            Application.Current.Resources.MergedDictionaries.Add(_currentLanguageResources);
        }
    }
}