namespace ValidicCSharp.Model
{
    using System.Net;

    public class AddUserResponse
    {
        public HttpStatusCode code { get; set; }
        public string message { get; set; }
        public User user { get; set; }
    }
}