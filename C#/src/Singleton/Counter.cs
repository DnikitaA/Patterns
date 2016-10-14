public class Counter : Singleton<Counter>
{
    /// <summary>
    /// Lock object for thread-safe.
    /// </summary>
    private object lockObject = new object();

    /// <summary>
    /// Counter.
    /// </summary>
    private int count = 0;

    /// <summary>
    /// Get count.
    /// </summary>
    public int Count { get { return count; } }

    /// <summary>
    /// Increase the counter by one.
    /// </summary>
    public void Increment()
    {
        lock(lockObject)
        {
            count++;
        }
    }
}