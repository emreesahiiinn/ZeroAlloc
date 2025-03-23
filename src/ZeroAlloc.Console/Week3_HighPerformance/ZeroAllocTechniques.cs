namespace ZeroAlloc.Console.Week3_HighPerformance;

public static class ZeroAllocTechniques
{
    public static void Run()
    {
        System.Console.WriteLine("Zero Allocation Techniques");

        ReadOnlySpan<char> span = "Hello, ZeroAlloc".AsSpan();
        System.Console.WriteLine(span.ToString());
    }
}