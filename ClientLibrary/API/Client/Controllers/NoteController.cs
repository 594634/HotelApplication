using System.Net;
using System.Text.Json;
using System.Web;
using no.hvl.DAT154.GROUP14.Hotel.API.Common;
using no.hvl.DAT154.GROUP14.Hotel.API.Common.Model;

namespace no.hvl.DAT154.GROUP14.Hotel.API.Client.Controllers; 

public class NoteController {

    private readonly HttpClient client;

    public NoteController(HttpClient client) {
        this.client = client;
    }
    
    public async Task<IEnumerable<NoteDTO>?> GetAll() {
        string path = "api/note";
        HttpResponseMessage message = await client.GetAsync(path);

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<IEnumerable<NoteDTO>>(await message.Content.ReadAsStreamAsync());
    }

    public async Task<NoteDTO?> Get(int id) {
        string path = $"api/note/{id}";
        HttpResponseMessage message = await client.GetAsync(path);

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<NoteDTO>(await message.Content.ReadAsStreamAsync());
    }

    public async Task<NoteDTO?> Search(int? room, string? type, string? contains) { 
        List<string> vars = new();
        if (room is int) 
            vars.Add($"room={HttpUtility.HtmlEncode(room)}");
        if (type is string) 
            vars.Add($"type={HttpUtility.HtmlEncode(type)}");
        if (contains is string) 
            vars.Add($"contains={HttpUtility.HtmlEncode(contains)}");
        string query = string.Join("&", vars);
        
        if (string.IsNullOrEmpty(query))
            throw new APIException("Query is empty", HttpStatusCode.BadRequest);

        
        string path = $"api/note/query?{query}";
        HttpResponseMessage message = await client.GetAsync(path);

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<NoteDTO>(await message.Content.ReadAsStreamAsync());
    }

    public async Task<NoteDTO?> Add(NoteDTO user) {
        const string path = "api/note";
        HttpResponseMessage message = await client.PostAsync(path, new StringContent(JsonSerializer.Serialize(user)));

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<NoteDTO>(await message.Content.ReadAsStreamAsync());
    }

    public async Task<NoteDTO?> Update(NoteDTO user) {
        const string path = "api/note";
        HttpResponseMessage message = await client.PutAsync(path, new StringContent(JsonSerializer.Serialize(user)));

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<NoteDTO>(await message.Content.ReadAsStreamAsync());
    }

    public async Task<NoteDTO?> Delete(int id) {
        string path = $"api/note{id}";
        HttpResponseMessage message = await client.DeleteAsync(path);

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<NoteDTO>(await message.Content.ReadAsStreamAsync());
    }

}