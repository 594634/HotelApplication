using System.Text.Json.Serialization;

namespace no.hvl.DAT154.GROUP14.Hotel.API.Common.Model; 

public class NoteDTO {

    [JsonPropertyName("noteId")]
    public int? NoteId { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; } = null!;

    [JsonPropertyName("roomNumber")]
    public int? RoomNumber { get; set; }
    
    [JsonPropertyName("noteType")]
    public string? NoteType { get; set; } = null!;
    
}