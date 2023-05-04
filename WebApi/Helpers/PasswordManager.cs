using BCrypt.Net;

namespace WebApi.Helpers
{
    public static class PasswordManager
    {
        public static string GenerateHash(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, 12);
        }

        public static bool VerifyPassword(string password, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }
    }
}
