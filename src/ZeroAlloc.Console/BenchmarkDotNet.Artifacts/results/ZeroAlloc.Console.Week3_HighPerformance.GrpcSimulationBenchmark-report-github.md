```

BenchmarkDotNet v0.14.0, macOS Sequoia 15.3.2 (24D81) [Darwin 24.3.0]
Apple M2 Pro, 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.200
  [Host]     : .NET 9.0.2 (9.0.225.6610), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.2 (9.0.225.6610), Arm64 RyuJIT AdvSIMD


```
| Method                 | Mean     | Error   | StdDev  | Gen0   | Allocated |
|----------------------- |---------:|--------:|--------:|-------:|----------:|
| HandleWithClass        | 263.6 ns | 2.19 ns | 1.71 ns | 0.0248 |     208 B |
| HandleWithRecord       | 287.1 ns | 1.32 ns | 1.17 ns | 0.0372 |     312 B |
| HandleWithPooledBuffer | 270.3 ns | 1.19 ns | 0.93 ns | 0.0343 |     288 B |
