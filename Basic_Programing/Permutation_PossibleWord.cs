using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programing
{
    class Permutation_PossibleWord
    {
        // Method to print all permutations of the string
        public void PrintPermutations(string str)
        {
            GeneratePermutations(str.ToCharArray(), 0);
            //Time Complexity: O(n!)
        }

        // Helper method to generate and print permutations using backtracking
        private void GeneratePermutations(char[] arr, int index)
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
        private void Swap(char[] arr, int i, int j)
        {
            char temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
