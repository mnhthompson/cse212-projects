
using System;


public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>

    ///1: create a new array called calc
    ///2: write a for loop that runs 1 <= length
    ///3: in the for loop add the result of number times i to our list
    ///4: return the array we created

    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

      
   

        /// create a new array called calc
        double[] calc = new double[length];
        ///  write a for loop that runs 1 <= length
        for (var i = 1; i <= length; i++)
        {
            /// in for loop add the result of number times i to our array
            calc[i - 1] = (number * i);
        }

        ///  return the array
        return calc;
       
    }

 
 
 
 
 
 
 
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    /// 

    ///1: create a  list to store our data in that needs rotated called templist
    ///2: create an int variable called Move to store data.Count - amount which tells us what actually needs moved
    ///3: using GetRange(0, data.Count - amount) store all the need to be moved items in to the temp list
    ///4: using RemoveRange(0, data.Count - amount) remove the data that needs rotated from data
    ///5: using AddRange(templist)

 
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

                /// create a  list to store our data in that needs rotated called templist
        List<int> templist = new();
        /// create an int variable called shove to store data.Count - amount which tells us what actually needs moved
        int shove = data.Count - amount;
        ///  using GetRange(0, data.Count - amount) store all the need to be moved items in to the temp list
        templist.AddRange(data.GetRange(0, shove));
        ///  using RemoveRange(0, data.Count - amount) remove the data that needs rotated from data
        data.RemoveRange(0, shove);
        ///  using AddRange(templist)
        data.AddRange(templist);



    }
}
