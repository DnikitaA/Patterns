using System;

/// <summary>
/// Generic thread-safe singleton class.
/// </summary>
/// <typeparam name="T">Type of singleton instance.</typeparam>
public class Singleton<T> where T : Singleton<T>
{
    /// <summary>
    /// Instance.
    /// </summary>
    private static Lazy<T> instance = new Lazy<T>(() => Activator.CreateInstance<T>(), true);

    /// <summary>
    /// Get instance.
    /// </summary>
    public static T Instance { get { return instance.Value; } }

    /// <summary>
    /// Initializes a new instance of the <see cref="Singleton{T}"/> class.
    /// </summary>
    protected Singleton()
    {
    }
}