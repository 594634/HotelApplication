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
    /// Interaction logic for CleanerWindow.xaml
    /// </summary>
    public partial class CleanerWindow : Window
    {
        public Demo1234Context dx = new();
        public Demo1234Context dc { get; set; }

        private readonly LocalView<Room> Rooms;
        private readonly LocalView<Note> Notes;

        private void updateView()
        {
            dx.Rooms.Load();
            dx.Notes.Load();
            cleanList.DataContext = Rooms.OrderBy(r => r.RoomNumber).Where(x => x.ToBeCleaned == true);
            noteList.DataContext = Notes.OrderBy(n => n.RoomNumber).Where(x => x.NoteType.ToString() == "Cleaner");
        }
        public CleanerWindow()
        {
            InitializeComponent();
            Rooms = dx.Rooms.Local;
            Notes = dx.Notes.Local;
            updateView();


        }

        private void bfixed_Click(object sender, RoutedEventArgs e)
        {
            Note n = noteList.SelectedItem as Note;
            Note dbNote = Notes.Where(no => no.NoteId == n.NoteId).First();
            dx.Notes.Remove(dbNote);
            dx.SaveChanges();
            updateView();

        }

        private void bcleaned_Click(object sender, RoutedEventArgs e)
        {
            Room r = cleanList.SelectedItem as Room;
            Room dbRoom = Rooms.Where(ro => ro.RoomNumber == r.RoomNumber).First();

            string cbstatus = (comboboxStatus.SelectedValue as ComboBoxItem).Content as string;
            dbRoom.Status = cbstatus;

            if(cbstatus == "Finished")
            {
                dbRoom.ToBeCleaned = false;
            }
            
            dx.Rooms.Update(dbRoom);
            dx.SaveChanges();
            updateView();

        }
    }
}
