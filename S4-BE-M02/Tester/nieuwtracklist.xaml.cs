﻿using System;
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
    /// Interaction logic for nieuwtracklist.xaml
    /// </summary>
    public partial class nieuwtracklist : Window
    {
        public nieuwtracklist()
        {
            InitializeComponent();
        }

        public void ShuffleTracks(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
        }
        public void ClearTrackList(object sender, RoutedEventArgs e)
        {

        }

        private void TrackGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
