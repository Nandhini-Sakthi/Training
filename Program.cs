//Complex number.
using System;

namespace Training {
   #region Class Program -----------------------------------------------------------------------
   class Program {
      #region Method ---------------------------------------------
      //Gets input
      static void Main (string[] args) {
         ComplexNumber complexNumber1 = new (4, 5);
         ComplexNumber complexNumber2 = new (2, 3);
         // Addition
         Console.WriteLine ($"Sum: {ComplexNumber.Add (complexNumber1, complexNumber2)}");
         // Subtraction
         Console.WriteLine ($"Difference: {ComplexNumber.Sub (complexNumber1, complexNumber2)}");
         // Norm
         Console.WriteLine ($"Norm of complexNumber1: {complexNumber1.Norm}");
         #endregion
      }
      #endregion
   }

   #region Class ComplexNumber -----------------------------------------------------------------
   /// <summary>Implementation of complex number</summary>
   public class ComplexNumber {
      #region Constructor ----------------------------------------
      /// <summary>Members get initialize</summary>
      /// <param name="real">Real part</param>
      /// <param name="imaginary">Imaginary part</param>
      public ComplexNumber (double real, double imaginary) {
         Real = real;
         Imaginary = imaginary;
      }
      #endregion

      #region Property -------------------------------------------
      public double Real { get; set; }
      public double Imaginary { get; set; }
      public double Norm { get => Math.Sqrt (Real * Real + Imaginary * Imaginary); }
      #endregion

      #region Method ---------------------------------------------
      // Addition of two complex numbers
      public static ComplexNumber Add (ComplexNumber a, ComplexNumber b) => new (a.Real + b.Real, a.Imaginary + b.Imaginary);

      // Subtraction of two complex numbers
      public static ComplexNumber Sub (ComplexNumber a, ComplexNumber b) => new (a.Real - b.Real, a.Imaginary - b.Imaginary);

      // Overrides the default ToString method to the ComplexNumber as "Real + Imaginaryi" for conversion.
      public override string ToString () =>$"{Real} + {Imaginary}i";
      #endregion
   }
   #endregion
}