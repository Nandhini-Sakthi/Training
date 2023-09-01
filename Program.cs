using System;
if (int.TryParse (args[0], out int num)) 
   Console.WriteLine ($"The {num}th Armstrong number is: " + NthArmstrongNumber (num));
else {
   Console.WriteLine ("Please provide a positive integer as input.");
   return;
}
static int NthArmstrongNumber (int num) {
   int count = 0;
   int i = 0;
   while (count < num) {
      i++;
      if (IsArmstrong (i)) {
         count++;
      }
   }
    return i;
}
static bool IsArmstrong (int i) {
   int n = i.ToString ().Length;
   int temp = i;
   int result = 0;
   while (temp != 0) {
      int remainder = temp % 10;
      int power = (int) Math.Pow (remainder, n);
      result += power;
      temp /= 10;
   }
   return result == i;
}