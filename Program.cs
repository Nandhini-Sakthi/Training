using System;
for (; ; ) {
   Console.Write ("Enter the first number: ");
   int.TryParse (Console.ReadLine (), out int a);
   Console.Write ("Enter the second number: ");
   int.TryParse (Console.ReadLine (), out int b);
   int newA = a;
   int gcd = CalculateGCD (a, b);
   int lcm = (newA * b) / gcd;
   Console.WriteLine ($"GCD of {newA} and {b} is: {gcd}");
   Console.WriteLine ($"LCM of {newA} and {b} is: {lcm}");
   static int CalculateGCD (int a, int b) {
      while (b != 0) {
         int temp = b;
         b = a % b;
         a = temp;
      }
      return a;
   }
}