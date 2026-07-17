using Interface.Response;

namespace Models.Response.Login
{
    public record LoginResponse : IResponse
    {
        public required string accessToken {get; init;}
        public required int expiresIn {get; init;}
        public required string tokenType {get; init;}
        public required AuthenticatedUserResponse user {get; init;}
    }
}