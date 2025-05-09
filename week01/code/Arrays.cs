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
        // creating a int array to put the multiples 
        var multiples = new double[length];
        // creating a variable to multiply the number
        int db = 1;
        // for loop to insert the multiples to the multiples array
        for (int i = 0; i < length; i++) {
            // adding the multiplied number to the array
            multiples[i] = number * db;
            // updating db var to do the next multiply
            db++;
        }

        return multiples; // replace this return statement with your own
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
        // getting numbers from the end of the list to add to the beginning
        var numbers = data.GetRange(data.Count - amount, amount);
        // removing numbers that have already been gotten
        data.RemoveRange(data.Count - amount, amount); 
        // adding the list of numbers to the beginning of the list
        data.InsertRange(0, numbers);
    }
}
