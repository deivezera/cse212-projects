using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Should add two items to the back of the queue ("value1", 5), ("value2", 8) with different priorities and then dequeue the one with highest priority 
    // Expected Result: ["value2", "value3", "value1", "value5", "value4", "value6"]
    // Defect(s) Found: The test didn't work right because the for loop wasn't right about the range that 'i' should take.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        List<String> expectedResult = ["value2", "value3", "value1", "value5", "value4", "value6"];
        priorityQueue.Enqueue("value1", 5);
        priorityQueue.Enqueue("value2", 8);
        priorityQueue.Enqueue("value3", 6);
        priorityQueue.Enqueue("value4", 2);
        priorityQueue.Enqueue("value5", 3);
        priorityQueue.Enqueue("value6", 1);


        for(int i = 0; i < expectedResult.Count; i++) {
            var dequeuedValue = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], dequeuedValue);
        }

    }

    [TestMethod]
    // Scenario: If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.
    // Expected Result: "value1"
    // Defect(s) Found: The test wasn't working because the code was validating high priority index for values that were equal to each other too.
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