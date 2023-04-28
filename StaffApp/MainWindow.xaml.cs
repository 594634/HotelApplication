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
using HotelLibrary;
using HotelLibrary.Models;
using Microsoft.EntityFrameworkCore;
using static Azure.Core.HttpHeader;

namespace StaffApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Demo1234Context dx = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void bcleaner_Click(object sender, RoutedEventArgs e)
        {
            CleanerWindow cw = new()
            {
                dc = dx
            };
            cw.Show();
        }

        private void bmaintenance_Click(object sender, RoutedEventArgs e)
        {
            MaintenanceWindow mw = new()
            {
                dm = dx
            };
            mw.Show();
        }

        private void bservice_Click(object sender, RoutedEventArgs e)
        {
            ServiceWindow sw = new()
            {
                ds = dx
            };
            sw.Show();
        }

        private void badd_Click(object sender, RoutedEventArgs e)
        {       
            
            Note n = WPFwindow.NewNote(tnote.Text, int.Parse(troomnumber.Text), (comboboxCategory.SelectedValue as ComboBoxItem).Content as string);

            dx.Notes.Add(n);
            dx.SaveChanges();
        }
    }


}
