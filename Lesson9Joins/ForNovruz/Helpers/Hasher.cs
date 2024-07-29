using System.Security.Cryptography;
using System.Text;

namespace ForNovruz.Helpers;

public static class Hasher
{
    public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] salt)
    {
        using var hmac = new HMACSHA512();
        salt = hmac.Key;
        passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    }

    public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] salt)
    {
        using var hmac = new HMACSHA512(salt);
        var computeHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        return computeHash.SequenceEqual(passwordHash);
    }
}
