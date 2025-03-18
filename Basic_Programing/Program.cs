using Basic_Programing;
using System;

public class Program
{
    public static void Main1()
    {
        string str = "abc";
        //output: abc, acb, bac, bca, cba, cab

        Permutation_PossibleWord permutation_PossibleWord = new Permutation_PossibleWord();
        // Generate and print all permutations of the string
        permutation_PossibleWord.PrintPermutations(str);
    }
    public static void Main()
    {
        string str = "abc";
        //output: abc, acb, bac, bca, cba, cab

        Permutation_Easy_Bad permutation_Easy_Bad = new Permutation_Easy_Bad();
        // Generate and print all permutations of the string
        permutation_Easy_Bad.PrintPermutations(str);
    }

}
