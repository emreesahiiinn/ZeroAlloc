namespace ZeroAlloc.Console.Week3_HighPerformance;

public static class StackVsHeapAllocation
{
    public static void Run()
    {
        System.Console.WriteLine("\nStack vs Heap Allocation");

        int value = 42;
        var heapObject = new int[100000];

        System.Console.WriteLine("Allocated int on stack and int[] on heap.");
    }
}