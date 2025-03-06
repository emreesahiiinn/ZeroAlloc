using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace ZeroAlloc.Console.Week1_AsyncAwait;

public class TaskVsValueTaskBenchmark
{
    [Benchmark]
    public async Task<int> TaskMethod()
    {
        await Task.Delay(10);
        return 42;
    }

    [Benchmark]
    public async ValueTask<int> ValueTaskMethod()
    {
        await Task.Delay(10);
        return 42;
    }

    public static void Run()
    {
        System.Console.WriteLine("\nRunning Task vs ValueTask Benchmark...");
        var summary = BenchmarkRunner.Run<TaskVsValueTaskBenchmark>();
    }
}