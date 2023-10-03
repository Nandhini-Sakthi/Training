// --------------------------------------------------------------------------------------------
// Training ~ A training program for interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// CHOCOLATE WRAPPERS 
// Write a method, for a given money X along with price P of a chocolate and required wrappers W for a chocolate in exchange, return the maximum number of chocolates C you can get along with any unused money X and wrappers W. 
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
         Console.Write ("Enter the amount :"); // Amount user having
         int.TryParse (Console.ReadLine (), out int x);
         Console.Write ("Enter the price of a chocolate :"); // cost of a chocolate
         int.TryParse (Console.ReadLine (), out int p);
         Console.Write ("Enter the no of wrappers to get a chocolate :"); // No of wrappers can exchange with a chocolate
         int.TryParse (Console.ReadLine (), out int w);
         CalculateChocolates (x, p, w, out int C, out int remainingMoney, out int remainingWrappers);
         Console.WriteLine ($"Output : C = {C}, X = {remainingMoney}, W = {remainingWrappers}");
      }
      /// <summary>Calculating no of chocolate can buy with this money,remaining money,remaining wrappers</summary>
      /// <param name="x">the amount user having</param>
      /// <param name="p">price of a chocolate</param>
      /// <param name="w">no of wrappers can exchange with a chocolate</param>
      /// <param name="C">no of chocolate can buy with the money</param>
      /// <param name="remainingMoney">remaining amount after buying chocolate</param>
      /// <param name="remainingWrappers">remaining wrappers after buying chocolate</param>

      static void CalculateChocolates (int x, int p, int w, out int C, out int remainingMoney, out int remainingWrappers) {
         C = x / p; // Initial chocolates bought with money
         remainingMoney = x % p; // Remaining money after buying initial chocolates
         remainingWrappers = C; // Initial wrappers from the chocolates bought

         // Continue as long as you have enough wrappers to exchange for more chocolates
         while (remainingWrappers >= w) {
            // Calculate additional chocolates obtained from exchanging wrappers
            int additionalChocolates = remainingWrappers / w;
            C += additionalChocolates;  // Add to the total chocolates

            // Calculate wrappers left after exchange
            remainingWrappers = additionalChocolates + (remainingWrappers % w);
         }
      }
      #endregion
   }
   #endregion
}