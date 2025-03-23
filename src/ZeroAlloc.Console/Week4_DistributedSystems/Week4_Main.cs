namespace ZeroAlloc.Console.Week4_DistributedSystems;

public static class Week4_Main
{
    public static void Run()
    {
        System.Console.WriteLine("\nWeek 4: Distributed Systems & Eventual Consistency");
        System.Console.WriteLine("1 - CAP Theorem Demo");
        System.Console.WriteLine("2 - CQRS Pattern Example");
        System.Console.WriteLine("3 - Event Sourcing Simulation");
        System.Console.WriteLine("4 - Resilient Patterns (Retry, Circuit Breaker)");
        System.Console.WriteLine("5 - Database Sharding Simulation");
        System.Console.Write("Choose an option: ");

        var choice = System.Console.ReadLine();
        switch (choice)
        {
            case "1":
                CAPTheoremDemo.Run();
                break;
            case "2":
                CQRSExample.Run();
                break;
            case "3":
                EventSourcingDemo.Run();
                break;
            case "4":
                ResilientPatterns.Run();
                break;
            case "5":
                ShardingSimulation.Run();
                break;
            default:
                System.Console.WriteLine("Invalid selection.");
                break;
        }
    }
}