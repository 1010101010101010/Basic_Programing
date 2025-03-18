using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programing
{
    class Permutation_Easy_Bad
    {
        // Method to print all permutations of the string
        public void PrintPermutations(string str)
        {
            GeneratePermutations(str.ToCharArray());
            //Time Complexity: O(n^2) and only works for this specific case
        }

        // Helper method to generate and print permutations using backtracking
        private void GeneratePermutations(char[] arr)
        {
            // First loop of permutations
            PrintPermutations(arr);

            // Swap and then print permutations again
            Swap(arr, 0, 2);
            PrintPermutations(arr);
        }

        private void PrintPermutations(char[] arr)
        {
            foreach (var item in arr)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(item);

                foreach (var item1 in arr)
                {
                    if (item != item1)
                    {
                        sb.Append(item1);
                    }
                }

                Console.WriteLine(sb.ToString());
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
