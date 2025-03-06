```

BenchmarkDotNet v0.14.0, macOS Sequoia 15.3.1 (24D70) [Darwin 24.3.0]
Apple M2 Pro, 1 CPU, 12 logical and 12 physical cores
.NET SDK 9.0.200
  [Host]     : .NET 9.0.2 (9.0.225.6610), Arm64 RyuJIT AdvSIMD
  DefaultJob : .NET 9.0.2 (9.0.225.6610), Arm64 RyuJIT AdvSIMD


```

| Method         |      Mean |    Error |   StdDev |
|----------------|----------:|---------:|---------:|
| WithoutPooling |  88.67 μs | 1.472 μs | 1.305 μs |
| WithPooling    | 346.89 μs | 4.404 μs | 4.120 μs |
