#nullable disable

using System;
using System.Security.Cryptography;
using System.Text;

namespace WinFormsApp1
{
    public static class PasswordHasher
    {
        public static string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        public static string HashPassword(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] combinedBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashBytes = sha256.ComputeHash(combinedBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        public static bool VerifyPassword(string password, string salt, string hashFromDb)
        {
            string newHash = HashPassword(password, salt);
            return newHash == hashFromDb;
        }
    }
}
