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
using no.hvl.DAT154.GROUP14.Hotel.API.Common.Model;

namespace StaffApp
{
    /// <summary>
    /// Interaction logic for ServiceWindow.xaml
    /// </summary>
    public partial class ServiceWindow : Window {
        private readonly Client client;

        private List<NoteDTO> Notes;

        public ServiceWindow(Client client)
        {
            InitializeComponent();
            this.client = client;

            load();
        }

        private async Task load() {
            Notes = (await client.noteController.GetAll()).ToList();
            updateView();
        }
        
        private void updateView()
        {
            serviceList.DataContext = Notes.OrderBy(r => r.RoomNumber).Where(x => x.NoteType.ToString() == "Service");
        }

        private void bfixed_Click(object sender, RoutedEventArgs e) {
            if (serviceList.SelectedItem is not NoteDTO note)
                return;
            client.noteController.Delete(note.NoteId.Value);
            Notes.Remove(note);
            
            updateView();

        }

        private void Breload_Click(object sender, RoutedEventArgs e) {
            load();
        }
    }
}
