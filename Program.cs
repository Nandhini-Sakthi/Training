﻿// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// SORT AND SWAP SPECIAL CHARACTERS 
// Given a character array A, along with special character S and sort order O (default order is Ascending)
// Print the sorted array by keeping the elements matching S to the last of the array.
// For example, Input=([a, b, c, a, c, b, d], a, “descending”) ;Output=d, c, c, b, b, a, a .
// --------------------------------------------------------------------------------------------
using System;
using System.Linq;
namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>Sort and swap special character</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>Getting inputs from user</summary>

      static void Main () {
         // Getting character from the user.
         Console.Write ("Enter the character array: ");
         char[] a = Console.ReadLine ().ToCharArray ();
         // Getting special character to swap from the user.
         Console.Write ("Enter the special character:");
         string s = Console.ReadLine ();
         // Getting the sorting order from the user. 
         Console.Write ("Do you want to sort the character array in decending order: (y)es or (n)o: ");
         ConsoleKeyInfo consoleKey = Console.ReadKey ();
         ConsoleKey sortOrder = consoleKey.Key;
         if (sortOrder == ConsoleKey.Y)
            Console.Write ($"\nOutput:{SortWithSpecialChar (a, s, "descending")}");
         else if (sortOrder == ConsoleKey.N)
            Console.Write ($"\nOutput:{SortWithSpecialChar (a, s)}");
         else Console.WriteLine ("Invalid input key.");
      }
      /// <summary>Sort the character array with special character</summary>
      /// <param name="a">Character array</param>
      /// <param name="s">Special character</param>
      /// <param name="order">Order for sorting the character</param>
      /// <returns>Sorted character</returns>

      static string SortWithSpecialChar (char[] a, string s, string order = "ascending") {
         // This will handle if the user inputs an empty character.
         if (a == null || a.Length == 0) return "Input array is empty.";
         string output = "", splChar = "";
         // Split the char array from the special character and stores it in output and store the special character in specialchar.
         foreach (char c in a) {
            if (c != s[0]) output += c;
            else splChar += c;
         }
         // Sort the output based on the user input.
         output = (order.ToLower () == "descending")
          ? new string (output.OrderByDescending (c => c).ToArray ())
          : new string (output.OrderBy (c => c).ToArray ());
         // Join the output and remainingchar.
         string sortedChar = output + splChar;
         return string.Join (',', sortedChar.ToCharArray ());
      }
      #endregion
   }
   #endregion
}