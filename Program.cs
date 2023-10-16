// --------------------------------------------------------------------------------------------
// Training ~ A training program for interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// CHOCOLATE WRAPPERS 
// Write a method, for a given money X along with price P of a chocolate and required wrappers W for a chocolate in exchange. 
// Return the maximum number of chocolates C you can get along with any unused money X and wrappers W.
// For example,Input:X = 15, P = 4, W = 3 Output:C = 4, X = 3, W = 1
using System;
namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>Chocolate Wrappers</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>Getting input from the user</summary>
      /// <param name="args">arguments</param>
      static void Main (string[] args) {
         Console.Write ("Enter the amount: ");
         int x = GetValidIntegerInput ();
         Console.Write ("Enter the price of a chocolate: ");
         int p = GetValidIntegerInput ();
         Console.Write ("Enter the number of wrappers needed for a chocolate: ");
         int w = GetValidIntegerInput ();
         CalculateChocolates (x, p, w, out int c, out int balanceMoney, out int balanceWrappers);
         Console.WriteLine ($"Output: C = {c}, X = {balanceMoney}, W = {balanceWrappers}");
      }
      /// <summary>Checking the input is integer or not</summary>
      /// <returns>Integer value</returns>
      static int GetValidIntegerInput () {
         int value;
         while (!int.TryParse (Console.ReadLine (), out value))
            Console.Write ("Invalid input. Please enter a valid integer: ");
         return value;
      }
      /// <summary>Calculating no of chocolate can buy with this money,remaining money,remaining wrappers</summary>
      /// <param name="x">The amount user having</param>
      /// <param name="p">Price of a chocolate</param>
      /// <param name="w">No of wrappers can exchange with a chocolate</param>
      /// <param name="c">No of chocolate can buy with the money</param>
      /// <param name="remainingMoney">Remaining amount after buying chocolate</param>
      /// <param name="remainingWrappers">Remaining wrappers after buying chocolate</param>
      static void CalculateChocolates (int x, int p, int w, out int c, out int balanceMoney, out int balanceWrappers) {
         c = x / p; // Initial chocolates bought with money
         balanceMoney = x % p; // Remaining money after buying initial chocolates
         balanceWrappers = c; // Initial wrappers from the chocolates bought
         // Continue as long as you have enough wrappers to exchange for more chocolates
         while (balanceWrappers >= w) {
            // Calculate additional chocolates obtained from exchanging wrappers
            c += balanceWrappers / w;
            // Calculate wrappers left after exchange
            balanceWrappers = c % w;
         }
      }
      #endregion
   }
   #endregion
}