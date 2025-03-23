namespace ZeroAlloc.Console.Week2_MemoryManagement;

public static class LOH_Optimization
{
    public static void Run()
    {
        System.Console.WriteLine("Large Object Heap (LOH) Optimization");

        var largeObject = new byte[100_000];
        System.Console.WriteLine("Large object allocated.");
            
        for (int i = 0; i < largeObject.Length; i++)
        {
            largeObject[i] = 1;
        }

        System.Console.WriteLine("Large object processed. Consider reusing or pooling large buffers to reduce LOH fragmentation.");
    }
}