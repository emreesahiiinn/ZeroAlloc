namespace ZeroAlloc.Console.Week2_MemoryManagement;

public static class GarbageCollectionDemo
{
    public static void Run()
    {
        System.Console.WriteLine("Garbage Collection Demo");
            
        for (int i = 0; i < 10000; i++)
        {
            var obj = new byte[1024];
        }

        System.Console.WriteLine("Memory allocated. Forcing GC...");
        GC.Collect();
        GC.WaitForPendingFinalizers();
        System.Console.WriteLine("GC has been triggered.");
    }
}