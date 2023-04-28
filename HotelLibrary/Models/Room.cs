using System;
using System.Collections.Generic;

namespace HotelLibrary.Models;

public partial class Room
{
    public int RoomNumber { get; set; }

    public int Floor { get; set; }

    public int NumberOfPeople { get; set; }

    public bool Booked { get; set; }

    public bool ToBeCleaned { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<Note> Notes { get; set; } = new List<Note>();

    public virtual ICollection<Reservasjon> Reservasjons { get; set; } = new List<Reservasjon>();
}
