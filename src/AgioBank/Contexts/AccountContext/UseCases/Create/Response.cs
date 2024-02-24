using AgioBank.Contexts.SharedContext;
using System.Net;

namespace AgioBank.Contexts.AccountContext.UseCases.Create
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
            Status = HttpStatusCode.Created;
            Data = data;
        }

        public ResponseData? Data { get; set; }

    }
    public record ResponseData(string Id);

}
