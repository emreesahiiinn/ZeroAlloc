namespace ZeroAlloc.Console.Week1_AsyncAwait;

public static class Week1_AsyncAwait
{
    public static void Run()
    {
        System.Console.WriteLine("\nWeek 1: Async/Await & Multi-Threading");
        System.Console.WriteLine("1 - Task vs ValueTask Benchmark");
        System.Console.WriteLine("2 - Parallel Processing");
        System.Console.WriteLine("3 - Async Deadlock Example");
        System.Console.WriteLine("4 - Object Pooling Benchmark");
        System.Console.Write("Choose an option: ");

        var choice = System.Console.ReadLine();
        switch (choice)
        {
            case "1":
                TaskVsValueTaskBenchmark.Run();
                break;
            case "2":
                ParallelProcessing.Run();
                break;
            case "3":
                AsyncDeadlockExample.Run();
                break;
            case "4":
                ObjectPoolingBenchmark.Run();
                break;
            default:
                System.Console.WriteLine("Invalid selection.");
                break;
        }
    }
}