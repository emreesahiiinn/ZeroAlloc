```

BenchmarkDotNet v0.14.0, macOS Sequoia 15.3.2 (24D81) [Darwin 24.3.0]
Apple M2 Pro, 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.200
  [Host]     : .NET 9.0.2 (9.0.225.6610), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.2 (9.0.225.6610), Arm64 RyuJIT AdvSIMD


```
| Method               | Mean      | Error    | StdDev   | Gen0   | Allocated |
|--------------------- |----------:|---------:|---------:|-------:|----------:|
| JsonSerialize        | 121.53 ns | 1.198 ns | 1.001 ns | 0.0153 |     128 B |
| MessagePackSerialize |  53.70 ns | 0.624 ns | 0.583 ns | 0.0067 |      56 B |
| ProtobufSerialize    | 122.03 ns | 0.597 ns | 0.499 ns | 0.0477 |     400 B |
