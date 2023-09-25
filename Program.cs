// --------------------------------------------------------------------------------------------
// Training ~ A training program for interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// STRING PERMUTATIONS
// Generate all string character permutations. 
// For example, Input: "NOT", Output: "NOT NTO ONT OTN TNO TON" 
// --------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>String permutations </summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>Getting input from the user </summary>
      static void Main () {
         Console.Write ("Enter the input:");
         string input = Console.ReadLine ();
         List<string> permutations = Permute (input);
         Console.Write ("Output:");
         //print each and every element in the list
         foreach (string permutation in permutations) {
           Console.WriteLine (permutation);
         }
      }
      /// <summary>input permutations</summary>
      /// <param name="str">input</param>
      /// <returns>result</returns>

      static List<string> Permute (string str) {
         List<string> result = new List<string> ();
         PermuteHelper (str.ToCharArray (), 0, str.Length - 1, result);
         return result;
      }
      /// <summary>permute the input using swap</summary>
      /// <param name="strArray"> char array of input</param>
      /// <param name="left">select element based on index</param>
      /// <param name="right">select element based on index</param>
      /// <param name="result">empty list</param>
      static void PermuteHelper (char[] strArray, int left, int right, List<string> result) {
         if (left == right) {
            result.Add (new string (strArray));//add the permuted output to the list
         } else {
            for (int i = left; i <= right; i++) {
               Swap (ref strArray[left], ref strArray[i]);//swapping the letters based on indecise
               PermuteHelper (strArray, left + 1, right, result);//calling the function again
               Swap (ref strArray[left], ref strArray[i]); //swapping the letters based on indecise
            }
         }
      }
      /// <summary>Swapping the letters </summary>
      /// <param name="a">char</param>
      /// <param name="b">char</param>
      static void Swap (ref char a, ref char b) {
         (a, b) = (b, a);//swapping the letters using tuples
      }
      #endregion

   }
   #endregion
}