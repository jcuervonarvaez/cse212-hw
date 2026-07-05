using System.Diagnostics;

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


        // PLAN:
        // 1. Create an array of type double with size 'length', since we already
        //    know exactly how many multiples we need to produce.
        // 2. Loop through the array indices from i = 0 up to length - 1.
        // 3. For each index i, calculate the matching multiple using the formula
        //    (i + 1) * number. This works because index 0 should hold the FIRST
        //    multiple (number * 1), index 1 should hold the SECOND multiple
        //    (number * 2), and so on — so the loop index always needs a +1 to
        //    match the "position" of the multiple in math terms.
        // 4. Store that calculated value in result[i].
        // 5. After the loop finishes, return the completed array.


        var result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = (i + 1) * number;
        }

        return result;
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

        // PLAN:
        // 1. Create an array of size 'count', since we already know how many
        //    multiples we need (unlike a List, it doesn't need to grow).
        // 2. Loop through the array indices from 0 to count - 1.
        // 3. For each index i, the matching multiple is 'start * (i + 1)',
        //    because index 0 represents the first multiple (start * 1), index 1
        //    represents the second multiple (start * 2), and so on.
        // 4. Store that calculated value in result[i].
        // 5. Return the completed array.

        var slice1 = data.GetRange(0, data.Count() - amount);
        data.RemoveRange(0, data.Count() - amount);
        data.InsertRange(amount, slice1);

    }
}
