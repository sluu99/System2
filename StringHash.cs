using System.Security.Cryptography;
using System.Text;

public static class StringHash
{
    /// <summary>
    /// Hash a string using SHA256
    /// </summary>
    /// <param name="str">The string</param>
    /// <returns>The hex representation of the hash</returns>
    public static string Sha256(string str)
    {
        if (str == null)
        {
            return null;
        }

        byte[] data = Encoding.UTF8.GetBytes(str);

        using (var sha = SHA256.Create())
        {
            byte[] hashBytes = sha.ComputeHash(data);

            return ToHex(hashBytes);
        }
    }

    /// <summary>
    /// Hash a string using SHA1
    /// </summary>
    /// <param name="str">The string</param>
    /// <returns>The hex representation of the hash</returns>
    public static string Sha1(string str)
    {
        if (str == null)
        {
            return null;
        }

        byte[] data = Encoding.UTF8.GetBytes(str);

        using (var sha = SHA1.Create())
        {
            byte[] hashBytes = sha.ComputeHash(data);

            return ToHex(hashBytes);
        }
    }

    /// <summary>
    /// Hash a string using MD5
    /// </summary>
    /// <param name="str">The string</param>
    /// <returns>The hex representation of the hash</returns>
    public static string Md5(string str)
    {
        if (str == null)
        {
            return null;
        }

        byte[] data = Encoding.UTF8.GetBytes(str);

        using (var md5 = MD5.Create())
        {
            byte[] hashBytes = md5.ComputeHash(data);

            return ToHex(hashBytes);
        }
    }

    private static string ToHex(byte[] data)
    {
        StringBuilder sb = new StringBuilder(capacity: data.Length * 2);
        foreach (var b in data)
        {
            sb.Append(b.ToString("x2"));
        }

        return sb.ToString();
    }
}
