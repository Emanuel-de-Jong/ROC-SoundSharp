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

namespace Tester
{
    /// <summary>
    /// Interaction logic for nieuwtrack.xaml
    /// </summary>
    public partial class nieuwtrack : Window
    {
        public nieuwtrack()
        {
            InitializeComponent();
        }
        private void secondenClick(object sender, RoutedEventArgs e)
        {
            LengteStackPanel.SetValue(Grid.RowProperty, 0);
            Seconden.Visibility = Visibility.Visible;
            Minuten.Visibility = Visibility.Hidden;
            Uren.Visibility = Visibility.Hidden;
        }
        private void minutenClick(object sender, RoutedEventArgs e)
        {
            LengteStackPanel.SetValue(Grid.RowProperty, 1);
            Seconden.Visibility = Visibility.Visible;
            Minuten.Visibility = Visibility.Visible;
            Uren.Visibility = Visibility.Hidden;
        }
        private void urenClick(object sender, RoutedEventArgs e)
        {
            LengteStackPanel.SetValue(Grid.RowProperty, 2);
            Seconden.Visibility = Visibility.Visible;
            Minuten.Visibility = Visibility.Visible;
            Uren.Visibility = Visibility.Visible;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            


        }
        private void UploadClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
