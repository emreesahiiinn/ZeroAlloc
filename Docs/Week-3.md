# Week 3: High-Performance .NET Core

## Overview
In Week 3, we explored techniques for writing high-performance code in .NET. This included:
- Low-allocation data handling with `Span<T>` and `Memory<T>`
- Stack vs Heap allocation awareness
- Serialization format comparisons
- Record vs Class structure usage
- Simulated gRPC optimizations with real-world inspired scenarios

This week's focus is on minimizing allocations, optimizing memory usage, and reducing latency in typical .NET application scenarios.

---

## Topics Covered

### **1️⃣ Span<T> and Memory<T>**
- Demonstrated how to use stackalloc and `Span<T>` for lightweight, stack-based memory operations.
- Avoided heap allocations for temporary buffers.

### **2️⃣ Stack vs Heap Allocation**
- Simple test illustrating how large objects go to heap and value types to stack.
- Raised awareness around performance costs of heap allocation.

### **3️⃣ Zero Allocation Techniques**
- Used `ReadOnlySpan<char>` to avoid string copies.
- Emphasized immutable, allocation-free APIs.

### **4️⃣ Serialization Benchmark**
- Compared three serialization formats:
    - `System.Text.Json`
    - `MessagePack`
    - `Protobuf`
- Measured performance using BenchmarkDotNet.
- Unified model class supported all serializers via attributes.

### **5️⃣ gRPC Optimization (Simulated)**
- Benchmarked simulated gRPC payload processing using:
    - Class-based models
    - Record-based models
    - ArrayPool (pooled buffer) strategies
- Objective: Reduce latency, improve memory reuse.

### **6️⃣ Record vs Class - Data Fetch & Benchmark**
- Fetched sample JSON from a public API.
- Deserialized the data into both class and record.
- Benchmarked serialization of both types to observe structural vs reference differences.

---

## Files in Week 3
```
Week3_HighPerformance/
│── Week3_Main.cs
│── SpanMemoryDemo.cs
│── StackVsHeapAllocation.cs
│── ZeroAllocTechniques.cs
│── SerializationBenchmark.cs
│── GrpcOptimization.cs
│── RecordVsClassFetch.cs
```

---

## Running Week 3
```bash
cd ZeroAlloc.Console
 dotnet run --configuration Release
``` 
Select "Week 3" from the menu, then pick a specific topic to execute.

---

## Summary
- Learned low-level memory handling using `Span<T>`
- Compared records vs classes in terms of memory and performance
- Benchmarked serialization strategies
- Simulated a realistic gRPC scenario and applied memory pooling

Next: [Week 4 - Distributed Systems](../docs/Week4_README.md)