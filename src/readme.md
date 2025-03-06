# 🚀 ZeroAlloc - High-Performance .NET Architecture & Optimization

## 📌 Overview
ZeroAlloc is a .NET performance challenge designed to explore **high-performance programming techniques**, **memory management**, and **multi-threading** in .NET. This project provides hands-on experience with real-world optimizations using BenchmarkDotNet, Object Pooling, Parallel Processing, and Asynchronous Programming.

This repository is structured as a **learning-based challenge**, where we progressively explore key topics related to performance tuning and architectural decisions in .NET.

## 📚 Project Structure
```
ZeroAlloc/
│── ZeroAlloc.sln  (Solution file)
│── ZeroAlloc.Console/  (Main Console Application)
│   │── Program.cs (Entry point)
│   │── Week1_AsyncAwait/ (Week 1 - Async/Await & Multi-Threading)
│   │── Week2_MemoryManagement/ (Week 2 - Memory Management & GC)
│   │── Week3_HighPerformance/ (Week 3 - High-Performance .NET Core)
│   │── Week4_DistributedSystems/ (Week 4 - Distributed Systems)
│
│── ZeroAlloc.Tests/  (Unit Tests)
│── docs/  (Documentation)
│── README.md  (Project Overview)
```

## 🛠️ Setup & Installation
### **1️⃣ Clone the Repository**
```sh
git clone https://github.com/emreesahiiinn/ZeroAlloc.git
cd ZeroAlloc
```

### **2️⃣ Install Dependencies**
```sh
dotnet restore
dotnet build
```

### **3️⃣ Run the Console Application**
```sh
cd ZeroAlloc.Console
dotnet run
```
This will start the interactive menu where you can select different performance challenges.

## 📌 Topics Covered
### **Week 1 - Async/Await & Multi-Threading**
- Understanding `Task<T>` vs `ValueTask<T>`
- Optimizing CPU-bound operations with `Parallel.For`
- Identifying and resolving async deadlocks
- Implementing Object Pooling to reduce heap allocations

### **Week 2 - Memory Management & Garbage Collection**
- Deep dive into .NET GC (Gen 0, Gen 1, Gen 2)
- Understanding Stack vs Heap allocations
- Large Object Heap (LOH) optimizations
- Identifying and fixing memory leaks

### **Week 3 - High-Performance .NET Core Optimization**
- Working with `Span<T>`, `Memory<T>`, and Pipelines API
- Zero-allocation programming techniques
- Optimizing serialization (JSON, MessagePack, Protobuf)
- High-performance gRPC optimization techniques

### **Week 4 - Distributed Systems & Eventual Consistency**
- CAP Theorem and Brewer's Theorem
- Implementing CQRS and Event Sourcing
- Resiliency patterns (Circuit Breaker, Retry Patterns)
- Database sharding and partitioning

## 📌 Next Steps
- [Read Week 1 Documentation](docs/Week1_README.md)
- Continue with **Week 2: Memory Management & Garbage Collection**

🚀 **This project is a hands-on learning experience for .NET developers interested in high-performance architecture and optimizations.**

