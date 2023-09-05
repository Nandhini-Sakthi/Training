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
         for (int i = 0; i < numbers.Length; i++)
            numbers[i] = random.Next (1, 10);
         Console.WriteLine ("Original Numbers: " + string.Join (" ", numbers));
         Console.Write ("Enter two indices to swap (e.g., 2 3): ");
         string input = Console.ReadLine ();
         string swappedResult = SwappedNumber (input, numbers);
         Console.WriteLine ("Swapped Numbers: " + swappedResult);
      }
      /// <summary>swapping the numbers using indices</summary>
      /// <param name="input">Index</param>
      /// <param name="numbers">Array of Random numbers</param>
      /// <returns>swapped number</returns>
      static string SwappedNumber (string input, int[] numbers) {
         string[] indices = input.Split ();
         if (indices.Length == 2 && int.TryParse (indices[0], out int i) && int.TryParse (indices[1], out int j) && i >= 0 && i < numbers.Length && j >= 0 && j < numbers.Length) {
            int temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
            return string.Join (" ", numbers);
         } return "Invalid input or indices.";
         #endregion
      }
      #endregion
   }
}