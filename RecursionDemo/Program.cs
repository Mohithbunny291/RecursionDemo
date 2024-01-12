using System;

class Program
{
    static void Main()
    {
        // Call your method here
        runApp();
    }

    static void runApp()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Printing array elements using recursion:");
        printViaRecursion(array, 0);
    }

    static void printViaRecursion(int[] array, int index)
    {
        // Base case: check if the index is within the array bounds
        if (index < array.Length)
        {
            // Print the current element
            Console.Write(array[index] + " ");

            // Recursive call to print the rest of the array
            printViaRecursion(array, index + 1);
        }
    }
}
