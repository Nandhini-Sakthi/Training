// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// Reverse number guessing game(MSD TO LSD)
// System will display the number you guessed.
// --------------------------------------------------------------------------------------------
using System;

namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>Reverse number guessing game</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>insert the user to think a ramdom number 1 and 100 </summary>
      static void Main () {
         Console.WriteLine ("Welcome to the Guessing Game!");
         Console.WriteLine ("Think of a number between 1 and 100, and I will try to guess it.");
         int min = 1;
         int max = 100;
         int computerGuess;
         string userinput = "";
         while (userinput != "c") {
            // The computer makes a guess in the middle of the current range
            computerGuess = (min + max) / 2;
            Console.Write ($"Is your number {computerGuess} ?((h)igh / (l)ow / (c)orrect): ");
            userinput = Console.ReadLine ().ToLower ();
            if (userinput == "h")
               min = computerGuess; // Adjust the range according to the userinput
            else if (userinput == "l")
               max = computerGuess; // Adjust the range according to the userinput
            else if (userinput == "c")
               Console.WriteLine ($"{computerGuess} is your guessed number.");
            else Console.WriteLine ("Invalid input");
         }
      }
      #endregion
   }
   #endregion
}