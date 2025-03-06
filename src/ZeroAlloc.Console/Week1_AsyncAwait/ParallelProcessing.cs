using System.Diagnostics;

namespace ZeroAlloc.Console.Week1_AsyncAwait;

public static class ParallelProcessing
{
    public static void Run()
    {
        System.Console.WriteLine("\nRunning Parallel Processing Test...");
        const int dataSize = 10_000_000;
        var data = new double[dataSize];

        var sw = Stopwatch.StartNew();
        for (var i = 0; i < dataSize; i++) data[i] = Math.Sqrt(i);
        sw.Stop();
        System.Console.WriteLine($"Single-threaded Execution Time: {sw.ElapsedMilliseconds} ms");

        sw.Restart();
        Parallel.For(0, dataSize, i => { data[i] = Math.Sqrt(i); });
        sw.Stop();
        System.Console.WriteLine($"Parallel.For Execution Time: {sw.ElapsedMilliseconds} ms");
    }
}