using System.Net.Http.Json;
using System.Text.Json;
using no.hvl.DAT154.GROUP14.Hotel.API.Common;
using no.hvl.DAT154.GROUP14.Hotel.API.Common.Model;

namespace no.hvl.DAT154.GROUP14.Hotel.API.Client.Controllers; 

public class UserController {

    private readonly HttpClient client;

    public UserController(HttpClient client) {
        this.client = client;
    }
    
    public async Task<IEnumerable<UserDTO>?> GetAll() {
        string path = "api/user";
        HttpResponseMessage message = await client.GetAsync(path);

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<IEnumerable<UserDTO>>(await message.Content.ReadAsStreamAsync());
    }

    public async Task<UserDTO?> Get(int id) {
        string path = $"api/user/{id}";
        HttpResponseMessage message = await client.GetAsync(path);

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<UserDTO>(await message.Content.ReadAsStreamAsync());
    }

    public async Task<UserDTO?> Add(UserDTO user) {
        string path = "api/user";
        HttpResponseMessage message = await client.PostAsJsonAsync(path, user);

        if (!message.IsSuccessStatusCode)
            throw new APIException(await message.Content.ReadAsStringAsync(), message.StatusCode);
        
        return JsonSerializer.Deserialize<UserDTO>(await message.Content.ReadAsStreamAsync());
    }

    public async Task<UserDTO?> Update(UserDTO user) {
        string path = $"api/user/{user.PhoneNumber}";
        HttpResponseMessage message = await client.PutAsJsonAsync(path, user);

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<UserDTO>(await message.Content.ReadAsStreamAsync());
    }

    public async Task<UserDTO?> Delete(int id) {
        string path = $"api/user{id}";
        HttpResponseMessage message = await client.DeleteAsync(path);

        if (!message.IsSuccessStatusCode)
            throw new APIException(message.ReasonPhrase!, message.StatusCode);
        
        return JsonSerializer.Deserialize<UserDTO>(await message.Content.ReadAsStreamAsync());
    }

}