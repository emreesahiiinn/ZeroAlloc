﻿using ZeroAlloc.Console.Week1_AsyncAwait;
using ZeroAlloc.Console.Week2_MemoryManagement;
using ZeroAlloc.Console.Week3_HighPerformance;
using ZeroAlloc.Console.Week4_DistributedSystems;

internal class Program
{
    private static async Task Main()
    {
        Console.WriteLine("\n Welcome to ZeroAlloc - .NET Performance Challenge 🚀");
        Console.WriteLine("1 - Week 1: Async/Await & Multi-Threading");
        Console.WriteLine("2 - Week 2: Memory Management & GC");
        Console.WriteLine("3 - Week 3: High-Performance .NET Core");
        Console.WriteLine("4 - Week 4: Distributed Systems");
        Console.Write("Select an option: ");

        var choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Week1_AsyncAwait.Run();
                break;
            case "2":
                Week2_Main.Run();
                break;
            case "3":
                await Week3_Main.RunAsync();
                break;
            case "4":
                Week4_Main.Run();
                break;
            default:
                Console.WriteLine("Invalid selection. Exiting...");
                break;
        }
    }
}