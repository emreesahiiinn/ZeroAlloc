using System.Collections.Concurrent;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace ZeroAlloc.Console.Week1_AsyncAwait;

public class ObjectPoolingBenchmark
{
    private static readonly ConcurrentBag<StringBuilder> _pool = new();

    public static StringBuilder Get()
    {
        if (!_pool.TryTake(out var sb)) return new StringBuilder();
        sb.Clear();
        return sb;
    }

    public static void Return(StringBuilder sb)
    {
        _pool.Add(sb);
    }

    [Benchmark]
    public void WithoutPooling()
    {
        for (var i = 0; i < 10000; i++)
        {
            var sb = new StringBuilder();
            sb.Append("Test");
        }
    }

    [Benchmark]
    public static void WithPooling()
    {
        for (var i = 0; i < 10000; i++)
        {
            var sb = Get();
            sb.Append("Test");
            Return(sb);
        }
    }

    public static void Run()
    {
        System.Console.WriteLine("\nRunning Object Pooling Benchmark...");
        var summary = BenchmarkRunner.Run<ObjectPoolingBenchmark>();
    }
}