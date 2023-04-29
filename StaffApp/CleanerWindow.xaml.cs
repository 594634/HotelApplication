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
using no.hvl.DAT154.GROUP14.Hotel.API.Client;
using no.hvl.DAT154.GROUP14.Hotel.API.Common;
using no.hvl.DAT154.GROUP14.Hotel.API.Common.Model;

namespace StaffApp
{
    /// <summary>
    /// Interaction logic for CleanerWindow.xaml
    /// </summary>
    public partial class CleanerWindow : Window
    {
        private readonly Client client;

        private List<RoomDTO> Rooms;
        private List<NoteDTO> Notes;

        public CleanerWindow(Client client)
        {
            InitializeComponent();
            this.client = client;

            load();

        }

        private async Task load() {
            Rooms = (await client.roomController.GetAll()).ToList();
            Notes = (await client.noteController.GetAll()).ToList();

            updateView();
        }
        
        private void updateView()
        {
            cleanList.DataContext = Rooms.OrderBy(r => r.RoomNumber).Where(x => x.ToBeCleaned == true);
            noteList.DataContext = Notes.OrderBy(n => n.RoomNumber).Where(x => x.NoteType.ToString() == "Cleaner");
        }

        private void bfixed_Click(object sender, RoutedEventArgs e) {
            if (noteList.SelectedItem is not NoteDTO note)
                return; 
            client.noteController.Delete(note.NoteId.Value);
            Notes.Remove(note);
            
            updateView();
        }

        private void bcleaned_Click(object sender, RoutedEventArgs e) {
            if (cleanList.SelectedItem is not RoomDTO room)
                return;

            string cbstatus = (comboboxStatus.SelectedValue as ComboBoxItem).Content as string;
            room.Status = cbstatus;

            if(cbstatus == "Finished")
                room.ToBeCleaned = false;

            client.roomController.Update(room);
            
            updateView();

        }

        private void breload_Click(object sender, RoutedEventArgs e) {
            load();
        }
    }
}
