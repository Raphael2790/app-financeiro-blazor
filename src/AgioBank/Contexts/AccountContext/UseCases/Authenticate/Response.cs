using System.Net;

namespace AgioBank.Contexts.AccountContext.UseCases.Authenticate
{
    public class Response : SharedContext.Response
    {
        public Response(string message, HttpStatusCode status)
        {
            Message = message;
            Status = status;
        }

        public Response(string message, ResponseData data)
        {
            Message = message;
            Status = HttpStatusCode.OK;
            Data = data;
        }

        public ResponseData? Data { get; set; }

    }
    public record ResponseData
    {
        public string Token { get; set; } = string.Empty;
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}

