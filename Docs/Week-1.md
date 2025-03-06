# Week 1: Async/Await & Multi-Threading Deep Dive

## Overview
In **Week 1**, we explored **asynchronous programming**, **multi-threading**, and **performance optimizations** in .NET. The focus was on:
- Understanding `Task<T>` vs `ValueTask<T>`
- Using **multi-threading techniques** like `Parallel.For`
- Preventing **async deadlocks**
- Implementing **Object Pooling** to reduce heap allocations

This week’s implementation included **BenchmarkDotNet** for performance analysis and real-world examples to reinforce best practices.

---

## Topics Covered

### **1️⃣ Task vs ValueTask – Performance Considerations**
- `Task<T>` is **heap-allocated** and creates additional GC pressure.
- `ValueTask<T>` is **stack-allocated** (in most cases) and reduces heap allocations.
- We benchmarked both to compare execution time and memory footprint.

### **2️⃣ Parallel Processing for CPU-bound Operations**
- We implemented **Parallel.For** to optimize CPU-intensive tasks.
- Compared **single-threaded execution vs multi-threaded execution**.
- Discussed when to use `Task.Run()` vs `ThreadPool`.

### **3️⃣ Avoiding Async Deadlocks**
- Explored **how `.Result` and `.Wait()` cause deadlocks**.
- Best practices for ensuring safe async execution.
- Implemented **a simple async deadlock and its resolution**.

### **4️⃣ Object Pooling for Memory Optimization**
- What is **Object Pooling** and why it matters?
- Implemented **a StringBuilder pool** to reduce frequent heap allocations.
- Benchmarked Object Pooling vs Non-Pooled execution.

---

## Implementation
All Week 1 implementations are located in:
```
ZeroAlloc.Console/Week1_AsyncAwait/
│── AsyncDeadlockExample.cs  (Deadlock simulation & fix)
│── ObjectPoolingBenchmark.cs (Object Pooling Implementation)
│── ParallelProcessing.cs (Parallel execution for CPU-bound tasks)
│── StringBuilderPool.cs (Object pooling implementation)
│── TaskVsValueTaskBenchmark.cs (Performance comparison of Task & ValueTask)
│── Week1_Main.cs (Entry point for Week 1 challenges)
```

---

## Running Week 1 Challenges
To run Week 1 benchmarks and examples:

1️⃣ **Navigate to the project folder:**
```sh
cd ZeroAlloc.Console
```

2️⃣ **Run the console app:**
```sh
dotnet run
```
3️⃣ **Select "Week 1: Async/Await & Multi-Threading" from the menu.**

4️⃣ **Run benchmarks in RELEASE mode for accurate results:**
```sh
dotnet run --configuration Release
```

---

## Key Takeaways from Week 1
**Task vs ValueTask:** Reduce heap allocation by using `ValueTask` when possible.
**Parallel Processing:** Multi-threading improves CPU-bound workloads significantly.
**Async Deadlocks:** Avoid blocking calls (`.Result`, `.Wait()`) to prevent deadlocks.
**Object Pooling:** Minimizes GC overhead and improves memory efficiency
**Next Step: Move to [Week 2 - Memory Management & Garbage Collection](../docs/Week2_README.md)**

