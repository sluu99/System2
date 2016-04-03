using System;

public static class SystemTime
{
    private static Func<DateTimeOffset> NowFunc = () => DateTimeOffset.Now;

    public static DateTimeOffset UtcNow
    {
        get
        {
            return NowFunc().ToUniversalTime();
        }
    }

    public static DateTimeOffset Now
    {
        get
        {
            return NowFunc();
        }
    }

    public static void SetNowFunc(Func<DateTimeOffset> func)
    {
        if (func == null)
        {
            throw new ArgumentNullException(nameof(func));
        }

        NowFunc = func;
    }
}
