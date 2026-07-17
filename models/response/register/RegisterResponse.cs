using Interface.Response;

namespace Models.Response.Register
{
    public abstract record RegisterResponse : IResponse
    {
        public required string id {get; init;} 
        public required string name {get; init;} 
    }
}