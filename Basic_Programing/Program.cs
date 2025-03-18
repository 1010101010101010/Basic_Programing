using System;

public class Program
{
    public static void Main()
    {
        string str = "abc";
        //output: abc, acb, bac, bca, cba, cab

        // Generate and print all permutations of the string
        PrintPermutations(str);
    }

    // Method to print all permutations of the string
    private static void PrintPermutations(string str)
    {
        char[] arr = str.ToCharArray();
        GeneratePermutations(arr, 0);
    }

    // Helper method to generate and print permutations using backtracking
    private static void GeneratePermutations(char[] arr, int index)
    {
        if (index == arr.Length)
        {
            Console.WriteLine(new string(arr));  // Print the permutation
            return;
        }

        for (int i = index; i < arr.Length; i++)
        {
            // Swap elements at index and i
            Swap(arr, index, i);

            // Recursively generate permutations for the next index
            GeneratePermutations(arr, index + 1);

            // Backtrack (undo the swap)
            Swap(arr, index, i);
        }
    }

    // Method to swap two elements in the array
    private static void Swap(char[] arr, int i, int j)
    {
        char temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
