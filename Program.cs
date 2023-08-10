using System;
class NumberConverter {
    static string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
    static string[] teens = { "", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
    static string[] tens = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

static string NumberToWords (int number) {
   if (number >= 1 && number < 10)
      return ones[number];
   else if (number >= 11 && number < 20)
      return teens[number - 10];
   else if (number >= 10 && number < 100)
      return tens[number / 10] + " " + ones[number % 10];
   else if (number >= 100 && number < 1000)
      return ones[number / 100] + " Hundred and " + NumberToWords (number % 100);
   else
      return "Number out of range";
}
 static string NumberToRoman (int number) {
   int[] val = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
   string[] syb = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
   string romanNum = "";
   int i = 0;
   while (number > 0) {
      int div = number / val[i];
      for (int j = 0; j < div; j++) {
         romanNum += syb[i];
         number -= val[i];
      }
      i++;
   }
   return romanNum;
}
 static void Main (string[] args) {
   Console.Write ("Enter a number: ");
   int number = int.Parse (Console.ReadLine ());

   Console.Write ("Choose conversion (1 for words, 2 for Roman numerals): ");
   int choice = int.Parse (Console.ReadLine ());

   switch (choice) {
      case 1:
         string words = NumberToWords (number);
         Console.WriteLine ($"{number} - {words}");
         break;
      case 2:
         string roman = NumberToRoman (number);
         Console.WriteLine ($"{number} - {roman}");
         break;
      default:
         Console.WriteLine ("Invalid choice");
         break;
   }
}
}


   