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
using no.hvl.DAT154.GROUP14.Hotel.API.Client;
using no.hvl.DAT154.GROUP14.Hotel.API.Common.Model;

namespace StaffApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Demo1234Context dx = new();
        private readonly Client client;

        public MainWindow()
        {
            InitializeComponent();
            client = new Client("http://localhost:5241");
        }

        private void bcleaner_Click(object sender, RoutedEventArgs e) {
            CleanerWindow cw = new(client);
            cw.Show();
        }

        private void bmaintenance_Click(object sender, RoutedEventArgs e) {
            MaintenanceWindow mw = new(client);
            mw.Show();
        }

        private void bservice_Click(object sender, RoutedEventArgs e) {
            ServiceWindow sw = new(client);
            sw.Show();
        }

        private void badd_Click(object sender, RoutedEventArgs e)
        {
            NoteDTO note = new(){
                Message = tnote.Text, 
                RoomNumber = int.Parse(troomnumber.Text), 
                NoteType = (comboboxCategory.SelectedValue as ComboBoxItem).Content as string
            };
            client.noteController.Add(note);
        }
    }


}
