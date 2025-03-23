# Week 4: Distributed Systems & Eventual Consistency

## Overview
In Week 4, we explored the foundational concepts and patterns of **distributed systems**. The goal was to understand the trade-offs in consistency, availability, and partition tolerance, and to simulate patterns that help build resilient, scalable architectures.

This week focused on practical simulations of:
- The **CAP Theorem**
- **CQRS** (Command Query Responsibility Segregation)
- **Event Sourcing**
- **Resilient patterns** like Retry and Circuit Breaker
- **Database sharding** as a scaling technique

---

## Topics Covered

### **1️⃣ CAP Theorem**
- Discussed the three pillars: Consistency, Availability, and Partition Tolerance.
- Explained that a distributed system can only guarantee two of the three.
- Example scenarios for CP, AP, and CA systems.

### **2️⃣ CQRS Pattern**
- Simulated separation of **write (command)** and **read (query)** models.
- Commands update the system state, queries return current state.
- Created simple handlers to demonstrate command-query decoupling.

### **3️⃣ Event Sourcing**
- Logged all domain events in sequence instead of storing current state.
- Replayed events to simulate reconstructing state.
- Highlighted traceability and audit benefits.

### **4️⃣ Resilient Patterns (Retry & Circuit Breaker)**
- Simulated a retry mechanism with max attempts.
- Introduced a basic circuit breaker that "opens" after failures.
- Goal: improve fault tolerance and protect downstream systems.

### **5️⃣ Database Sharding**
- Simulated a basic sharding strategy using modulus-based partitioning.
- Demonstrated routing a user to the correct shard.
- Important for horizontal scalability in distributed databases.

---

## Files in Week 4
```
Week4_DistributedSystems/
│── Week4_Main.cs
│── CAPTheoremDemo.cs
│── CQRSExample.cs
│── EventSourcingDemo.cs
│── ResilientPatterns.cs
│── ShardingSimulation.cs
```

---

## Running Week 4
```bash
cd ZeroAlloc.Console
 dotnet run
```
📌 Select "Week 4" from the menu, then choose a scenario to simulate.

---

## Summary
- Understood critical trade-offs in distributed system design.
- Learned about event-driven architecture foundations.
- Simulated real-world patterns to increase fault tolerance.
- Explored ways to scale systems horizontally.

This wraps up the final week of the ZeroAlloc Challenge! Well done!