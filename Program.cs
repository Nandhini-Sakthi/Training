//Complex Number
using System;

namespace Test {

   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("enter");
         string input = Console.ReadLine ();
         ComplexNumber complexNumber = new ComplexNumber ();
         Double output = complexNumber.Norm (input);
         Console.WriteLine (output);
      }

      #region class ComplexNumber --------------------------------------------------------------
      /// <summary>Complex number</summary>
      public class ComplexNumber {
         #region method ------------------------------------------
         /// <summary>Gets add and subtraction value</summary>
         /// <param name="input">Complex number</param>
         /// <returns>Complex number's magnitude value</returns>
         public double Norm (string input) {
            if (input.Contains ('+')) {
               char op = '+';
               return Calculate (op, input);
            } else if (input.Contains ('-')) {
               char op = '-';
               return Calculate (op, input);
            } else { return double.NaN; }
         }

         /// <summar>Calculate the values using operators</summary>
         /// <param name="op">Operators</param>
         /// <param name="input">Complex number</param>
         /// <returns>Values for complex number</returns>
         public Double Calculate (char op, string input) {
            string[] a = input.Split (op);
            double real = Double.Parse (a[0]);
            string img = "";
            foreach (char c in a[1]) if (c != 'i') img += c;
            double imag = Double.Parse (img);
            if (op == '+') {
               double exp = (real * real) + (imag * imag);
               return Math.Pow (exp, 0.5);
            } else {
               double exp = (real * real) - (imag * imag);
               return Math.Pow (exp, 0.5);
            }
            #endregion
         }
         #endregion
      }
   }
}