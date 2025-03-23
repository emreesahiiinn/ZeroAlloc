namespace ZeroAlloc.Console.Week2_MemoryManagement;

public static class MemoryLeakDetection
{
    private static List<byte[]> _leakyList = new();

    public static void Run()
    {
        System.Console.WriteLine("Memory Leak Simulation");

        for (int i = 0; i < 1000; i++)
        {
            var buffer = new byte[1024 * 100];
            _leakyList.Add(buffer);
        }

        System.Console.WriteLine("Simulated memory leak by retaining large buffers.");
        System.Console.WriteLine("To fix: clear unused references, or use weak references if needed.");
    }
}