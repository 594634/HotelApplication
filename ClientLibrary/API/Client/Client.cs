using no.hvl.DAT154.GROUP14.Hotel.API.Client.Controllers;

namespace no.hvl.DAT154.GROUP14.Hotel.API.Client;

public class Client {

    private HttpClient client;

    public UserController userController { get; }
    public BookingController bookingController { get; }
    public RoomController roomController { get; }
    public NoteController noteController { get; }

    public Client(string url) {
        client = new HttpClient() {
            BaseAddress = new Uri(url)
        };

        userController = new UserController(client);
        bookingController = new BookingController(client);
        roomController = new RoomController(client);
        noteController = new NoteController(client);
    }

}