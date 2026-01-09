using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number'
    /// followed by multiples of 'number'.
    /// Example: MultiplesOf(7, 5) → {7, 14, 21, 28, 35}
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create an array of doubles with the given length.
        double[] result = new double[length];

        // Step 2: Loop through each position in the array.
        for (int i = 0; i < length; i++)
        {
            // Step 3: Store the multiple of the number.
            // (i + 1) is used so the first value is number * 1.
            result[i] = number * (i + 1);
        }

        // Step 4: Return the completed array.
        return result;
    }

    /// <summary>
    /// Rotate the 'data' list to the right by the given 'amount'.
    /// Example:
    /// {1,2,3,4,5,6,7,8,9} rotated by 3 →
    /// {7,8,9,1,2,3,4,5,6}
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Calculate where the split should occur.
        int splitIndex = data.Count - amount;

        // Step 2: Get the last 'amount' elements of the list.
        List<int> rightPart = data.GetRange(splitIndex, amount);

        // Step 3: Get the remaining elements at the front of the list.
        List<int> leftPart = data.GetRange(0, splitIndex);

        // Step 4: Clear the original list.
        data.Clear();

        // Step 5: Add the elements back in the rotated order.
        data.AddRange(rightPart);
        data.AddRange(leftPart);
    }
}

