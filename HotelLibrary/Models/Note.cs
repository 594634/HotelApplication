using System;
using System.Collections.Generic;

namespace HotelLibrary.Models;

public partial class Note
{
    public int NoteId { get; set; }

    public string Note1 { get; set; } = null!;

    public int RoomNumber { get; set; }

    public string NoteType { get; set; } = null!;

    public virtual Room RoomNumberNavigation { get; set; } = null!;
}
