namespace FNS.Services.Dtos.Identity
{
    public sealed class UserDeletingDto
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
