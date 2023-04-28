using HotelLibrary.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResepsjonWinForm
{
    public partial class ManageBookingsForm : Form
    {
        private readonly Demo1234Context dx = new();
        public ManageBookingsForm db { get; set; }

        private readonly LocalView<Reservasjon> reservasjon;
        public ManageBookingsForm()
        {
            InitializeComponent();
            

        }

        private void reservationListView_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }
    }
}
