```

BenchmarkDotNet v0.14.0, macOS Sequoia 15.3.2 (24D81) [Darwin 24.3.0]
Apple M2 Pro, 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.200
  [Host]     : .NET 9.0.2 (9.0.225.6610), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.2 (9.0.225.6610), Arm64 RyuJIT AdvSIMD


```
| Method          | Mean     | Error   | StdDev  | Gen0   | Allocated |
|---------------- |---------:|--------:|--------:|-------:|----------:|
| SerializeClass  | 108.1 ns | 1.40 ns | 1.31 ns | 0.0134 |     112 B |
| SerializeRecord | 107.8 ns | 0.61 ns | 0.51 ns | 0.0134 |     112 B |
