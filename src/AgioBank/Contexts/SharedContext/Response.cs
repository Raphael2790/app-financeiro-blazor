using System.Net;

namespace AgioBank.Contexts.SharedContext
{
    public abstract class Response
    {
        public string Message { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public HttpStatusCode Status { get; set; } =  HttpStatusCode.BadRequest;
        public bool IsSuccess => (int)Status is >= 200 and <= 299;
    }
}
