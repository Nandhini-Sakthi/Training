using System;
using System.Linq.Expressions;
Console.Write ("Enter a decimal number: ");
int decimalnum = int.Parse (Console.ReadLine());
string hexadecimalnum = decimalnum.ToString("X");
Console.WriteLine ($"Hexadecimal: {hexadecimalnum}");
string binary = "";
while (decimalnum > 0) {
   int remainder = decimalnum % 2;
   binary= Convert.ToString (remainder) + binary;
   decimalnum /= 2; }
 Console.WriteLine ($"Binary:{binary}");
