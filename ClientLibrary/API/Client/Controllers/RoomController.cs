using System.Globalization;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using System.Web;
using no.hvl.DAT154.GROUP14.Hotel.API.Common;
using no.hvl.DAT154.GROUP14.Hotel.API.Common.Model;

namespace no.hvl.DAT154.GROUP14.Hotel.API.Client.Controllers; 

public class RoomController {

    private readonly HttpClient client;

    public RoomController(HttpClient client) {
        this.client = client;
    }
    
    public async Task<IEnumerable<RoomDTO>?> GetAll() {
        string path = "api/room";
        HttpResponseMessage message = await client.GetAsync(path);

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<IEnumerable<RoomDTO>>(await message.Content.ReadAsStringAsync());
    }

    public async Task<RoomDTO?> Get(int id) {
        string path = $"api/room/{id}";
        HttpResponseMessage message = await client.GetAsync(path);

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<RoomDTO>(await message.Content.ReadAsStreamAsync());
    }

    public async Task<RoomDTO?> Search(DateTime? checkin, DateTime? checkout) {
        List<string> vars = new();
        if (checkin is DateTime) 
            vars.Add($"checkin={HttpUtility.HtmlEncode(checkin?.ToString("s", CultureInfo.InvariantCulture))}");
        if (checkout is DateTime) 
            vars.Add($"checkout{HttpUtility.HtmlEncode(checkout?.ToString("s", CultureInfo.InvariantCulture))}");
        string query = string.Join("&", vars);
        
        if (string.IsNullOrEmpty(query))
            throw new APIException("Query is empty", HttpStatusCode.BadRequest);
        
        string path = $"api/room/search?{query}";
        HttpResponseMessage message = await client.GetAsync(path);

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<RoomDTO>(await message.Content.ReadAsStreamAsync());
    }

    public async Task<RoomDTO?> Add(RoomDTO room) {
        string path = "api/room";
        HttpResponseMessage message = await client.PostAsJsonAsync(path, room);

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<RoomDTO>(await message.Content.ReadAsStreamAsync());
    }

    public async Task<RoomDTO?> Update(RoomDTO room) {
        string path = $"api/room/{room.RoomNumber}";
        HttpResponseMessage message = await client.PutAsJsonAsync(path, room);//.PutAsync(path, new StringContent(JsonSerializer.Serialize(room)));

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<RoomDTO>(await message.Content.ReadAsStreamAsync());
    }

    public async Task<RoomDTO?> Delete(int id) {
        string path = $"api/room{id}";
        HttpResponseMessage message = await client.DeleteAsync(path);

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<RoomDTO>(await message.Content.ReadAsStreamAsync());
    }

}