using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace FNS.Presentation.Utilities.Auth
{
    internal static class JwtAuthenticateOptions
    {
        public const string Issuer = "MyAuthServer";
        public const string Audience = "MyAuthClient";
        public const int LifetimeSeconds = 30;
        private const string SecretKey = "mysupersecret_secretkey!123";
        private static readonly SymmetricSecurityKey _symmetricSecurityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SecretKey));

        public static SymmetricSecurityKey SymmetricSecurityKey => _symmetricSecurityKey;

        public static string SecurityAlgorithm = SecurityAlgorithms.HmacSha256;

        public static SigningCredentials CreateSigningCredentials()
        {
            var credentials = new SigningCredentials(SymmetricSecurityKey, SecurityAlgorithm);
            return credentials;
        }
    }
}
