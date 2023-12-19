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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace pro1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<object> person;
        XDocument doc;
        public MainWindow()
        {
            InitializeComponent();
            doc = XDocument.Load("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\auth.xml");
            var authen = (from x in doc.Element("authentications").Elements("auth")
                          orderby x.Element("login").Value
                          select new
                          {
                              Логин = x.Element("login").Value,
                              Пароль = x.Element("password").Value,
                          }).ToList();

            person = new ObservableCollection<object>(authen);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            doc = XDocument.Load("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\auth.xml");
            XElement root = doc.Element("authentications");
            foreach (XElement ho in root.Elements("auth"))
            {
                if (ho.Element("login").Value == txtBox.Text)
                {
                    if (ho.Element("password").Value == passBox.Password)
                    {
                        Window1 window1 = new Window1();
                        window1.ShowDialog();
                        this.Visibility = Visibility.Hidden;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                        break;
                    }
                }
                //else
                //{
                //    MessageBox.Show("Неверный логин или пароль");
                //}
            }

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            doc.Element("authentications").Add(new XElement("auth",
                new XElement("login", txtBox.Text),
                new XElement("password", passBox.Password)));
            doc.Save("C:\\Users\\Varya\\Desktop\\верстка\\pro1\\tables\\auth.xml");
            MessageBox.Show("Новые данные добавлены");
            person.Add(new Auths { Логин = txtBox.Text, Пароль = passBox.Password });
            Window1 window1 = new Window1();
            window1.ShowDialog();
            this.Visibility = Visibility.Hidden;
        }
    }
}

public class Auths
{
    public string Логин { get; set; }
    public string Пароль { get; set; }
}