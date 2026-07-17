using Interface.Response;

namespace Models.Response
{
    public record Response
    {
        public required int status {get; init;}
        public required string message {get; init;}
        public required IResponse data {get; init;}
    }
}