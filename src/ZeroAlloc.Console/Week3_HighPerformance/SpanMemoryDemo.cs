namespace ZeroAlloc.Console.Week3_HighPerformance
{
    public static class SpanMemoryDemo
    {
        public static void Run()
        {
            System.Console.WriteLine("Span<T> and Memory<T> Demo");

            Span<int> numbers = stackalloc int[5] { 1, 2, 3, 4, 5 };

            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }
        }
    }
}