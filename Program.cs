using System;
for (; ; ) {
   Console.Write ("Enter the number :");
   string input = Console.ReadLine ();
   string[] substrings = input.Split ('.');
   if (substrings.Length >= 2) {
      string integralPart = substrings[0];
      string factorialPart = substrings[1];
      Console.WriteLine ("Integral part: " + integralPart + " Factorial part: " + factorialPart);
   }
}
}