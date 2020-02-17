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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exercise15
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

        private void ConvertSecondsToHoursMinutesSeconds(int originalSeconds, out int hours, out int minutes, out int seconds)
        {
            seconds = originalSeconds;
            hours = seconds / 3600;
            seconds %= 3600;
            minutes = seconds / 60;
            seconds %= 60;
        }

        private void ConvertButton_Click_1(object sender, RoutedEventArgs e)
        {
            int originalSeconds = Convert.ToInt32(secondsTextBox.Text);
            ConvertSecondsToHoursMinutesSeconds(originalSeconds, out int hours, out int minutes, out int seconds);
            MessageBox.Show(String.Format($"{originalSeconds} seconden is {hours} uur, {minutes} minuten en {seconds} seconden"));
        }
    }
}