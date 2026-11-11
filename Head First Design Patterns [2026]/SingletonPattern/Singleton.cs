namespace SingletonPattern;

public sealed class Singleton
{
    private static Singleton _instance;
    private static readonly Lock _lock = new();
    
    private Singleton()
    {
        Console.WriteLine("Initializing singleton...");
    }

    public static Singleton GetInstance()
    {
        if (_instance is null)
            lock(_lock)
            {
                if (_instance is null)
                    _instance = new Singleton();
            }

        return _instance;
    }
}
