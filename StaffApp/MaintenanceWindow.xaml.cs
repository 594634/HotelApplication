using HotelLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
using static Azure.Core.HttpHeader;

namespace StaffApp
{
    /// <summary>
    /// Interaction logic for MaintenanceWindow.xaml
    /// </summary>
    public partial class MaintenanceWindow : Window
    {
        private readonly Demo1234Context dx = new();
        public Demo1234Context dm { get; set; }

        private readonly LocalView<Note> Notes;

        private void updateView()
        {
            dx.Notes.Load();
            maintenanceList.DataContext = Notes.OrderBy(n => n.RoomNumber).Where(x => x.NoteType.ToString() == "Maintenance");
        }
        public MaintenanceWindow()
        {
            InitializeComponent();
            Notes = dx.Notes.Local;
            updateView();
        }

        private void bfixed_Click(object sender, RoutedEventArgs e)
        {
            Note n = maintenanceList.SelectedItem as Note;
            Note dbNote = Notes.Where(no => no.NoteId == n.NoteId).First();
            dx.Notes.Remove(dbNote);
            dx.SaveChanges();
            updateView();
        }
    }
}
