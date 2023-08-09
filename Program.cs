using System;
Console.Write ("Enter a decimal number: ");
bool var = int.TryParse (Console.ReadLine(),out int decimalnum);
string hexadecimalnum = decimalnum.ToString("X");
Console.WriteLine ($"Hexadecimal:{decimalnum:X}");
string binary = "";
while (decimalnum > 0) {
   int remainder = decimalnum % 2;
   binary= remainder.ToString() + binary;
   decimalnum /= 2; }
 Console.WriteLine ($"Binary:{binary}");
