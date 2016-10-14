using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        List<Task> tasks = new List<Task>();
        for(var t = 1; t <= 9; t++)
        {
            tasks.Add(Task.Factory.StartNew(() =>
            {
                for(var i = 0; i < 100; i++)
                {
                    Counter.Instance.Increment();
                    Console.WriteLine("Current value of counter: {0}", Counter.Instance.Count);
                    Thread.Sleep(100);
                }
            }));
        }

        Task.WaitAll(tasks.ToArray());
    }
}