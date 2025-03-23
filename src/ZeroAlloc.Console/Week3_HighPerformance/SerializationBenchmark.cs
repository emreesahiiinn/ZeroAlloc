using System.Text.Json;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using MessagePack;
using ProtoBuf;

namespace ZeroAlloc.Console.Week3_HighPerformance;

public static class SerializationBenchmark
{
    public static void Run()
    {
        System.Console.WriteLine("Serialization Benchmark (JSON vs MessagePack vs Protobuf)");
        var summary = BenchmarkRunner.Run<SerializationBenchmarkTests>();
    }
}

[MemoryDiagnoser]
public class SerializationBenchmarkTests
{
    private readonly User _user = new("Alice", "alice@example.com", 30);

    [Benchmark]
    public string JsonSerialize()
    {
        return JsonSerializer.Serialize(_user);
    }

    [Benchmark]
    public byte[] MessagePackSerialize()
    {
        return MessagePackSerializer.Serialize(_user);
    }

    [Benchmark]
    public byte[] ProtobufSerialize()
    {
        using var ms = new MemoryStream();
        Serializer.Serialize(ms, _user);
        return ms.ToArray();
    }
}

[MessagePackObject]
[ProtoContract]
public class User
{
    public User() { }

    public User(string name, string email, int age)
    {
        Name = name;
        Email = email;
        Age = age;
    }

    [Key(0)]
    [ProtoMember(1)]
    public string Name { get; set; } = string.Empty;

    [Key(1)]
    [ProtoMember(2)]
    public string Email { get; set; } = string.Empty;

    [Key(2)]
    [ProtoMember(3)]
    public int Age { get; set; }
}