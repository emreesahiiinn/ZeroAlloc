namespace ZeroAlloc.Console.Week4_DistributedSystems;

public static class EventSourcingDemo
{
    public static void Run()
    {
        System.Console.WriteLine("\nEvent Sourcing Simulation");

        var eventStore = new List<string>();
        eventStore.Add("UserRegistered");
        eventStore.Add("UserEmailConfirmed");
        eventStore.Add("UserLoggedIn");

        System.Console.WriteLine("Replaying Events:");
        foreach (var evt in eventStore)
        {
            System.Console.WriteLine($"- {evt}");
        }
    }
}