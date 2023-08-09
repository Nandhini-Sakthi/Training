using System;
using System.ComponentModel;
using System.Runtime;
Console.Write ("Enter the first number: ");
int a = int.Parse (Console.ReadLine ());
Console.Write ("Enter the second number: ");
int b = int.Parse (Console.ReadLine ());
int gcd = 1;
for (int i = 2; i < a; i++) {
   if (a % i ==0 && b % i == 0) 
   {
      gcd = i * gcd;
   }
}
 Console.WriteLine ($"GCD of {a} and {b} is: {gcd}");
 int lcm = (a * b) / gcd;
 Console.WriteLine ($"LCM of {a} and {b} is: {lcm}");




