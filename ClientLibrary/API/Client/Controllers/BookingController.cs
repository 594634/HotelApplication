using System.Text.Json;
using no.hvl.DAT154.GROUP14.Hotel.API.Common;
using no.hvl.DAT154.GROUP14.Hotel.API.Common.Model;

namespace no.hvl.DAT154.GROUP14.Hotel.API.Client.Controllers; 

public class BookingController {

    private readonly HttpClient client;

    public BookingController(HttpClient client) {
        this.client = client;
    }
    
    public async Task<IEnumerable<BookingDTO>?> GetAll() {
        string path = "api/booking";
        HttpResponseMessage message = await client.GetAsync(path);

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<IEnumerable<BookingDTO>>(await message.Content.ReadAsStreamAsync());
    }

    public async Task<BookingDTO?> Get(int id) {
        string path = $"api/booking/{id}";
        HttpResponseMessage message = await client.GetAsync(path);

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<BookingDTO>(await message.Content.ReadAsStreamAsync());
    }

    public async Task<BookingDTO?> Add(BookingDTO user) {
        const string path = "api/booking";
        HttpResponseMessage message = await client.PostAsync(path, new StringContent(JsonSerializer.Serialize(user)));

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<BookingDTO>(await message.Content.ReadAsStreamAsync());
    }

    public async Task<BookingDTO?> Update(BookingDTO user) {
        const string path = "api/booking";
        HttpResponseMessage message = await client.PutAsync(path, new StringContent(JsonSerializer.Serialize(user)));

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<BookingDTO>(await message.Content.ReadAsStreamAsync());
    }

    public async Task<BookingDTO?> Delete(int id) {
        string path = $"api/booking{id}";
        HttpResponseMessage message = await client.DeleteAsync(path);

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<BookingDTO>(await message.Content.ReadAsStreamAsync());
    }

}