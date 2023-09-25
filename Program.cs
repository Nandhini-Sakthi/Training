// --------------------------------------------------------------------------------------------
// Training ~ A training program for interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// REVERSE NUMBER GUESSING GAME (LSD TO MSD)
// Write the code for displaying the number you guessed.
// --------------------------------------------------------------------------------------------
using System;
using System.Linq.Expressions;

namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>Reverse Guessing Game</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>insert the user to think a number between 1 and 100</summary>
      /// <param name="args">arguments</param>
      static void Main (string[] args) {
         Console.WriteLine ("Welcome to guessing game.");
         Console.WriteLine ("Think a number between 1 and 100.");
         int rem = 0; string binary = "";
         for (int i = 1; i <= 7; i++) {
            Console.Write ($"Is the remainder {rem} when divided by {Math.Pow (2, i)}: (y)es or (n)o: ");//initially reminder will be 0.
            string userinput = Console.ReadLine ();
            if (userinput == "y")
               binary = "0" + binary;//add binary number in the binary string.
            else if (userinput == "n") {
               binary = "1" + binary;
               rem = Convert.ToInt32 (binary, 2);//rem value will be changing based on user input.
            } else Console.WriteLine ("Invalid input");
         }
         Console.WriteLine ("The number in your mind is " + (rem) + ".");
      }
      #endregion
   }
   #endregion
}