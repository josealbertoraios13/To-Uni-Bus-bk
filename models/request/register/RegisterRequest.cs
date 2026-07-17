using Interface.Request;

namespace Models.Request.Register
{
    public abstract record RegisterRequest : IRequest
    {
        public string? Name {get; init;} 
    }
}