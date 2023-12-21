// --------------------------------------------------------------------------------------------
// Training ~ A training program for interns at Metamation, Batch - July 2023.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------------
// Program.cs
// A06: Eight Queens
// On a standard chessboard 8 queens have to be placed so that no queen can attack any other.
// As per the rules of chess, the queen can move horizontally, vertically or diagonally.
// No two queens can be on the same row or column or diagonal.
// --------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>EightQueens</summary>
   class Program {
      #region Methods ---------------------------------------------
      /// <summary>Prints Eight Queens</summary>
      /// <param name="args">Arguments</param>
      static void Main (string[] args) {
         Console.WriteLine ("Press U for unique solution to display else press any key for all solution: ");
         bool isUnique = false;
         if (Console.ReadKey (true).Key == ConsoleKey.U) isUnique = true;
         QueenPosition (0, isUnique);
         ChessBoard ();
      }

      /// <summary>Check the solution is unique and store it</summary>
      /// <param name="pos">Solution array</param>
      static void AddUniqueSoln (int[] pos) {
         var tmp = pos;
         for (int i = 0; i < 4; i++) {
            if (Exists (tmp = Rotate (tmp))) return;
            // Checks for mirror solution
            if (Exists (tmp.Reverse ().ToArray ())) return;
         }
         sFinalSoln.Add (pos);
      }

      /// <summary>Display the chessboard with eight queens</summary>
      static void ChessBoard () {
         Console.OutputEncoding = Encoding.UTF8;
         for (int i = 1; i <= sFinalSoln.Count; i++) {
            Console.CursorTop = 2; Console.CursorLeft = 0;
            Console.WriteLine ($"Solution {(i == 0 ? i + 1 : i),2} of {sFinalSoln.Count}");
            var soln = i == 0 ? sFinalSoln[i] : sFinalSoln[i - 1];
            Console.WriteLine ("┌───┬───┬───┬───┬───┬───┬───┬───┐");
            for (int j = 0; j < 8; j++) {
               PlaceQueens (soln[j]);
               Console.WriteLine (j == 7 ? "└───┴───┴───┴───┴───┴───┴───┴───┘" : "├───┼───┼───┼───┼───┼───┼───┼───┤");
            }
            var k = Console.ReadKey (true);
            while (k.Key is not ConsoleKey.RightArrow and not ConsoleKey.LeftArrow) k = Console.ReadKey (true);
            if (i > 0 && k.Key == ConsoleKey.LeftArrow) { i -= 2; continue; }
         }
      }

      /// <summary>Check identical solutions are present or not</summary>
      /// <param name="test">Solution array</param>
      /// <returns>Returns true if the given solution array already exist in the list</returns>
      static bool Exists (int[] test) => sFinalSoln.Any (a => a.SequenceEqual (test));

      /// <summary>Check whether the position is safe to place queen</summary>
      /// <param name="row">Row position of the queen</param>
      /// <param name="col">Column positin of the queen</param>
      /// <returns>If the queen position is safe,it returns true</returns>
      static bool IsSafe (int row, int col) {
         for (int prevRow = 0; prevRow < row; prevRow++) {
            var prevCol = sColumn[prevRow];
            if (col == prevCol ||
               Math.Abs (row - prevRow) == Math.Abs (col - prevCol)) return false;
         }
         return true;
      }

      /// <summary>If the column is safe,print queen or print space</summary>
      /// <param name="qPos">Column to print queen or space</param>
      static void PlaceQueens (int qPos) {
         for (int j = 0; j < 8; j++)
            Console.Write ($"│ {(j == qPos ? "♕" : " ")} ");
         Console.WriteLine ("│");
      }

      /// <summary>Save the safe position in a solution array and save the all solution array in a list</summary>
      /// <param name="row">Row positon were columns going to be check</param>
      /// <param name="isUnique">It eliminates the duplicate solutions</param>
      static void QueenPosition (int row, bool isUnique) {
         for (int col = 0; col < 8; col++) {
            if (IsSafe (row, col)) {
               sColumn[row] = col;
               var sln = sColumn.ToArray ();
               if (row == 7) {
                  if (isUnique) AddUniqueSoln (sln);
                  else sFinalSoln.Add (sln);
               } else QueenPosition (row + 1, isUnique);
            }
         }
      }

      /// <summary>Rotates the given array at 90 degree</summary>
      /// <param name="soln">Solution array</param>
      /// <returns>Rotated solution array</returns>
      static int[] Rotate (int[] soln) {
         int[] tmp = new int[8];
         for (int i = 0; i < 8; i++)
            tmp[soln[i]] = 7 - i;
         return tmp;
      }
      #endregion

      #region Private -----------------------------------------------
      static int[] sColumn = new int[8];
      static List<int[]> sFinalSoln = new ();
      #endregion
   }
   #endregion
}