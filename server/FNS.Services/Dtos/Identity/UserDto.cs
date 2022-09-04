namespace FNS.Services.Dtos.Identity
{
    public sealed class UserDto : DtoBase
    {
        public uint ConcurrencyToken { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
    }
}
