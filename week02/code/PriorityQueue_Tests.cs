using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Should add two items to the back of the queue ("value1", 5), ("value2", 8) with different priorities and then dequeue the one with highest priority 
    // Expected Result: "value2"
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        String expectedResult = "value2";
        priorityQueue.Enqueue("value1", 5);
        priorityQueue.Enqueue("value2", 8);

        var dequeuedValue = priorityQueue.Dequeue();
        Assert.AreEqual(expectedResult, dequeuedValue);
    }

    [TestMethod]
    // Scenario: If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        String expectedResult = "value1";
        priorityQueue.Enqueue("value1", 3);
        priorityQueue.Enqueue("value2", 3);

        var dequeuedValue = priorityQueue.Dequeue();

        Assert.AreEqual(expectedResult, dequeuedValue);
    }

    // Add more test cases as needed below.
}