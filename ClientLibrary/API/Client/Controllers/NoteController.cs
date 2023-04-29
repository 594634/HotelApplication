using System.Net;
using System.Net.Http.Json;
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

        
        string path = $"api/note/search?{query}";
        HttpResponseMessage message = await client.GetAsync(path);

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<NoteDTO>(await message.Content.ReadAsStreamAsync());
    }

    public async Task<NoteDTO?> Add(NoteDTO note) {
        const string path = "api/note";
        HttpResponseMessage message = await client.PostAsJsonAsync(path, note);

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<NoteDTO>(await message.Content.ReadAsStreamAsync());
    }

    public async Task<NoteDTO?> Update(NoteDTO note) {
        string path = $"api/note/{note.NoteId}";
        HttpResponseMessage message = await client.PutAsJsonAsync(path, note);

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<NoteDTO>(await message.Content.ReadAsStreamAsync());
    }

    public async Task<NoteDTO?> Delete(int id) {
        string path = $"api/note/{id}";
        HttpResponseMessage message = await client.DeleteAsync(path);

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<NoteDTO>(await message.Content.ReadAsStreamAsync());
    }

}