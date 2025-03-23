namespace ZeroAlloc.Console.Week4_DistributedSystems;

public static class ResilientPatterns
{
    public static void Run()
    {
        System.Console.WriteLine("\nResilient Patterns: Retry & Circuit Breaker (Simulated)");

        var retryCount = 0;
        var success = false;

        while (retryCount < 3 && !success)
        {
            try
            {
                retryCount++;
                SimulateUnreliableOperation();
                success = true;
                System.Console.WriteLine("Operation succeeded.");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Attempt {retryCount}: {ex.Message}");
                Thread.Sleep(500);
            }
        }

        if (!success)
        {
            System.Console.WriteLine("Circuit breaker tripped. Halting operation.");
        }
    }

    private static void SimulateUnreliableOperation()
    {
        if (new Random().NextDouble() < 0.7)
            throw new Exception("Simulated failure");
    }
}