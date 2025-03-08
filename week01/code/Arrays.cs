public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        double [] arr = new double[length];

        for (var i = 1; i <=  length; i++) {
            //First we make a for loop with the 'i' value starting on one, because we discard the 0 to find multiples
            // Then we multiply every i for the number we want multiples, like 5*1 5*2 5*3...
            // and we put it in the correct position of the array from 0 to length
            arr[i - 1] = number * i;
        }

        // then we return the array with the multiples of number
        return arr; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //This is to avoid edge cases for errors
        if (data == null || data.Count <= 1 || amount % data.Count == 0)
        return;


        //We need first to normalize the amount to avoid rotate the array several times.
        amount = amount % data.Count;

        //first we use GetRange to identify which values will be moved to the front
        List<int> temp = data.GetRange(data.Count - amount, amount);
        //then we cut the list where the values that will be moved are
        data.RemoveRange(data.Count - amount, amount);
        //then we insert the new values before the ones that were first
        data.InsertRange(0, temp);
    }
}
