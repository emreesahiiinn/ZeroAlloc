namespace ZeroAlloc.Console.Week2_MemoryManagement;

public static class HeapVsStack
{
    private class MyClass
    {
        public int Value;
    }

    private struct MyStruct
    {
        public int Value;
    }

    public static void Run()
    {
        System.Console.WriteLine("Stack vs Heap Demonstration");

        var a = 10;
        var b = a;
        b = 20;

        System.Console.WriteLine($"Stack: a = {a}, b = {b} (Value types are copied by value)");

        MyClass obj1 = new MyClass();
        obj1.Value = 30;

        MyClass obj2 = obj1;
        obj2.Value = 40;

        System.Console.WriteLine(
            $"Heap: obj1.Value = {obj1.Value}, obj2.Value = {obj2.Value} (Reference types share the same memory)");

        MyStruct struct1 = new MyStruct();
        struct1.Value = 50;

        MyStruct struct2 = struct1;
        struct2.Value = 60;

        System.Console.WriteLine(
            $"Struct: struct1.Value = {struct1.Value}, struct2.Value = {struct2.Value} (Structs are copied by value, not reference)");
    }
}