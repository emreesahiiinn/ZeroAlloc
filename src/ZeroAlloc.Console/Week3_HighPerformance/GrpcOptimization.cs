using System.Text.Json;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Buffers;

namespace ZeroAlloc.Console.Week3_HighPerformance;

public static class GrpcOptimization
{
    public static void Run()
    {
        System.Console.WriteLine("\n🔹 Simulated gRPC Serialization & Processing Benchmark 🔹");
        BenchmarkRunner.Run<GrpcSimulationBenchmark>();
    }
}

[MemoryDiagnoser]
public class GrpcSimulationBenchmark
{
    private readonly GrpcRequest _request = new(1, "Request data");

    [Benchmark]
    public GrpcResponse HandleWithClass()
    {
        var json = JsonSerializer.Serialize(_request);
        var deserialized = JsonSerializer.Deserialize<GrpcRequestClass>(json)!;
        return new GrpcResponse { Id = deserialized.Id, Message = "Processed", Timestamp = DateTime.UtcNow };
    }

    [Benchmark]
    public GrpcResponse HandleWithRecord()
    {
        var json = JsonSerializer.Serialize(_request);
        var deserialized = JsonSerializer.Deserialize<GrpcRequest>(json)!;
        return new GrpcResponse { Id = deserialized.Id, Message = "Processed", Timestamp = DateTime.UtcNow };
    }

    [Benchmark]
    public GrpcResponse HandleWithPooledBuffer()
    {
        var buffer = ArrayPool<byte>.Shared.Rent(1024);
        try
        {
            var json = JsonSerializer.SerializeToUtf8Bytes(_request);
            var deserialized = JsonSerializer.Deserialize<GrpcRequest>(json)!;
            return new GrpcResponse { Id = deserialized.Id, Message = "Processed", Timestamp = DateTime.UtcNow };
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(buffer);
        }
    }
}

public record GrpcRequest(int Id, string Payload);

public class GrpcRequestClass
{
    public int Id { get; set; }
    public string Payload { get; set; } = string.Empty;
}

public class GrpcResponse
{
    public int Id { get; set; }
    public string Message { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; }
}