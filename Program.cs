// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch- July 2023.
// Copyright (c) Metamation India.                                                
// ---------------------------------------------------------------------------------------
// Program.cs                                                                     
// Program to implement double.Parse method that takes a string and returns a double.
// ---------------------------------------------------------------------------------------

using System;
using System.Linq;
namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary>Class program</summary>
   class Program {
      #region Method ---------------------------------------------
      /// <summary>Display output</summary>
      /// <param name="args"></param>
      static void Main (string[] args) {
         for (; ; ) {
            Console.WriteLine ("enter:");
            string input = Console.ReadLine ()!;
            if (MyParse.TryParse (input, out double result)) Console.WriteLine (result);
            else Console.WriteLine ("Invalid input. Please enter a valid number.");
         }
      }
      #endregion
   }
   #endregion

   #region MyParse ------------------------------------------------------------------------------
   /// <summary>Double precision floating point number representation</summary>
   public class MyParse {
      #region Implementation ----------------------------------------
      /// <summary>Calculate the before exp value</summary>
      /// <param name="inputs">Number before exp</param>
      /// <param name="intPart">Calculated value</param>
      /// <returns>Value before exp</returns>
      static bool BeforeExp (string inputs, out double intPart) {
         double factPart = 0.1, sign = 1;
         intPart = 0;
         if (inputs[0] == '-' || inputs[0] == '+') {
            sign = inputs[0] == '-' ? -1 : 1;
            // Skip the sign character
            inputs = inputs.Substring (1); 
         }
         if (inputs.Contains ('.')) {
            // Split the input using char '.'.
            string[] num = inputs.Split ('.');
            foreach (char c in num[0]) intPart = intPart * 10 + (c - '0');
            foreach (char c in num[1]) {
               intPart += (c - '0') * factPart;
               factPart *= 0.1;
            }
         } else
            foreach (char c in inputs) intPart = intPart * 10 + (c - '0');
         intPart *= sign;
         return true;
      }

      /// <summary>Implementation of double parse</summary>
      /// <param name="number">Input</param>
      /// <param name="result">Double parse value</param>
      /// <returns>Returns a double precision floating point number whether the input is valid</returns>
      public static bool TryParse (string number, out double result) {
         int expPow = 0, expSign = 1;
         double exp = 1;
         // Remove the space and change the upper character to lower character.
         string input = number.Trim ().ToLower ();
         if (ValidCheck (input)) {
            if (input.Contains ('e')) {
               // Split the input using char e.
               string[] expPart = input.Split ('e');
               foreach (char c in expPart[1]) {
                  if ((c == '-' || c == '+') && expPow == 0) expSign = c == '-' ? -1 : 1;
                  else if (char.IsDigit (c)) expPow = expPow * 10 + (c - '0');
               }
               // expPow represents exp power value.
               expPow *= expSign;
               // exp represents exp value.
               exp *= Math.Pow (10, expPow);
               if (!BeforeExp (expPart[0], out double intPart)) {
                  result = 0;
                  return false;
               }
               result = intPart * exp;
            } else
               if (!BeforeExp (input, out result)) return false;
            return true;
         } else {
            result = 0;
            return false;
         }
      }
     
      /// <summary>Check whether the input is valid or not</summary>
      /// <param name="input">Number</param>
      /// <returns>True while the input is valid</returns>
      static bool ValidCheck (string input) {
         if (string.IsNullOrWhiteSpace (input) || input.EndsWith ('+') || input.EndsWith ('-') || !IsNumber (input)) return false;
         return true;

         // Check the decimal part is valid or not.
         static bool DecCheck (string input) {
            if (input.Contains ('.')) {
               string[] numPart = input.Split ('.');
               if (numPart.Length! > 2 || numPart[1].Contains ('-') || numPart[1].Contains ('+') || !SignCheck (numPart[0])) return false;
               if (numPart[0] == "") return true;
               return true;
            }
            return true;
         }

         // Check the input is valid or not
         static bool IsNumber (string input) {
            if (IsNumeric (input)) {
               if (input.Contains ('e')) {
                  if (input.StartsWith ('e') || input.EndsWith ('e')) return false;
                  string[] intPart = input.Split ('e');
                  if (intPart[0].Length == 1 && intPart[0].Contains ('.')) return false;
                  if (intPart.Length > 2 || intPart[1].Contains ('.') || !SignCheck (intPart[1])) return false;
                  if (intPart[0].Contains ('.')) {
                     if (!DecCheck (intPart[0])) return false;
                  } else if (!SignCheck (intPart[0])) return false;
                  return true;
               } else if (input.Contains ('.')) {
                  if (!DecCheck (input)) return false;
               } else {
                  if (!SignCheck (input)) return false;
               }
               return true;
            }
            return false;
         }

         // Check the input is numeric or not.
         static bool IsNumeric (string input) => input.All (c => char.IsDigit (c) || c == '.' || c == '+' || c == '-' || c == 'e');

         // Check the sign character place for valid conditions.
         static bool SignCheck (string input) => input.All (c => char.IsDigit (c) || (input.StartsWith ('+') && input.Substring (1).All (char.IsDigit)) && input.Length > 1) ||
               (input.StartsWith ('-') && input.Substring (1).All (char.IsDigit) && input.Length > 1 && input.IndexOf ('-') == 0);
      }
      #endregion
   }
   #endregion
}