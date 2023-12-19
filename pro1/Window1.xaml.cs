using System;
using System.Collections.Generic;
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

namespace pro1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Performance performance = new Performance();
            performance.ShowDialog();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Actors actors = new Actors();
            actors.ShowDialog();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Employments employments = new Employments();
            employments.ShowDialog();
        }
    }
}
