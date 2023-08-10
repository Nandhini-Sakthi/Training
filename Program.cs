using System;
for (; ; ) {
   Console.Write ("Enter a decimal number: ");
   if (int.TryParse (Console.ReadLine (), out int decimalnum) && decimalnum>0) {
      Console.WriteLine ($"Hexadecimal:{decimalnum:X}");
      string binary = "";
      while (decimalnum > 0) {
         int remainder = decimalnum % 2;
         binary = remainder.ToString () + binary;
         decimalnum /= 2;
      }
      Console.WriteLine ($"Binary:{binary}");
   }
   else
      Console.WriteLine ("enter valid number");
}