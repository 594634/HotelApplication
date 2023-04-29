using System.Text.Json.Serialization;

namespace no.hvl.DAT154.GROUP14.Hotel.API.Common.Model; 

public class UserDTO {
    
    [JsonPropertyName("phoneNumber")]
    public int? PhoneNumber { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

}