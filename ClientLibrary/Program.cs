using no.hvl.DAT154.GROUP14.Hotel.API.Client;
using no.hvl.DAT154.GROUP14.Hotel.API.Common.Model;

Client client = new("http://localhost:5241");

await client.userController.Add(new UserDTO() {
    PhoneNumber = 888,
    Name = "Hans",
    Type = "Gjest"
});

Console.WriteLine((await client.userController.GetAll()).FirstOrDefault(u => u.Name == "Hans"));

/*Console.Write("Users: ");
foreach (UserDTO user in await client.userController.GetAll()) 
    Console.Write($"[Phone:{user.PhoneNumber} Name:{user.Name}, Type:{user.Type}] ");
Console.WriteLine();

Console.Write("Booking: ");
foreach (BookingDTO booking in await client.bookingController.GetAll()) 
    Console.Write($"[ID:{booking.Id} User:{booking.PhoneNumber} Room:{booking.RoomNumber}] ");
Console.WriteLine();

Console.Write("Rooms: ");
foreach (RoomDTO room in await client.roomController.GetAll()) 
    Console.Write($"[ID:{room.RoomNumber}] ");
Console.WriteLine();

Console.Write("Notes: ");
foreach (NoteDTO note in await client.noteController.GetAll()) 
    Console.Write($"[ID:{note.NoteId}] ");
Console.WriteLine();*/
