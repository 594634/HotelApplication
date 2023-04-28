using System;
using System.Collections.Generic;

namespace HotelLibrary.Models;

public partial class Reservasjon
{
    public int Id { get; set; }

    public int PhoneNumber { get; set; }

    public bool CheckedIn { get; set; }

    public int RoomNumber { get; set; }

    public DateTime DatoInsjekk { get; set; }

    public DateTime DatoUtsjekk { get; set; }

    public virtual Bruker PhoneNumberNavigation { get; set; } = null!;

    public virtual Room RoomNumberNavigation { get; set; } = null!;
}
