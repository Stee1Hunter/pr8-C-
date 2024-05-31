using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace pr8

{
    public class da
    {
        public string Txt;
        public da(string Txt) 
        {
            this.Txt = Txt;
        }
    }
    public partial class MainWindow : Window
    {
        private DataSerializer _serializer = new DataSerializer();
        private LanguageManager _languageManager = new LanguageManager();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveDataButton_Click(object sender, RoutedEventArgs e)
        {

            _serializer.Serialize(new da(ex1.Text));

            MessageBox.Show("Данные успешно сохранены.");
        }

        private void LoadDataButton_Click(object sender, RoutedEventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string jsonData = File.ReadAllText(path);

            if (!string.IsNullOrEmpty(jsonData))
            {
                var deserializedData = _serializer.Deserialize<List<string>>(jsonData);

                foreach (var item in deserializedData)
                {
                    MessageBox.Show(item);
                }
            }
            else
            {
                MessageBox.Show("Данные не удалось загрузить.");
            }
        }

        private void ChangeLanguageButtonRu_Click(object sender, RoutedEventArgs e)
        {
            _languageManager.ChangeLanguage("ru");

            save.Content = "сохранить";
            load.Content = "загрузить";
            languageEng.Content = "английский";
            languageRu.Content = "русский";
            MessageBox.Show("Язык интерфейса изменен на русский.");
        }
        private void ChangeLanguageButtonEng_Click(object sender, RoutedEventArgs e)
        {
            _languageManager.ChangeLanguage("eng");

            save.Content = "save";
            load.Content = "load";
            languageEng.Content = "eng";
            languageRu.Content = "ru";
            MessageBox.Show("Language switched to eng.");
        }
    }
}
