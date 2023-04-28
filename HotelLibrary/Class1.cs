using HotelLibrary.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.IdentityModel.Tokens;

namespace HotelLibrary
{
    public class MakeDatabaseConnection
    {
        private readonly Demo1234Context dx = new();

        private readonly LocalView<Bruker> bruker;
        private readonly LocalView<Note> note;
        private readonly LocalView<Reservasjon> reservasjon;
        private readonly LocalView<Room> room;

        public Demo1234Context databasevindu(Demo1234Context dx)
        {

            return dx;

        }

    }
    public class WPFwindow
    {
       
        
        public static Note NewNote(string note1, int rn, string type)
        {
            Note note = new()
            {
                Note1 = note1,
                RoomNumber = rn,
                NoteType = type
            };

            return note;
        }

    }

    public class WinForm
    {

    }

    public class WindowsForms
    {

    }
}