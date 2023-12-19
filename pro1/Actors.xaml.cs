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

namespace pro1
{
    /// <summary>
    /// Логика взаимодействия для Actors.xaml
    /// </summary>
    public partial class Actors : Window
    {
        public ObservableCollection<object> person;
        XDocument doc;
        XDocument doc2;
        XDocument doc3;
        public Actors()
        {
            InitializeComponent();
            New();
            doc = XDocument.Load("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\actors.xml");
            var actors = (from x in doc.Element("actors").Elements("actor")
                         orderby x.Element("code").Value
                         select new
                         {
                             Код = x.Element("code").Value,
                             Фамилия = x.Element("surname").Value,
                             Имя = x.Element("name").Value,
                             Отчество = x.Element("patronymic").Value,
                             Звание = x.Element("rank").Value,
                             Стаж = x.Element("experience").Value,
                             Год = x.Element("year").Value,
                             БазоваяЗп = x.Element("salary").Value,
                             Премия = x.Element("prize").Value
                         }).ToList();

            person = new ObservableCollection<object>(actors);

            dg.ItemsSource = person;
        }

        public void New()
        {

            doc = XDocument.Load("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\employmentofactors.xml");
            XElement a = doc.Element("employments");
            doc2 = XDocument.Load("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\actors.xml");
            XElement b = doc2.Element("actors");
            foreach (XElement x in a.Elements("employm"))
            {
                foreach (XElement y in b.Elements("actor"))
                {
                    if (y.Element("code").Value == x.Element("code").Value && y.Element("year").Value == x.Element("year").Value)
                    {
                    int cost = int.Parse(x.Element("cost").Value);
                    int salary = cost / 12;
                    y.Element("salary").Value = salary.ToString();
                    doc2.Save("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\actors.xml");
                    }
                    
                }
 
            }


            doc = XDocument.Load("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\employmentofactors.xml");
            XElement c = doc.Element("employments");
            doc2 = XDocument.Load("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\actors.xml");
            XElement d = doc2.Element("actors");
            foreach (XElement x in c.Elements("employm"))
            {
                foreach (XElement y in d.Elements("actor"))
                {
                    if (y.Element("code").Value == x.Element("code").Value && y.Element("year").Value == x.Element("year").Value)
                    {

                        int cost = int.Parse(x.Element("cost").Value);
                        int play = int.Parse(x.Element("play").Value);
                        int experience = int.Parse(y.Element("experience").Value);

                        float prem = ((cost / 12) * play / 100 * 5) / 100 * (experience + 100);
                        y.Element("prize").Value = prem.ToString();
                        doc2.Save("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\actors.xml");
                    }

                }

            }






            doc = XDocument.Load("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\actors.xml");
            var actors = (from x in doc.Element("actors").Elements("actor")
                          orderby x.Element("code").Value
                          select new
                          {
                              Код = x.Element("code").Value,
                              Фамилия = x.Element("surname").Value,
                              Имя = x.Element("name").Value,
                              Отчество = x.Element("patronymic").Value,
                              Звание = x.Element("rank").Value,
                              Стаж = x.Element("experience").Value,
                              Год = x.Element("year").Value,
                              БазоваяЗп = x.Element("salary").Value,
                              Премия = x.Element("prize").Value
                          }).ToList();

            person = new ObservableCollection<object>(actors);

            dg.ItemsSource = person;




            





        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            doc.Element("actors").Add(new XElement("actor",
                new XElement("code", textid.Text),
                new XElement("surname", textfam.Text),
                new XElement("name", textname.Text),
                new XElement("patronymic", textotc.Text),
                new XElement("rank", textzva.Text),
                new XElement("experience", textsta.Text),
                new XElement ("year", textyear.Text),
                new XElement("salary", textbaze.Text),
                new XElement("prize", textprize.Text)));
            doc.Save("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\actors.xml");
            MessageBox.Show("Новые данные добавлены");
            person.Add(new Person { Код = textid.Text, Фамилия = textfam.Text, Имя = textname.Text, Отчество = textotc.Text, Звание = textzva.Text, Стаж = textsta.Text, Год = textyear.Text, БазоваяЗп = textbaze.Text, Премия = textprize.Text });
        }

        //private void Button1_Click1(object sender, RoutedEventArgs e)
        //{
        //    doc = XDocument.Load("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\actors.xml");
        //    XElement root = doc.Element("actors");
        //    foreach (XElement ho in root.Elements("actor"))
        //    {
        //        if (ho.Element("surname").Value == textfam.Text)
        //        {
        //            if (ho.Element("name").Value == textname.Text)
        //            {
        //                textblockBobo.Text = "ура";
        //                MessageBox.Show("Новые данные добавлены");
        //                break;
        //            }
        //            else
        //            {
        //                textblockBobo.Text = "не ура";
        //            }
        //        }
        //    }
                
        //} 
        private void Button2_Click(object sender, RoutedEventArgs e)
        {

            var actorsCount = (from x in doc.Element("actors").Elements("actor")
                              where (string)x.Element("code") == sort.Text
                              select new
                              {
                                  Код = x.Element("code").Value,
                                  Фамилия = x.Element("surname").Value,
                                  Имя = x.Element("name").Value,
                                  Отчество = x.Element("patronymic").Value,
                                  Звание = x.Element("rank").Value,
                                  Стаж = x.Element("experience").Value,
                                  Год = x.Element("year").Value,
                                  БазоваяЗп = x.Element("salary").Value,
                                  Премия = x.Element("prize").Value
                              }).ToList();
            dg.ItemsSource = actorsCount;
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            dg.ItemsSource = person;
        }

        //private void Button4_Click(object sender, RoutedEventArgs e)
        //{
        //    doc = XDocument.Load("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\actors.xml");
        //    XElement root = doc.Element("actors");
        //    foreach (XElement x in root.Elements("actor"))
        //    {
        //        if (x.Element("code").Value == sort_change.Text)
        //        {
        //            if (x.Element("experience").Value != "")
        //            {
        //                x.Element("experience").Value = textsta_change.Text;
        //                MessageBox.Show("Изменено");
        //                doc.Save("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\actors.xml");
        //                New();
        //            }
        //        }
                    
        //    }
        //}

    


        //private void Buttonzp_Click(object sender, RoutedEventArgs e)
        //{  
        //    doc = XDocument.Load("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\employmentofactors.xml");
        //    XElement a = doc.Element("employments");
        //    foreach (XElement y in a.Elements("employm"))
        //    {
        //        if (y.Element("code").Value == zp.Text)
        //        {
        //            int cost = int.Parse(y.Element("cost").Value);
        //            int salary = cost / 12;
        //            doc = XDocument.Load("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\actors.xml");
        //            XElement b = doc.Element("actors");
        //            foreach (XElement z in b.Elements("actor"))
        //            {
        //                if (z.Element("code").Value == y.Element("code").Value)
        //                {
        //                    z.Element("salary").Value = salary.ToString();
        //                }
        //            }
        //        }
        //    }
        //    doc.Save("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\actors.xml");
        //    New();
        //}

        private void Buttonsearchyear_Click(object sender, RoutedEventArgs e)
        {
            var yearsCount = (from x in doc.Element("actors").Elements("actor")
                               where (string)x.Element("year") == sort_year.Text
                               select new
                               {
                                   Код = x.Element("code").Value,
                                   Фамилия = x.Element("surname").Value,
                                   Имя = x.Element("name").Value,
                                   Отчество = x.Element("patronymic").Value,
                                   Звание = x.Element("rank").Value,
                                   Стаж = x.Element("experience").Value,
                                   Год = x.Element("year").Value,
                                   БазоваяЗп = x.Element("salary").Value,
                                   Премия = x.Element("prize").Value
                               }).ToList();
            dg.ItemsSource = yearsCount;
        }

        private void Buttondelall_Click(object sender, RoutedEventArgs e)
        {
            doc = XDocument.Load("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\actors.xml");
            XElement root = doc.Element("actors");
            foreach (XElement x in root.Elements("actor"))
            {
                if ((x.Element("code").Value == textcode_del.Text) && (x.Element("year").Value == textyear_del.Text))
                {
                    MessageBoxResult result = MessageBox.Show("Вы уверены?", "Подтвердить",
                        MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        x.Remove();
                        doc.Save("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\actors.xml");

                        New();
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




public class Person
{
    public string Код { get; set; }
    public string Фамилия { get; set; }
    public string Имя { get; set; }
    public string Отчество { get; set; }
    public string Звание { get; set; }
    public string Стаж { get; set; }
    public string Год { get; set; }
    public string БазоваяЗп { get; set; }
    public string Премия { get; set; }

}