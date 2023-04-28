namespace ResepsjonWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkinButton_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {

        }

        private void manageRoomsButton_Click(object sender, EventArgs e)
        {
            ManageRoomsForm mrf = new();
            mrf.Show();
        }

        private void manageBooking_Click(object sender, EventArgs e)
        {
            ManageBookingsForm mbf = new();
            mbf.Show();
        }
    }
}