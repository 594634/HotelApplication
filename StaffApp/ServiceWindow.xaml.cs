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

namespace StaffApp
{
    /// <summary>
    /// Interaction logic for ServiceWindow.xaml
    /// </summary>
    public partial class ServiceWindow : Window
    {
        private readonly Demo1234Context dx = new();
        public Demo1234Context ds { get; set; }

        private readonly LocalView<Note> Notes;

        private void updateView()
        {
            dx.Notes.Load();
            serviceList.DataContext = Notes.OrderBy(r => r.RoomNumber).Where(x => x.NoteType.ToString() == "Service");
        }
        public ServiceWindow()
        {
            InitializeComponent();
            Notes = dx.Notes.Local;
            updateView();
        }

        private void bfixed_Click(object sender, RoutedEventArgs e)
        {
            Note n = serviceList.SelectedItem as Note;
            Note dbNote = Notes.Where(no => no.NoteId == n.NoteId).First();
            dx.Notes.Remove(dbNote);
            dx.SaveChanges();
            updateView();

        }
    }
}
