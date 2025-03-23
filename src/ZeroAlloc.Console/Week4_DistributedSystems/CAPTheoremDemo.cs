namespace ZeroAlloc.Console.Week4_DistributedSystems;
public static class CAPTheoremDemo
{
    public static void Run()
    {
        System.Console.WriteLine("\nCAP Theorem Interactive Demo");
        System.Console.WriteLine("In a distributed system, you can only choose two out of the following three:");
        System.Console.WriteLine("- Consistency (C)");
        System.Console.WriteLine("- Availability (A)");
        System.Console.WriteLine("- Partition Tolerance (P)");
        System.Console.Write("Enter two choices (e.g., CA, CP, AP): ");

        var input = System.Console.ReadLine()?.Trim().ToUpper();

        switch (input)
        {
            case "CA":
                RunCAExample();
                break;

            case "CP":
                RunCPExample();
                break;

            case "AP":
                RunAPExample();
                break;

            default:
                System.Console.WriteLine("\nInvalid input. Please enter CA, CP, or AP.");
                break;
        }
    }

    private static void RunCAExample()
    {
        System.Console.WriteLine("\nYou chose: Consistency + Availability");
        System.Console.WriteLine("Simulating CA system: If partition occurs, system becomes unavailable.");

        var partition = new Random().NextDouble() < 0.5;

        System.Console.WriteLine(partition
            ? "Network partition detected. Rejecting request to preserve consistency."
            : "Request successful. Data is consistent and available.");
    }

    private static void RunCPExample()
    {
        System.Console.WriteLine("\nYou chose: Consistency + Partition Tolerance");
        System.Console.WriteLine("Simulating CP system: Will reject writes during partition to preserve consistency.");

        var partition = true;
        var writeRequest = true;

        if (partition && writeRequest)
        {
            System.Console.WriteLine("Partitioned network. Write request blocked to ensure consistency.");
        }
        else
        {
            System.Console.WriteLine("Write successful.");
        }
    }

    private static void RunAPExample()
    {
        System.Console.WriteLine("\nYou chose: Availability + Partition Tolerance");
        System.Console.WriteLine("Simulating AP system: System continues responding, but may serve stale data.");

        var primaryData = "v1";
        var replicaData = "v0";

        System.Console.WriteLine("Partitioned network. Replica responds with stale data: " + replicaData);
        Thread.Sleep(1000);
        System.Console.WriteLine("After partition healed, replica updated to: " + primaryData);
    }
}