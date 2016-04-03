using System.Globalization;

public static class InvariantString
{
    public static string Format(string format, params object[] parameters)
    {
        return string.Format(CultureInfo.InvariantCulture, format, parameters);
    }
}
