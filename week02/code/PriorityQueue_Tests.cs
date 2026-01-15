using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue and Dequeue a single item
    // Expected Result: Dequeue returns the item added
    // Defect(s) Found: None (after fixing Dequeue implementation)
    public void TestPriorityQueue_SingleItem()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 5);

        string result = pq.Dequeue();

        Assert.AreEqual("A", result);
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with different priorities
    // Expected Result: Dequeue returns items in order of highest priority first
    // Defect(s) Found: None
    public void TestPriorityQueue_DifferentPriorities()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 1);
        pq.Enqueue("B", 3);
        pq.Enqueue("C", 2);

        Assert.AreEqual("B", pq.Dequeue()); // highest priority 3
        Assert.AreEqual("C", pq.Dequeue()); // next highest priority 2
        Assert.AreEqual("A", pq.Dequeue()); // lowest priority 1
    }

    [TestMethod]
    // Scenario: Multiple items with same highest priority
    // Expected Result: Dequeue returns the item that was added first (FIFO)
    // Defect(s) Found: None
    public void TestPriorityQueue_SamePriorityFIFO()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 5);
        pq.Enqueue("B", 5);
        pq.Enqueue("C", 3);

        Assert.AreEqual("A", pq.Dequeue()); // A and B have same priority, A came first
        Assert.AreEqual("B", pq.Dequeue()); // next is B
        Assert.AreEqual("C", pq.Dequeue()); // last is C
    }

    [TestMethod]
    // Scenario: Dequeue from empty queue
    // Expected Result: InvalidOperationException is thrown with correct message
    // Defect(s) Found: None
    public void TestPriorityQueue_EmptyQueue()
    {
        var pq = new PriorityQueue();

        var ex = Assert.ThrowsException<InvalidOperationException>(() => pq.Dequeue());
        Assert.AreEqual("The queue is empty.", ex.Message);
    }

    [TestMethod]
    // Scenario: Enqueue items and ensure proper priority order after multiple operations
    // Expected Result: Items are returned in correct priority order, with FIFO for ties
    // Defect(s) Found: None
    public void TestPriorityQueue_MixedOperations()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 1);
        pq.Enqueue("B", 2);
        pq.Enqueue("C", 2);
        pq.Enqueue("D", 5);
        pq.Enqueue("E", 3);

        Assert.AreEqual("D", pq.Dequeue()); // 5
        Assert.AreEqual("E", pq.Dequeue()); // 3
        Assert.AreEqual("B", pq.Dequeue()); // 2
        Assert.AreEqual("C", pq.Dequeue()); // 2
        Assert.AreEqual("A", pq.Dequeue()); // 1
    }
}
