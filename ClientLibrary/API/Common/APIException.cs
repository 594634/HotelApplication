using System.Net;

namespace no.hvl.DAT154.GROUP14.Hotel.API.Common; 

public class APIException : HttpRequestException {
    
    public APIException(string message, HttpStatusCode statusCode) : base(message, null, statusCode){ }
}