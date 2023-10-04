// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// SORT AND SWAP SPECIAL CHARACTERS 
// Given a character array A, along with special character S and sort order O (default order is Ascending), print the sorted array by keeping the elements matching S to the last of the array. 
// For example, Input=([a, b, c, a, c, b, d], a, “descending”) ;Output=d, c, c, b, b, a, a .
// --------------------------------------------------------------------------------------------
using System;
using System.Linq;
namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary> Sort and swap special character </summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary> Getting inputs from user </summary>
      static void Main () {
         // Getting character from the user.
         Console.Write ("Enter the character array: ");
         char[] A = Console.ReadLine ()!.ToCharArray ();
         // Getting special character to swap from the user.
         Console.Write ("Enter the special character:");
         string S = Console.ReadLine ()!;
         // Getting the sorting order from the user. 
         Console.Write ("Do you want to sort the character array in decending order: (y)es or (n)o: ");
         ConsoleKeyInfo consoleKey = Console.ReadKey ();
         ConsoleKey sortOrder = consoleKey.Key;
         if (sortOrder == ConsoleKey.Y)
            Console.Write ($"\nOutput:{SortWithSpecialChar (A, S, "descending")}");
         else if (sortOrder == ConsoleKey.N)
            Console.Write ($"\nOutput:{SortWithSpecialChar (A, S)}");
         else Console.WriteLine ("Invalid input key.");
      }
      /// <summary> Sort the character array with special character </summary>
      /// <param name="A"> Character array </param>
      /// <param name="S"> Special character </param>
      /// <param name="Order"> Order for sorting the character </param>
      /// <returns> Sorted character </returns>
      static string SortWithSpecialChar (char[] A, string S, string Order = "ascending") {
         // This will handle if the user inputs an empty character.
         if (A == null || A.Length == 0) return "Input array is empty.";
         string output = "", remainingChar = "";
         // Split the char array from the special character and stores it in output and store the special character in remainingchar.
         foreach (char c in A) {
            if (c != S[0]) output += c;
            else remainingChar += c;
         }
         // Sort the output based on the user input.
         output = (Order.ToLower () == "descending")
          ? new string (output.OrderByDescending (c => c).ToArray ())
          : new string (output.OrderBy (c => c).ToArray ());
         // Join the output and remainingchar.
         string sortedChar = output + remainingChar;
         return string.Join (",", sortedChar.ToCharArray ());
      }
      #endregion
   }
   #endregion
}