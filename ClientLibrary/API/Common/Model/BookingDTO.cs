using System.Text.Json.Serialization;

namespace no.hvl.DAT154.GROUP14.Hotel.API.Common.Model; 

public class BookingDTO {

    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("phoneNumber")]
    public int? PhoneNumber { get; set; }

    [JsonPropertyName("checkedIn")]
    public bool? CheckedIn { get; set; }

    [JsonPropertyName("roomNumber")]
    public int? RoomNumber { get; set; }

    [JsonPropertyName("datoInsjekk")]
    public DateTime? DatoInsjekk { get; set; }

    [JsonPropertyName("datoUtsjekk")]
    public DateTime? DatoUtsjekk { get; set; }
    
}