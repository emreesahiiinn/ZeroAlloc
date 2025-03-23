namespace ZeroAlloc.Console.Week2_MemoryManagement;

public static class Week2_Main
{
    public static void Run()
    {
        System.Console.WriteLine("Week 2: Memory Management & Garbage Collection");
        System.Console.WriteLine("1 - Heap vs Stack Allocation");
        System.Console.WriteLine("2 - Garbage Collection Demonstration");
        System.Console.WriteLine("3 - Large Object Heap (LOH) Optimization");
        System.Console.WriteLine("4 - Memory Leak Detection & Prevention");
        System.Console.Write("Choose an option: ");

        var choice = System.Console.ReadLine();
        switch (choice)
        {
            case "1":
                HeapVsStack.Run();
                break;
            case "2":
                GarbageCollectionDemo.Run();
                break;
            case "3":
                LOH_Optimization.Run();
                break;
            case "4":
                MemoryLeakDetection.Run();
                break;
            default:
                System.Console.WriteLine("Invalid selection.");
                break;
        }
    }
}