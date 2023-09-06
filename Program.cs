// --------------------------------------------------------------------------------------------
// Training ~ A training program for interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// SWAP INDICES 
// Display random series of numbers to the user and ask them to provide two index values which need to be swapped and display the swapped result to the user.
// For example, 4 8 7 5 6 9 enter the index to be swapped: 2 3 outputs to be: 4 8 5 7 6 9. 
// --------------------------------------------------------------------------------------------
using System;

namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>Swap Indices</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>Display random series of numbers to the user </summary>
      /// <param name="args">arguments</param>
      static void Main (string[] args) {
         Random random = new Random ();
         int[] numbers = new int[8];
         for (int k = 0; k < numbers.Length; k++)
            numbers[k] = random.Next (1, 10);
         Console.WriteLine ("Original Numbers: " + string.Join (" ", numbers));
         Console.Write ("Enter two indices to swap (e.g., 2 3): ");
         string input = Console.ReadLine ();
         string[] indices = input.Split ();
         if (indices.Length == 2 && int.TryParse (indices[0], out int i) && int.TryParse (indices[1], out int j) && i >= 0 && i < numbers.Length && j >= 0 && j < numbers.Length && i != j) 
            Console.WriteLine ("Swapped Numbers: " + SwapNumbers (numbers, i, j));
         else Console.WriteLine ("Invalid input or indices.");
      }
      /// <summary>swapping the numbers using indices</summary>
      /// <param name="numbers">array of random numbers</param>
      /// <param name="index1">index 1</param>
      /// <param name="index2">index 2</param>
      /// <returns>swapped numbers</returns>
      static string SwapNumbers (int[] numbers, int index1, int index2) {
         int temp = numbers[index1];
         numbers[index1] = numbers[index2];
         numbers[index2] = temp;
         string swapNumbers = string.Join (" ", numbers);
         return swapNumbers;
      }
      #endregion
   }
   #endregion
}