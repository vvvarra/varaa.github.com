using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace pro1
{
    /// <summary>
    /// Логика взаимодействия для Performance.xaml
    /// </summary>
    public partial class Performance : Window
    {

        public ObservableCollection<object> perf;
        XDocument docum;
        public Performance()
        {
            InitializeComponent();

            Boom();
        }

        private void Boom()
        {
            docum = XDocument.Load("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\performance.xml");
            var per = (from x in docum.Element("performance").Elements("perf")
                       orderby x.Element("codeper").Value
                       select new
                       {
                           КодСпектакля = x.Element("codeper").Value,
                           Название = x.Element("name").Value,
                           ГодПостановки = x.Element("year").Value,
                           Бюджет = x.Element("budget").Value
                       }).ToList();

            perf = new ObservableCollection<object>(per);

            dgr.ItemsSource = perf;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            docum.Element("performance").Add(new XElement("perf",
               new XElement("codeper", textidper.Text),
               new XElement("name", textnm.Text),
               new XElement("year", textyear.Text),
               new XElement("budget", textbudg.Text)));
            docum.Save("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\performance.xml");
            MessageBox.Show("Новые данные добавлены");
            perf.Add(new Perform { КодСпектакля = textidper.Text, Название = textnm.Text, ГодПостановки = textyear.Text, Бюджет = textbudg.Text});
        }


        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            docum = XDocument.Load("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\performance.xml");
            XElement root = docum.Element("performance");
            foreach (XElement x in root.Elements("perf"))
            {
                if (x.Element("codeper").Value == textidper_del.Text)
                {
                    MessageBoxResult result = MessageBox.Show("Вы уверены?", "Подтвердить",
                        MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        x.Remove();
                        docum.Save("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\performance.xml");

                        Boom();
                        MessageBox.Show("Данные удалены", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {

                    }
                }
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {

            var perfsCount = (from x in docum.Element("performance").Elements("perf")
                               where (string)x.Element("codeper") == sort.Text
                               select new
                               {
                                   КодСпектакля = x.Element("codeper").Value,
                                   Название = x.Element("name").Value,
                                   ГодПостановки = x.Element("year").Value,
                                   Бюджет = x.Element("budget").Value
                               }).ToList();
            dgr.ItemsSource = perfsCount;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            dgr.ItemsSource = perf;
        }

        private void Buttonyear_Click(object sender, RoutedEventArgs e)
        {
            var yearsCount = (from x in docum.Element("performance").Elements("perf")
                              where (string)x.Element("year") == sort_year.Text
                              select new
                              {
                                  КодСпектакля = x.Element("codeper").Value,
                                  Название = x.Element("name").Value,
                                  ГодПостановки = x.Element("year").Value,
                                  Бюджет = x.Element("budget").Value
                              }).ToList();
            dgr.ItemsSource = yearsCount;
        }
    }
}

public class Perform
{
    public string КодСпектакля { get; set; }
    public string Название { get; set; }
    public string ГодПостановки { get; set; }
    public string Бюджет { get; set; }
}