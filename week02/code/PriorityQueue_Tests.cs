using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: make sure that certain animals get a pen first

    // Defect(s) Found: Dequeue() was not removing items 
    //from the queue so it would just keep repeating the item that was highest 
    //priority in the queue,
  
    public void TestPriorityQueue_1()
    {

        var priorityQueue = new PriorityQueue();
              // Expected Result: louse, Moose, Goose, Grouse, The queue is empty 
        
              List<string> expectedResult = new List<string>();
              expectedResult.Add("louse");
              expectedResult.Add("Moose");
              expectedResult.Add("Goose");
              expectedResult.Add("Grouse");
              
        
        var pen = new PriorityQueue();
        pen.Enqueue("Moose", 3);
        pen.Enqueue("Goose", 2);
        pen.Enqueue("louse", 4);
        pen.Enqueue("Grouse", 1);
        for(int i = 0; i < 4; i++){

    
             string animal = pen.Dequeue();
             Assert.AreEqual(expectedResult[i], animal);
   
    }
    }


// Defect(s) Found:index was messed up for priorty turned it to 0
    public void TestPriorityQueue_2()
    {

        var priorityQueue = new PriorityQueue();
                    
        // Expected Result: louse, Moose, Goose, Grouse,Panda, The queue is empty    
             
             
              List<string> expectedResult2 = new List<string>();
              expectedResult2.Add("louse");
              expectedResult2.Add("Moose");
              expectedResult2.Add("Goose");
              expectedResult2.Add("Grouse");
              expectedResult2.Add("Panda");

        var pen2 = new PriorityQueue();
        pen2.Enqueue("Moose", 3);
        pen2.Enqueue("Goose", 2);
        pen2.Enqueue("louse", 4);
        pen2.Enqueue("Grouse", 1);
        pen2.Enqueue("Panda", 1);
        for(int i = 0; i < 5; i++){


            string animal = pen2.Dequeue();
            Assert.AreEqual(expectedResult2[i], animal);
             
   
    }
    }








}