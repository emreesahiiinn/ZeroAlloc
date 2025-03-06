using ZeroAlloc.Console.Week1_AsyncAwait;

internal class Program
{
    private static void Main()
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
                Console.WriteLine("Week 2 not implemented yet.");
                break;
            case "3":
                Console.WriteLine("Week 3 not implemented yet.");
                break;
            case "4":
                Console.WriteLine("Week 4 not implemented yet.");
                break;
            default:
                Console.WriteLine("Invalid selection. Exiting...");
                break;
        }
    }
}