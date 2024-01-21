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
using System.Windows.Navigation;
using System.Windows.Shapes;
using AudioDevices.Tracks;
using AudioDevices.Devices;

namespace Tester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void NieuwTrack(object sender, RoutedEventArgs e)
        {
            nieuwtrack nieuwTrackWindow = new nieuwtrack();
            nieuwTrackWindow.Show();
        }
        public void TrackList(object sender, RoutedEventArgs e)
        {
            nieuwtracklist nieuwtracklistwindow = new nieuwtracklist();
            nieuwtracklistwindow.Show();
        }
    }
}