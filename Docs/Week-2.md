# Week 2: Memory Management & Garbage Collection

## Overview
In Week 2, we focused on understanding how .NET manages memory under the hood and how to optimize it. This included concepts like garbage collection generations, heap vs stack behavior, memory leaks, and large object heap (LOH) handling.

---

## Topics Covered

### **1️⃣ Heap vs Stack Allocation**
- Demonstrated how value types are stored in the stack and reference types in the heap.
- Showed that value types are copied by value, and reference types are copied by reference.

### **2️⃣ Garbage Collection Demonstration**
- Created sample allocations and manually triggered GC using `GC.Collect()`.
- Observed how memory is reclaimed and how Gen 0/1/2 collections work in practice.

### **3️⃣ Large Object Heap (LOH) Optimization**
- Demonstrated allocation of objects >85,000 bytes.
- Discussed LOH fragmentation and the need to reuse large buffers or pool memory.

### **4️⃣ Memory Leak Simulation & Detection**
- Created a scenario that retains large objects in a static list, simulating a memory leak.
- Discussed approaches to detect memory leaks (e.g., dotMemory, PerfView).
- Covered best practices for releasing memory and avoiding leaks.

---

## Implementation Files
All Week 2 implementations are located under:
```
ZeroAlloc.Console/Week2_MemoryManagement/
│── HeapVsStack.cs
│── GarbageCollectionDemo.cs
│── LOH_Optimization.cs
│── MemoryLeakDetection.cs
│── Week2_Main.cs
```

---

## Running Week 2
To test the Week 2 features:

```sh
cd ZeroAlloc.Console
 dotnet run
```
Then select **Week 2: Memory Management & Garbage Collection** from the menu.

Use the appropriate number to run the relevant demo.

---

## Summary
- Learned the difference between heap and stack allocation.
- Understood how .NET’s GC manages object lifetime and memory recovery.
- Explored the impact of large object allocations.
- Simulated and understood the risks of memory leaks.

Next: [Week 3 - High Performance .NET Core](../docs/Week3_README.md)

