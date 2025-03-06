namespace ZeroAlloc.Console.Week1_AsyncAwait;

public static class AsyncDeadlockExample
{
    public static void Run()
    {
        System.Console.WriteLine("\nRunning Async Deadlock Example...");
        var result = GetDataAsync().Result; // DEADLOCK! (False)
        System.Console.WriteLine(result);
    }

    private static async Task<string> GetDataAsync()
    {
        await Task.Delay(1000);
        return "Hello, Async Deadlock!";
    }
}