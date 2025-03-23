namespace ZeroAlloc.Console.Week3_HighPerformance;

public static class Week3_Main
{
    public static async Task RunAsync()
    {
        System.Console.WriteLine("\nWeek 3: High-Performance .NET Core");
        System.Console.WriteLine("1 - Span<T> and Memory<T> Demo");
        System.Console.WriteLine("2 - Stack vs Heap Allocation");
        System.Console.WriteLine("3 - Zero Allocation Techniques");
        System.Console.WriteLine("4 - Serialization Benchmark");
        System.Console.WriteLine("5 - gRPC Optimization");
        System.Console.WriteLine("6 - Record vs Class Data Fetch Comparison");
        System.Console.Write("Choose an option: ");

        var choice = System.Console.ReadLine();
        switch (choice)
        {
            case "1":
                SpanMemoryDemo.Run();
                break;
            case "2":
                StackVsHeapAllocation.Run();
                break;
            case "3":
                ZeroAllocTechniques.Run();
                break;
            case "4":
                SerializationBenchmark.Run();
                break;
            case "5":
                GrpcOptimization.Run();
                break;
            case "6":
                await RecordVsClassFetch.RunAsync();
                break;
            default:
                System.Console.WriteLine("Invalid selection.");
                break;
        }
    }
}