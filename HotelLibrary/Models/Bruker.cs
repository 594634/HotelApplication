using System;
using System.Collections.Generic;

namespace HotelLibrary.Models;

public partial class Bruker
{
    public int PhoneNumber { get; set; }

    public string? Name { get; set; }

    public string TypeBruker { get; set; } = null!;

    public virtual ICollection<Reservasjon> Reservasjons { get; set; } = new List<Reservasjon>();
}
