using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.
    /// </summary>
    public static double[] MultiplesOf(double number, int length)
    {
        // Plan:
        // 1. Create a new array of doubles called 'multiples' with the size of 'length'.
        // 2. Start a loop that begins at index 0 and continues until it reaches 'length'.
        // 3. For each index (i), calculate the value: number multiplied by (i + 1).
        //    (e.g., if index is 0, value is number * 1; if index is 1, value is number * 2).
        // 4. Store that calculated value into the current index of the 'multiples' array.
        // 5. Once the loop is finished, return the 'multiples' array.

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Plan:
        // 1. Calculate the starting index of the section that needs to move to the front.
        //    Since we are rotating right, this is (Total Count - amount).
        // 2. Use GetRange to extract the last 'amount' of items into a temporary list.
        // 3. Use RemoveRange to delete those same items from their original position at the end of the list.
        // 4. Use InsertRange to place the temporary list at index 0 (the beginning) of the original list.

        // Step 1: Find where to split the list
        int splitIndex = data.Count - amount;

        // Step 2: Grab the values that are "falling off" the right side
        List<int> movedItems = data.GetRange(splitIndex, amount);

        // Step 3: Remove those values from the back
        data.RemoveRange(splitIndex, amount);

        // Step 4: Put them back at the front
        data.InsertRange(0, movedItems);
    }
}