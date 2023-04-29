using System.Text.Json.Serialization;

namespace no.hvl.DAT154.GROUP14.Hotel.API.Common.Model; 

public class RoomDTO {
    
    
    [JsonPropertyName("roomNumber")]
    public int? RoomNumber { get; set; }

    [JsonPropertyName("floor")]
    public int? Floor { get; set; }

    [JsonPropertyName("numberOfPeople")]
    public int? NumberOfPeople { get; set; }

    [JsonPropertyName("booked")]
    public bool? Booked { get; set; }

    [JsonPropertyName("toBeCleaned")]
    public bool? ToBeCleaned { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    //public virtual ICollection<Note> Notes { get; set; } = new List<Note>();

    //public virtual ICollection<Reservasjon> Reservasjons { get; set; } = new List<Reservasjon>();

}