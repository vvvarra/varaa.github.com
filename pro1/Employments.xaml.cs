using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace pro1
{
    /// <summary>
    /// Логика взаимодействия для Employments.xaml
    /// </summary>
    public partial class Employments : Window
    {
        public ObservableCollection<object> empl;
        XDocument dcm;
        public Employments()
        {
            InitializeComponent();
            Pipu();

        }


        private void Pipu()
        {
            dcm = XDocument.Load("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\employmentofactors.xml");
            var eofa = (from x in dcm.Element("employments").Elements("employm")
                         orderby x.Element("code").Value
                         select new
                         {
                             КодАктера = x.Element("code").Value,
                             КодСпектакля = x.Element("codeper").Value,
                             Роль = x.Element("role").Value,
                             СтоимостьГодовогоКонтракта = x.Element("cost").Value,
                             Год = x.Element("year").Value,
                             КолвоОтырганныхРолей = x.Element("play").Value
                         }).ToList();

            empl = new ObservableCollection<object>(eofa);

            datag.ItemsSource = empl;
        }
        

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            var perfsCount = (from x in dcm.Element("employments").Elements("employm")
                              where (string)x.Element("code") == textid.Text
                              select new
                              {
                                  КодАктера = x.Element("code").Value,
                                  КодСпектакля = x.Element("codeper").Value,
                                  Роль = x.Element("role").Value,
                                  СтоимостьГодовогоКонтракта = x.Element("cost").Value,
                                  Год = x.Element("year").Value,
                                  КолвоОтырганныхРолей = x.Element("play").Value
                              }).ToList();
            datag.ItemsSource = perfsCount;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            datag.ItemsSource = empl;
        }

        private void Buttonyear_Click(object sender, RoutedEventArgs e)
        {
            var yearsCount = (from x in dcm.Element("employments").Elements("employm")
                              where (string)x.Element("year") == textid.Text
                              select new
                              {
                                  КодАктера = x.Element("code").Value,
                                  КодСпектакля = x.Element("codeper").Value,
                                  Роль = x.Element("role").Value,
                                  СтоимостьГодовогоКонтракта = x.Element("cost").Value,
                                  Год = x.Element("year").Value,
                                  КолвоОтырганныхРолей = x.Element("play").Value
                              }).ToList();
            datag.ItemsSource = yearsCount;
        }

        private void ButtonPlay_Click(object sender, RoutedEventArgs e)
        {
            dcm = XDocument.Load("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\employmentofactors.xml");
            XElement root = dcm.Element("employments");
            foreach (XElement x in root.Elements("employm"))
            {
                if ((x.Element("code").Value == text_code.Text) && (x.Element("year").Value == textchange_year.Text))
                {
                    if (x.Element("play").Value != "")
                    {
                        x.Element("play").Value = textchange_play.Text;
                        MessageBox.Show("Изменено");
                        dcm.Save("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\employmentofactors.xml");
                        Pipu();
                    }
                }

            }
        }

        private void Buttonplus_Click(object sender, RoutedEventArgs e)
        {
            dcm.Element("employments").Add(new XElement("employm",
            new XElement("code", textcode.Text),
               new XElement("codeper", text_codeper.Text),
               new XElement("role", textpole.Text),
               new XElement("cost", textcost.Text),
               new XElement("year", tyear.Text),
               new XElement("play", textplays.Text)));
            dcm.Save("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\employmentofactors.xml");
            MessageBox.Show("Новые данные добавлены");
            empl.Add(new Emp { КодАктера = textcode.Text, КодСпектакля = text_codeper.Text, Роль = textpole.Text, СтоимостьГодовогоКонтракта = textcost.Text, Год = tyear.Text, КолвоОтырганныхРолей = textplays.Text });
        }

        private void Buttondel_Click(object sender, RoutedEventArgs e)
        {
            dcm = XDocument.Load("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\employmentofactors.xml");
            XElement root = dcm.Element("employments");
            foreach (XElement x in root.Elements("employm"))
            {
                if ((x.Element("code").Value == textid_del.Text) && (x.Element("year").Value == textyear_del.Text))
                {
                    MessageBoxResult result = MessageBox.Show("Вы уверены?", "Подтвердить",
                        MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        x.Remove();
                        dcm.Save("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\employmentofactors.xml");

                        Pipu();
                        MessageBox.Show("Данные удалены", "", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}


public class Emp
{
    public string КодАктера { get; set; }
    public string КодСпектакля { get; set; }
    public string Роль { get; set; }
    public string СтоимостьГодовогоКонтракта { get; set; }
    public string Год { get; set; }
    public string КолвоОтырганныхРолей { get; set; }
}
