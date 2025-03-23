using System.Text.Json;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace ZeroAlloc.Console.Week3_HighPerformance;

public static class RecordVsClassFetch
{
    public static async Task RunAsync()
    {
        System.Console.WriteLine("\nRecord vs Class - Data Fetch & Benchmark Demo");

        var client = new HttpClient();
        const string url = "https://jsonplaceholder.typicode.com/users/1";

        System.Console.WriteLine("Fetching data using class...");
        var classResult = await FetchAsClass(client, url);
        System.Console.WriteLine($"Class: Name = {classResult.Name}, Email = {classResult.Email}");

        System.Console.WriteLine("\nFetching data using record...");
        var recordResult = await FetchAsRecord(client, url);
        System.Console.WriteLine($"Record: Name = {recordResult.Name}, Email = {recordResult.Email}");

        System.Console.WriteLine("\nStarting benchmark...");
        BenchmarkRunner.Run<RecordVsClassBenchmark>();
    }

    static async Task<UserClass> FetchAsClass(HttpClient client, string url)
    {
        var json = await client.GetStringAsync(url);
        return JsonSerializer.Deserialize<UserClass>(json)!;
    }

    static async Task<UserRecord> FetchAsRecord(HttpClient client, string url)
    {
        var json = await client.GetStringAsync(url);
        return JsonSerializer.Deserialize<UserRecord>(json)!;
    }

    public class UserClass
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }

    public record UserRecord(string Name, string Email);
}

[MemoryDiagnoser]
public class RecordVsClassBenchmark
{
    private readonly RecordVsClassFetch.UserClass _userClass = new() { Name = "John", Email = "john@example.com" };
    private readonly RecordVsClassFetch.UserRecord _userRecord = new("John", "john@example.com");

    [Benchmark]
    public string SerializeClass()
    {
        return JsonSerializer.Serialize(_userClass);
    }

    [Benchmark]
    public string SerializeRecord()
    {
        return JsonSerializer.Serialize(_userRecord);
    }
}